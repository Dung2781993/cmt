using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using C3.Reporting.CMT.Business.Entities;
using C3.Reporting.CMT.Business.Services;
using C3.Reporting.CMT.Web.WebApp.Models;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System.Web;
using C3.Reporting.CMT.Core.Caching;
using Newtonsoft.Json;
using NLog;

namespace C3.Reporting.CMT.Web.WebApp.Controllers
{
    /// <summary>
    /// This controller is used to control all functions regarding Campaigns which includes the campaign CRUD operations, allowing permissions to users and managing campaign items
    /// </summary>
    public class CampaignController : Controller
    {
        #region Variables

        private static CampaignSet _campaigns;
        private static CampaignTypeSet _campaignTypeSet;
        private static StoreOptionTypeSet _storeOptionSet;
        private static StoreSet _stores;
        private static CampaignStoreSet _campaignStoreSet;
        private static RedemptionCodeSet _redemptionCodeSet;
        private static CampaignItemSet _campaignItems;
        private static CampaignStoreSet _campaignStores;
        private static ProductItemSet _productItemSet;
        private static ChannelSet _channels;
        private static List<SegmentEmailModel> _segmentDeletedItemsList;
        private static List<int> _affectedSegmentsList; 
        private static int _selectedCampaignId ;
        private static ChannelItemSet _channelItems;
        private static ChannelTypeSet _channelTypeSet;
        private static string _fileDownload;

        // NLog 
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        #endregion

        #region Init Methods
        /// <summary>
        /// The Campaign action to return Campaign view
        /// </summary>
        /// <returns></returns>
        public ActionResult Campaign()
        {
            if (ViewBag.RedemptionCodes == null)
                ViewBag.RedemptionCodes = GetRedemptionCodesModels();
            if (ViewBag.CampaignTypes == null)
                ViewBag.CampaignTypes = GetCampaignTypeModels();
            if (ViewBag.StoreOption == null)
                ViewBag.StoreOption = GetStoreOptionModels();

            IList<string> members = GetAdGroupMembers("ccubed.local");
            ViewBag.AdMembers = members;
            
            return View();
        }


        /// <summary>
        /// The CampaignItems action to return the CampaignItems view
        /// </summary>
        /// <returns></returns>
        public ActionResult CampaignItems()
        {
            if (ViewBag.RedemptionCodes == null)
                ViewBag.RedemptionCodes = GetRedemptionCodesModels();
            if (ViewBag.CampaignTypes == null)
                ViewBag.CampaignTypes = GetCampaignTypeModels();
            if (ViewBag.ProductItems == null)
                ViewBag.ProductItems = GetProductItemModels();

            IList<string> members = GetAdGroupMembers("ccubed.local");
            ViewBag.AdMembers = members;
 
            _affectedSegmentsList = new List<int>();
            _segmentDeletedItemsList = new List<SegmentEmailModel>();

            return View();
        }

        /// <summary>
        /// The CampaignItems action to return the CampaignItems view
        /// </summary>
        /// <returns></returns>
        public ActionResult ArchivedCampaigns()
        {
            if (ViewBag.RedemptionCodes == null)
                ViewBag.RedemptionCodes = GetRedemptionCodesModels();
            if (ViewBag.CampaignTypes == null)
                ViewBag.CampaignTypes = GetCampaignTypeModels();
            if (ViewBag.ChannelTypes == null)
                ViewBag.ChannelTypes = GetChannelTypeModels();
            if (ViewBag.ProductItems == null)
                ViewBag.ProductItems = GetProductItemModels();

            IList<string> members = GetAdGroupMembers("ccubed.local");
            ViewBag.AdMembers = members;

            return View();
        }

        #endregion

        #region Load Models
        /// <summary>
        /// Method to retrieve all campaigns from database and store into a campaign set
        /// </summary>
        /// <returns></returns>
        private static IEnumerable<CampaignViewModel> GetCampaignViewModels()
        {
            _campaigns = ServiceManagerProvider.GetCampaignManager().GetCampaigns();

            return _campaigns.OrderByDescending(campaign => campaign.StartDate).Select(campaign => new CampaignViewModel
            {
                    BusinessFormat = campaign.BusinessFormat,
                    CampaignId = campaign.CampaignId,
                    CampaignCode = campaign.CampaignCode,
                    CampaignName = campaign.CampaignName,
                    CampaignTypeId = campaign.CampaignTypeId,
                    Description = campaign.Description,
                    StartDate = campaign.StartDate,
                    EndDate = campaign.EndDate,
                    RedemptionCodeId = campaign.RedemptionCodeId,
                    IsLocked = campaign.IsLocked,
                    StoreOptionId = campaign.StoreOptionId,
                    CreatedBy = campaign.CreatedBy
            }).ToList();
        }


        /// <summary>
        /// Method to retrieve all campaign types from database
        /// </summary>
        /// <returns></returns>
        private static CampaignTypeSet GetCampaignTypeModels()
        {
            _campaignTypeSet = ServiceManagerProvider.GetCampaignTypeManager().GetCampaignTypes();

            foreach (var source in _campaignTypeSet.Select(campaignType => new CampaignTypeModel
            {
                CampaignTypeId = campaignType.CampaignTypeId,
                CampaignTypeName = campaignType.CampaignTypeName
            }).ToList())
            {
            }

            return _campaignTypeSet;
        }



        /// <summary>
        /// Method to retrieve all store options from database
        /// </summary>
        /// <returns></returns>
        private static StoreOptionTypeSet GetStoreOptionModels()
        {
            _storeOptionSet = ServiceManagerProvider.GetStoreOptionManager().GetStoreOptions();

            foreach (var source in _storeOptionSet.Select(storeOption => new StoreOptionModel()
            {
                StoreOptionId = storeOption.StoreOptionId,
                StoreOptionName = storeOption.StoreOptionName
            }).ToList())
            {
            }

            return _storeOptionSet;
        }


        /// <summary>
        /// Method to retrieve all stores from databases
        /// </summary>
        /// <returns></returns>
        private static StoreSet GetStoresModels()
        {
            _stores = ServiceManagerProvider.GetStoreManager().GetStore();
            foreach (var source in _stores.Select(store => new StoreModel()
            {
                StoreId = store.StoreId,
                StoreCode = store.StoreCode,
                StoreName = store.StoreName,
                BusinessName = store.BusinessName,
                OpenDate = store.OpenDate
            }).ToList())
            {
            }

            return _stores;
        }

        /// <summary>
        /// Method to retrieve redemption codes from database
        /// </summary>
        /// <returns></returns>
        private static IEnumerable<RedemptionCodeModel> GetRedemptionCodesModels()
        {
            _redemptionCodeSet = ServiceManagerProvider.GetRedemptionCodeManager().GetRedemptionCodes();

            // Select 'No Offer' redemption code to be top of list
            var lst = _redemptionCodeSet.Select(redemptionCode => new RedemptionCodeModel
                {
                    RedemptionCodeId = redemptionCode.RedemptionCodeId, OfferCode = redemptionCode.OfferCode, Description = redemptionCode.Description
                }).Where(redemptionCode => redemptionCode.RedemptionCodeId == 219).ToList();
            
            // Select remaining redemption codes
            lst.AddRange(_redemptionCodeSet.Select(redemptionCode => new RedemptionCodeModel
                {
                    RedemptionCodeId = redemptionCode.RedemptionCodeId, OfferCode = redemptionCode.OfferCode, Description = redemptionCode.Description
                }).Where(redemptionCode => redemptionCode.RedemptionCodeId != 219).ToList());

            return lst;
        }

        /// <summary>
        /// Method to retrieve all product items from database and store into a campaign set
        /// </summary>
        /// <returns></returns>
        private static async Task <IEnumerable<ProductItemModel>> GetProductItemModels()
        {
            _productItemSet = ServiceManagerProvider.GetProductItemManager().GetProductItems();

            var stockOnOrderCount = 0;
            var recentRecipeDate = DateTime.Now;

            var productList = _productItemSet.Select(productItem => new ProductItemModel
            {
                ProductId = productItem.ProductId,
                ItemCode = productItem.ItemCode,
                Description = productItem.Description,
                VendorCode = productItem.VendorCode,
                DepartmentName = productItem.DepartmentName,
                CategoryName = productItem.CategoryName,
                Lifestage = productItem.Lifestage,
                LimitedEdition = productItem.LimitedEdition,
                Price = productItem.UnitPrice,
                NzUnitPrice = productItem.NzUnitPrice,
                LaunchDate = productItem.LaunchDate,
                ExpectedReceiptDate = productItem.ExpectedReceiptDate,
                TerminationDate = productItem.TerminationDate,
                RangingCodeMecca = productItem.RangingCodeMecca,
                RangingCodeImo = productItem.RangingCodeImo,
                RangingCodeKit = productItem.RangingCodeKit,
                RangingCodeMaxima = productItem.RangingCodeMaxima,
                CompanySoh = productItem.CompanySoh,
                NoTester = productItem.NoTester,
                TravelSize = productItem.TravelSize,
                StockOnOrder = productItem.StockOnOrder,
                TransitionItemCode = productItem.TransitionItemCode
            }).ToList();


            foreach (var product in productList)
            {

                //Check Stock On Order of each item is Null
                if (product.StockOnOrder == null)
                {
                    product.StockOnOrder = stockOnOrderCount;
                }
                //Check if Recipe Date is the most recent             
                if (product.ExpectedReceiptDate != null)
                {
                    var result = DateTime.Compare(product.ExpectedReceiptDate.Value, recentRecipeDate);
                    if (result < 0)
                    {
                        product.ExpectedReceiptDate = null;
                    }
                }
            }


            return productList;
        }


        /// <summary>
        /// Method to retrieve all channel items from database and store into a channel item set
        /// </summary>
        /// <returns></returns>
        private static IEnumerable<ChannelItemModel> GetChannelItemModels()
        {
            _channelItems = ServiceManagerProvider.GetChannelItemManager().GetChannelItems();

            return _channelItems.Select(channelItem => new ChannelItemModel
                {
                    ChannelItemId = channelItem.ChannelItemId, ChannelId = channelItem.ChannelId, ProductId = channelItem.ProductId
                }).ToList();
        }


        /// <summary>
        /// Method to retrieve all campaigns from database and store into a campaign set
        /// </summary>
        /// <returns></returns>
        private static IEnumerable<CampaignStoreModel> GetCampaignStoreModels(int campaignId)
        {
            //Adding M010 & M110 to store Set
            var storeCode = ConfigurationManager.GetValue("IMOStoreCode");
            var campaign = ServiceManagerProvider.GetCampaignManager().GetCampaign(campaignId);
            var storeList = ServiceManagerProvider.GetStoreManager().GetStoreFromBusinessName(campaign.BusinessFormat);
            var storeSet = ServiceManagerProvider.GetStoreManager().GetStoreFromBusinessName(storeCode);
            foreach (var store in storeSet)
            {
                storeList.Add(store);
            }
            
            if (campaign.BusinessFormat.ToUpper() == "COMPANY")
            {
                storeList = ServiceManagerProvider.GetStoreManager().GetStore();
            }
            var selectedCampaignStores = ServiceManagerProvider.GetCampaignStoreManager().GetCampaignStoreById(campaignId);
            List<CampaignStoreModel> campaignStoreLists;
            try
            {
                if (storeList.Count == selectedCampaignStores.Count)
                {
                    campaignStoreLists = GetCampaignStores(selectedCampaignStores, campaignId);
                }
                else
                {
                    /*To do remove existing campaing stores and add the update stores*/
                    RemoveCampaignStore(campaignId);
                    CreateCampaignStore(campaignId);
                    selectedCampaignStores = ServiceManagerProvider.GetCampaignStoreManager().GetCampaignStoreById(campaignId);
                    campaignStoreLists = GetCampaignStores(selectedCampaignStores, campaignId);
                }             
            }
            catch (Exception exception)
            {
                Logger.Error(exception, $"MECCA CMT | ERROR: {exception.Message}");
                throw;
            }
            return campaignStoreLists;
        }

        /// <summary>
        /// Method to get all campaigns stores from database 
        /// </summary>
        /// <returns></returns>
        private static List<CampaignStoreModel> GetCampaignStores(IEnumerable<CampaignStore> campaignStores, int campaignId)
        {
            var campaignStoreLists = new List<CampaignStoreModel>();
            foreach (var campaignStore in campaignStores)
            {
                var storeSet = GetStoresModels();
                var storeInfo = storeSet.FirstOrDefault(c => c.StoreId == campaignStore.StoreId);
                if (storeInfo == null) continue;
                var stores = ServiceManagerProvider.GetCampaignStoreManager().GetCampaignStore(campaignId, storeInfo.StoreId);
                var storeModel = new CampaignStoreModel
                {
                    CampaignStoreId = campaignStore.CampaignStoreId,
                    StoreId = campaignStore.StoreId,
                    StoreCode = storeInfo.StoreCode,
                    BusinessName = storeInfo.BusinessName,
                    StoreName = storeInfo.StoreName,
                    CampaignId = campaignId,
                    OpenDate = storeInfo.OpenDate,
                    IsSelected = stores.IsSelected
                };
                campaignStoreLists.Add(storeModel);
            }
            return campaignStoreLists;
        }

        /// <summary>
        /// Method to retrieve all campaigns from database and items into a campaign set
        /// </summary>
        /// <returns></returns>
        private static async Task< IEnumerable<CampaignItemModel>> GetCampaignItemModels(int campaignId)
        {
            _campaignItems = ServiceManagerProvider.GetCampaignItemManager().GetCampaignItems();
            var selectedCampaign = _campaignItems.Where(e => e.CampaignId == campaignId);
            var campaignInfo = ServiceManagerProvider.GetCampaignManager().GetCampaign(campaignId);
            var campaignItemLists = new List<CampaignItemModel>();
            var recentRecipeDate = DateTime.Now;

            try
            {
                foreach (var campaignItem in selectedCampaign)
                {
                    var productInfo = _productItemSet.FirstOrDefault(e => e.ProductId == campaignItem.ProductId);
                    if (productInfo != null)
                    {
                        var productItemModel =  new CampaignItemModel
                        {
                            CampaignItemId = campaignItem.CampaignItemId,
                            CampaignId = campaignItem.CampaignId,
                            ProductId = campaignItem.ProductId,
                            ItemCode = productInfo.ItemCode,
                            Description = productInfo.Description,
                            VendorCode = productInfo.VendorCode,
                            DepartmentName = productInfo.DepartmentName,
                            CategoryName = productInfo.CategoryName,
                            Lifestage = productInfo.Lifestage,
                            LimitedEdition = productInfo.LimitedEdition,
                            UnitPrice = productInfo.UnitPrice,
                            NzUnitPrice = productInfo.NzUnitPrice,
                            StartDate = campaignInfo.StartDate,
                            EndDate = campaignItem.EndDate,
                            LaunchDate = productInfo.LaunchDate,
                            TerminationDate = productInfo.TerminationDate,
                            ExpectedReceiptDate = productInfo.ExpectedReceiptDate,
                            RangingCodeMecca = productInfo.RangingCodeMecca,
                            RangingCodeKit = productInfo.RangingCodeKit,
                            RangingCodeMaxima = productInfo.RangingCodeMaxima,
                            RangingCodeImo = productInfo.RangingCodeImo,
                            TransitionItemCode = productInfo.TransitionItemCode,
                            StockOnOrder = productInfo.StockOnOrder,
                            NoTester = productInfo.NoTester,
                            TravelSize = productInfo.TravelSize,
                            DateAdded = campaignItem.DateAdded
                        };

                        if (productItemModel.StockOnOrder == null)
                        {
                            productItemModel.StockOnOrder = 0;
                        }
                        if(productItemModel.ExpectedReceiptDate != null)
                        {
                            var result = DateTime.Compare(productItemModel.ExpectedReceiptDate.Value, recentRecipeDate);
                            if (result < 0)
                            {
                                productItemModel.ExpectedReceiptDate = null;
                            }
                        }

                        var campaign = _campaigns.FirstOrDefault(e => e.CampaignId == campaignId);
                        if (campaign == null) return null;          
                    
                        var itemListAu = await GetItemPrice(int.Parse(ConfigurationManager.GetValue("AustralianSite")), productItemModel.ItemCode, campaign.StartDate, campaign.EndDate).ConfigureAwait(false);
                        var itemListNz = await GetItemPrice(int.Parse(ConfigurationManager.GetValue("NewZealandSite")), productItemModel.ItemCode, campaign.StartDate, campaign.EndDate).ConfigureAwait(false);
                        
                       
                        var productItemAu = itemListAu as IList<ProductItemModel> ?? itemListAu.ToList();
                        var productItemNz = itemListNz as IList<ProductItemModel> ?? itemListNz.ToList();
                        var countAu = productItemAu.Count();
                        var countNz = productItemNz.Count();

                        //Check Price is changed during campaign
                        if (countAu > 0)
                        {
                            if (countAu == 1)
                            {
                                foreach (var item in productItemAu)
                                {
                                    productItemModel.UnitPrice = item.Price;
                                }
                            }
                            else
                            { 
                                productItemModel.UnitPrice = null;
                            }
                        }
                        if (countNz > 0)
                        {
                            if (countNz == 1)
                            {
                                foreach (var item in productItemNz)
                                {
                                    productItemModel.NzUnitPrice = item.Price;
                                }
                            }
                            else
                            {
                                productItemModel.NzUnitPrice = null;
                            }
                        }
                        if(countAu == 0)
                        {
                            var recentPriceAu = await GetLatestItemPrice(productItemModel.ItemCode, int.Parse(ConfigurationManager.GetValue("AustralianSite"))).ConfigureAwait(false);
                            if (recentPriceAu != null)
                            {
                                productItemModel.UnitPrice = recentPriceAu.Price;
                            }
                            else
                            {
                                productItemModel.UnitPrice = null;
                            }
                           
                        }
                        if (countNz == 0)
                        {
                            var recentPriceNz = await GetLatestItemPrice(productItemModel.ItemCode, int.Parse(ConfigurationManager.GetValue("NewZealandSite"))).ConfigureAwait(false);
                            if (recentPriceNz != null)
                            {
                                productItemModel.NzUnitPrice = recentPriceNz.Price;
                            }
                            else
                            {
                                productItemModel.NzUnitPrice = null;
                            }
                                            
                        }                        
                        
                        campaignItemLists.Add(productItemModel);
                    }
                }
            }
            catch (Exception exception)
            {
                Logger.Error(exception, $"MECCA CMT | ERROR: {exception.Message}");                
                throw;
            }

            return campaignItemLists;
        }

        private static ChannelTypeSet GetChannelTypeModels()
        {
            if (_channelTypeSet == null)
            {
                _channelTypeSet = ServiceManagerProvider.GetChannelTypeManager().GetChannelTypes();

                foreach (var source in _channelTypeSet.Select(channelType => new ChannelTypeModel
                {
                    ChannelTypeId = channelType.ChannelTypeId,
                    ChannelTypeName = channelType.ChannelTypeName
                }).ToList())
                {
                }
            }

            return _channelTypeSet;
        }
        #endregion

        #region Kendo Grid Methods

        /// <summary>
        /// Action method to read and return users campaigns
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public ActionResult MyCampaigns_Read([DataSourceRequest] DataSourceRequest request)
        {
            var user = ClearDomain(User.Identity.Name);
            
            // Not an assistant buyer, return logged in user's campaigns
            return Json(GetCampaignViewModels().Where(s => s.CreatedBy == user && s.IsLocked == false).ToDataSourceResult(request));
        }

        /// <summary>
        /// Action method to read and return users archived campaigns
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public ActionResult MyArchivedCampaigns_Read([DataSourceRequest] DataSourceRequest request)
        {
            var user = ClearDomain(User.Identity.Name);
            return Json(GetCampaignViewModels().Where(s => s.CreatedBy == user && s.IsLocked).ToDataSourceResult(request));
        }

        /// <summary>
        /// Action method to read and return all campaigns
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public ActionResult ActiveCampaigns_Read([DataSourceRequest] DataSourceRequest request)
        {            
            return Json(GetCampaignViewModels().Where(s => s.IsLocked == false).ToDataSourceResult(request));
        }

        /// <summary>
        /// Action method to read and return all campaigns
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public ActionResult OtherCampaigns_Read([DataSourceRequest] DataSourceRequest request)
        {
            var user = ClearDomain(User.Identity.Name);
            return Json(GetCampaignViewModels().Where(s => s.CreatedBy != user && s.IsLocked == false).ToDataSourceResult(request));
        }

        /// <summary>
        /// Action method to read and return all archived campaigns
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public ActionResult OtherArchivedCampaigns_Read([DataSourceRequest] DataSourceRequest request)
        {
            var user = ClearDomain(User.Identity.Name);
            return Json(GetCampaignViewModels().Where(s => s.CreatedBy != user && s.IsLocked).ToDataSourceResult(request));
        }

        /// <summary>
        /// Action method to read and return all offer codes
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public ActionResult OfferCode_Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(GetRedemptionCodesModels().ToDataSourceResult(request));
        }

        /// <summary>
        /// Action method to create a new campaign from the grid
        /// </summary>
        /// <param name="request"></param>
        /// <param name="campaignViewModel"></param>
        /// <returns></returns>
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult MyCampaign_Create([DataSourceRequest] DataSourceRequest request, CampaignViewModel campaignViewModel)
        {
            if (campaignViewModel != null && ModelState.IsValid)
            {
                var campaign = new Campaign
                {
                    BusinessFormat = campaignViewModel.BusinessFormat,
                    CampaignName = campaignViewModel.CampaignName,
                    CampaignTypeId = campaignViewModel.CampaignTypeId,
                    Description = campaignViewModel.Description,
                    StartDate = campaignViewModel.StartDate,
                    EndDate = campaignViewModel.EndDate,
                    RedemptionCodeId = 219, // create campaign with default offer code 'No Offer'
                    IsLocked = campaignViewModel.IsLocked,
                    StoreOptionId = campaignViewModel.StoreOptionId,
                    CreatedBy = ClearDomain(System.Web.HttpContext.Current.User.Identity.Name)
                };
                
                Campaign newCampaign = ServiceManagerProvider.GetCampaignManager().AddCampaign(campaign); // persist new campaign object to database

                // generate campaign_code and update campaign from newly inserted campaign
                string campaignCode = "C" + newCampaign.CampaignId;
                newCampaign.CampaignCode = campaignCode;
                ServiceManagerProvider.GetCampaignManager().UpdateCampaign(newCampaign); // update object to database
                campaignViewModel.CampaignCode = newCampaign.CampaignCode; // Set campaign code to return to view

                // add to campaign_owner table after campaign insert
                //var campaignOwner = new CampaignOwner { CampaignId = newCampaign.CampaignId, Owner = newCampaign.CreatedBy };
                //ServiceManagerProvider.GetCampaignOwnerManager().AddCampaignOwner(campaignOwner);

                campaign.CampaignCode = campaign.CampaignCode; // set campaign_code to the returned campaign
                campaignViewModel.RedemptionCodeId = 219; // set the model to contain a offer code
                campaignViewModel.CampaignId = newCampaign.CampaignId; // set the model to contain the campaign id returned from database

                _campaigns.Add(campaign); // add new campaign to campaignSet to be binded to grid


                //Create Stores for new campaign 

                CreateCampaignStore(campaign.CampaignId);


            }

            return Json(new[] { campaignViewModel }.ToDataSourceResult(request, ModelState));
        }

        /// <summary>
        /// Action method to update a user's campaign, it also checks if the campaign is being locked and if so, lock all of its segments
        /// </summary>
        /// <param name="request"></param>
        /// <param name="campaignViewModel"></param>
        /// <returns></returns>
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult MyCampaign_Update([DataSourceRequest] DataSourceRequest request, CampaignViewModel campaignViewModel)
        {

            if (campaignViewModel != null && ModelState.IsValid)
            {
                Campaign campaign = _campaigns.FirstOrDefault(c => c.CampaignId == campaignViewModel.CampaignId);
                if (campaign != null)
                {
                    campaign.BusinessFormat = campaignViewModel.BusinessFormat;
                    campaign.CampaignName = campaignViewModel.CampaignName;
                    campaign.CampaignTypeId = campaignViewModel.CampaignTypeId;
                    campaign.Description = campaignViewModel.Description;
                    campaign.StartDate = campaignViewModel.StartDate;
                    campaign.EndDate = campaignViewModel.EndDate;
                    campaign.RedemptionCodeId = campaignViewModel.RedemptionCodeId;
                    campaign.StoreOptionId = campaignViewModel.StoreOptionId;
                    campaign.IsLocked = campaignViewModel.IsLocked;
                    //last modified by field?

                    ServiceManagerProvider.GetCampaignManager().UpdateCampaign(campaign);

                    //Update campaign Store after changing store option ID
                    UpdateCampaignStore(campaign);

                    // check is_locked of updated campaign and lock its segments
                    if (campaign.IsLocked)
                    {
                        // get list of channel_id from campaign_id
                        _channels = ServiceManagerProvider.GetChannelManager().GetChannels();
                        var campaignSegments = _channels.Where(w => w.CampaignId == campaign.CampaignId).ToList();

                        // iterate through list of channel and remove any items from segments
                        foreach (var segment in campaignSegments)
                        {
                            // Attempt to find item in segment
                            Channel channel = _channels.FirstOrDefault(c => c.ChannelId == segment.ChannelId);

                            if (channel != null)
                            {
                                channel.ChannelName = segment.ChannelName;
                                channel.ChannelTypeId = segment.ChannelTypeId;
                                channel.Description = segment.Description;
                                channel.StartDate = segment.StartDate;
                                channel.EndDate = segment.EndDate;
                                channel.RedemptionCodeId = segment.RedemptionCodeId;
                                channel.IsLocked = true;

                                ServiceManagerProvider.GetChannelManager().UpdateChannel(channel);
                            }
                        }
                    }
                }
            }

            return Json(ModelState.IsValid ? new object() : ModelState.ToDataSourceResult());
        }


        /// <summary>
        /// Action method to update a other user's campaigns
        /// </summary>
        /// <param name="request"></param>
        /// <param name="campaignViewModel"></param>
        /// <returns></returns>
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult OtherCampaign_Update([DataSourceRequest] DataSourceRequest request, CampaignViewModel campaignViewModel)
        {
            if (campaignViewModel != null && ModelState.IsValid)
            {
                Campaign campaign = _campaigns.FirstOrDefault(c => c.CampaignId == campaignViewModel.CampaignId);
                if (campaign != null)
                {
                    campaign.BusinessFormat = campaignViewModel.BusinessFormat;
                    campaign.CampaignName = campaignViewModel.CampaignName;
                    campaign.CampaignTypeId = campaignViewModel.CampaignTypeId;
                    campaign.Description = campaignViewModel.Description;
                    campaign.StartDate = campaignViewModel.StartDate;
                    campaign.EndDate = campaignViewModel.EndDate;
                    campaign.StoreOptionId = campaignViewModel.StoreOptionId;
                    campaign.RedemptionCodeId = campaignViewModel.RedemptionCodeId;
                    
                    //last modified by field?

                    ServiceManagerProvider.GetCampaignManager().UpdateCampaign(campaign);

                    //Update campaign Store after changing store option ID
                    UpdateCampaignStore(campaign);
                }
            }
            return Json(ModelState.IsValid ? new object() : ModelState.ToDataSourceResult());
        }

        /// <summary>
        /// Action method to return campaign types to view
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public ActionResult CampaignTypes_Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(GetCampaignTypeModels().ToDataSourceResult(request));
        }

        /// <summary>
        /// Action method to return store options to view
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public ActionResult StoreOption_Read([DataSourceRequest] DataSourceRequest request)

        {
            return Json(GetStoreOptionModels().ToDataSourceResult(request));
        }

        /// <summary>
        /// Action method to return campaign items to view
        /// </summary>
        /// <param name="campaignId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public ActionResult CampaignItems_Read(int campaignId, [DataSourceRequest] DataSourceRequest request)
        {
            return Json(GetCampaignItemModels(campaignId).Result.Where(e => e.CampaignId == campaignId).ToDataSourceResult(request));
            //return Json(GetCampaignItemModels().Where(e => e.CampaignId == campaignId).ToDataSourceResult(request));
        }

        ///// <summary>
        ///// Action method to update campaign items 
        ///// </summary>
        ///// <param name="campaignId"></param>
        ///// <param name="request"></param>
        ///// <returns></returns>
        public ActionResult CampaignItems_Update(int campaignId, [DataSourceRequest] DataSourceRequest request, CampaignItemModel campaignItemModel)
        {
            if (campaignItemModel != null && ModelState.IsValid)
            {
                // Check if item is in campaign
                var campaignItemSet = ServiceManagerProvider.GetCampaignItemManager().GetCampaignItems();
                var campainItemToUpadate = campaignItemSet.FirstOrDefault(c => c.CampaignId == campaignId && c.ProductId == campaignItemModel.ProductId);
                var campaignInfo = ServiceManagerProvider.GetCampaignManager().GetCampaign(campaignId);
                if(campainItemToUpadate != null)
                {
                    campainItemToUpadate.StartDate = campaignInfo.StartDate;
                    campainItemToUpadate.EndDate = campaignItemModel.EndDate;
                    ServiceManagerProvider.GetCampaignItemManager().UpdateCampaignItem(campainItemToUpadate);
                }

            }
            return Json(ModelState.IsValid ? new object() : ModelState.ToDataSourceResult());
        }


        /// <summary>
        /// Action method to return campaign stores to view
        /// </summary>
        /// <param name="campaignId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public ActionResult CampaignStores_Read(int campaignId, [DataSourceRequest] DataSourceRequest request)
        {
            return Json(GetCampaignStoreModels(campaignId).Where(e => e.CampaignId == campaignId).ToDataSourceResult(request));
        }

        /// <summary>
        /// Action method to return campaign items to view
        /// </summary>
        /// <param name="campaignId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public ActionResult ProductItems_Read(int campaignId, [DataSourceRequest] DataSourceRequest request)
        {
            return Json(GetProductItemModels().Result.ToDataSourceResult(request));
        }

        #endregion

        #region Functionality Methods

        /// <summary>
        /// Export campaign items to CSV, allow users to save file
        /// </summary>
        /// <param name="request"></param>
        /// <param name="campaignId"></param>
        /// <returns></returns>
        public FileResult Export([DataSourceRequest]DataSourceRequest request, int campaignId)
        {
            //var campaignItems = GetCampaignItemModels().Where(campaignItem => campaignItem.CampaignId == campaignId).ToList();
            var campaignItems = GetCampaignItemModels(campaignId).Result.Where(campaignItem => campaignItem.CampaignId == campaignId).ToList();

            var output = new MemoryStream();
            var writer = new StreamWriter(output, Encoding.UTF8);

            writer.Write("ItemCode,");
            writer.Write("Description,");
            writer.Write("Vendor,");
            writer.Write("Department,");
            writer.Write("Category,");
            writer.Write("LimitedEd,");
            writer.Write("Lifestage,");
            writer.Write("AUD,");
            writer.Write("NZD,");
            writer.Write("Start Date,");
            writer.Write("End Date,");
            writer.Write("LaunchDate,");
            writer.Write("TerminationDate,");
            writer.Write("RangeMecca,");
            writer.Write("RangeMaxima,");
            writer.Write("RangeImo,");
            writer.Write("RangeKit,");
            writer.Write("CompanySoh,");
            writer.Write("StockOnOrder,");
            writer.Write("ExpectedReceiptDate,");
            writer.Write("NoTester,");
            writer.Write("TravelSize,");
            writer.Write("TransitionItemCode,");
            writer.Write("DateAdded");
            writer.WriteLine();

            foreach (var item in campaignItems)
            {
                var product = GetProductItemModels().Result.FirstOrDefault(o => o.ProductId == item.ProductId);

                if (product != null)
                {
                    writer.Write(product.ItemCode);
                    writer.Write(",");
                    writer.Write("\"");
                    writer.Write(product.Description);
                    writer.Write("\"");
                    writer.Write(",");
                    writer.Write("\"");
                    writer.Write(product.VendorCode);
                    writer.Write("\"");
                    writer.Write(",");
                    writer.Write("\"");
                    writer.Write(product.DepartmentName);
                    writer.Write("\"");
                    writer.Write(",");
                    writer.Write("\"");
                    writer.Write(product.CategoryName);
                    writer.Write("\"");
                    writer.Write(",");
                    writer.Write("\"");
                    writer.Write(product.LimitedEdition);
                    writer.Write("\"");
                    writer.Write(",");
                    writer.Write("\"");
                    writer.Write(product.Lifestage);
                    writer.Write("\"");
                    writer.Write(",");
                    writer.Write(product.Price);
                    writer.Write(",");
                    writer.Write(product.NzUnitPrice);
                    writer.Write(",");
                    writer.Write("\"");
                    writer.Write("{0:dd/MM/yyyy}", item.StartDate);
                    writer.Write("\"");
                    writer.Write(",");
                    writer.Write("\"");
                    writer.Write("{0:dd/MM/yyyy}", item.EndDate);
                    writer.Write("\"");
                    writer.Write(",");
                    writer.Write("\"");
                    writer.Write("{0:dd/MM/yyyy}", product.LaunchDate);
                    writer.Write("\"");
                    writer.Write(",");
                    writer.Write("\"");
                    writer.Write("{0:dd/MM/yyyy}", product.TerminationDate);
                    writer.Write("\"");
                    writer.Write(",");
                    writer.Write("\"");
                    writer.Write(product.RangingCodeMecca);
                    writer.Write("\"");
                    writer.Write(",");
                    writer.Write("\"");
                    writer.Write(product.RangingCodeMaxima);
                    writer.Write("\"");
                    writer.Write(",");
                    writer.Write("\"");
                    writer.Write(product.RangingCodeImo);
                    writer.Write("\"");
                    writer.Write(",");
                    writer.Write("\"");
                    writer.Write(product.RangingCodeKit);
                    writer.Write("\"");
                    writer.Write(",");
                    writer.Write(product.CompanySoh);
                    writer.Write(",");
                    writer.Write(product.StockOnOrder);
                    writer.Write(",");
                    writer.Write("\"");
                    writer.Write("{0:dd/MM/yyyy}", product.ExpectedReceiptDate);
                    writer.Write("\"");
                    writer.Write(",");
                    writer.Write("\"");
                    writer.Write(product.NoTester);
                    writer.Write("\"");
                    writer.Write(",");
                    writer.Write("\"");
                    writer.Write(product.TravelSize);
                    writer.Write("\"");
                    writer.Write(",");
                    writer.Write("\"");
                    writer.Write(product.TransitionItemCode);
                    writer.Write("\"");
                    writer.Write(",");
                    writer.Write("\"");
                    writer.Write("{0:dd/MM/yyyy}", item.DateAdded);
                    writer.Write("\"");
                    writer.WriteLine();
                }
            }
            writer.Flush();
            output.Position = 0;

            DateTime saveNow = DateTime.Now;
            string formatDate = saveNow.ToString("yyyyMMdd");
            string filename = "C" + campaignId + "_CampaignItems_" + formatDate + ".csv";

            return File(output, "text/comma-separated-values", filename);
        }

        protected string ClearDomain(string sItem)
        {
            int sLoc = (sItem.IndexOf("\\", StringComparison.Ordinal) + 1);
            string sOutPut = sItem.Substring(sLoc);

            return sOutPut;
        }

        /// <summary>
        /// Method which retrieves a list of users from the Active Directory group 'CMT'. This is managed through Active Directory services
        /// </summary>
        /// <param name="domainName"></param>
        /// <returns></returns>
        private IList<string> GetAdGroupMembers(string domainName)
        {
            IList<string> members = new List<String>();

            try
            {
                var ctx = new PrincipalContext(ContextType.Domain, domainName);
                GroupPrincipal grp = GroupPrincipal.FindByIdentity(ctx, IdentityType.Name, "CMT");

                if (grp == null)
                {
                    throw new ApplicationException(
                        "We did not find that group in that domain, perhaps the group resides in a different domain?");
                }

                foreach (Principal p in grp.GetMembers(true))
                {
                    members.Add(p.SamAccountName);
                }
                grp.Dispose();
                ctx.Dispose();
            }
            catch (Exception)
            {
                ViewBag.Error = "Load Active Directory CMT group failed.";
            }

            return members;
        }

        /// <summary>
        /// Action method to add items to campaign
        /// </summary>
        /// <param name="campaignId"></param>
        /// <param name="productId"></param>
        /// <param name="segmentAdd"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public ActionResult AddCampaignItem(int campaignId, int productId, bool segmentAdd, [DataSourceRequest] DataSourceRequest request)
        {
            // Test if campaignItem object and modelstate is valid.
            if (ModelState.IsValid)
            {
                // modify to parse current date
                var date = DateTime.Now;
                var selectedCampaign = ServiceManagerProvider.GetCampaignManager().GetCampaign(campaignId);
                var campaignItem = new CampaignItem { CampaignId = campaignId, ProductId = productId, DateAdded = date, StartDate = selectedCampaign.StartDate, EndDate = null};

                // Check if item is already in campaign
                CampaignItemSet campaignItemSet = ServiceManagerProvider.GetCampaignItemManager().GetCampaignItems();
                var campaignItemToAdd = campaignItemSet.FirstOrDefault(c => c.CampaignId == campaignId && c.ProductId == productId);

                if (campaignItemToAdd == null)
                {
                    ServiceManagerProvider.GetCampaignItemManager().AddCampaignItem(campaignItem);

                    // Add item to segment if checkbox is checked
                    if (segmentAdd)
                    {
                        // get list of channel_id from campaign_id
                        _channels = ServiceManagerProvider.GetChannelManager().GetChannels();
                        var channelIdList = _channels.Where(w => w.CampaignId == campaignId).Select(e => e.ChannelId).ToList();

                        // Traverse through all segments and add item
                        foreach (var chanId in channelIdList)
                        {
                            var isSegmentCatalogueType =
                                _channels.Where(w => w.ChannelId == chanId).Select(e => e.ChannelTypeId).First();

                            // Add items only to segments of catalogue type
                            if (Convert.ToInt32(isSegmentCatalogueType) == 1) // 1 = Catalogue channel type id
                            {
                                var channelItem = new ChannelItem {ChannelId = chanId, ProductId = productId};
                                // Check if item is already in segment
                                ChannelItemSet channelItemSet =
                                    ServiceManagerProvider.GetChannelItemManager().GetChannelItems();
                                ChannelItem channelItemToAdd =
                                    channelItemSet.FirstOrDefault(c => c.ChannelId == chanId && c.ProductId == productId);

                                if (channelItemToAdd == null)
                                {
                                    ServiceManagerProvider.GetChannelItemManager().AddChannelItem(channelItem);
                                }
                            }
                        }
                    }
                }
            }

            var json = new
            {
                success = true,
            };

            return Json(json);
        }

        /// <summary>
        /// Action method to delete items from campaign
        /// </summary>
        /// <param name="campaignId"></param>
        /// <param name="productId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public ActionResult DeleteCampaignItem(int campaignId, int productId, [DataSourceRequest] DataSourceRequest request)
        {
            // Test if campaignItem object and modelstate is valid.
            if (ModelState.IsValid)
            {
                _selectedCampaignId = campaignId;
                //List<CampaignItemModel> campaignItemSet = GetCampaignItemModels().Where(w => w.CampaignId == campaignId).ToList();
                List<CampaignItemModel> campaignItemSet = GetCampaignItemModels(campaignId).Result.Where(w => w.CampaignId == campaignId).ToList();
                CampaignItemModel campaignItemToDelete = campaignItemSet.FirstOrDefault(c => c.CampaignId == campaignId && c.ProductId == productId);

                if (campaignItemToDelete != null)
                {
                    var campaignItem = new CampaignItem { CampaignId = campaignItemToDelete.CampaignId, CampaignItemId = campaignItemToDelete.CampaignItemId, ProductId = campaignItemToDelete.ProductId };
                    ServiceManagerProvider.GetCampaignItemManager().DeleteCampaignItem(campaignItem);

                    // get list of channel_id from campaign_id
                    _channels = ServiceManagerProvider.GetChannelManager().GetChannels();
                    var channelIdList = _channels.Where(w => w.CampaignId == campaignId).Select(e => e.ChannelId).ToList();

                    // iterate through list of channel and remove any items from segments
                    foreach (var chanId in channelIdList)
                    {
                        // Attempt to find item in segment
                        List<ChannelItemModel> channelItemSet = GetChannelItemModels().Where(w => w.ChannelId == chanId).ToList();
                        ChannelItemModel channelItemToDelete = channelItemSet.FirstOrDefault(c => c.ChannelId == chanId && c.ProductId == productId);

                        if (channelItemToDelete != null)
                        {
                            var channelItem = new ChannelItem { ChannelId = channelItemToDelete.ChannelId, ChannelItemId = channelItemToDelete.ChannelItemId, ProductId = channelItemToDelete.ProductId };
                            ServiceManagerProvider.GetChannelItemManager().DeleteChannelItem(channelItem);

                            var item = new SegmentEmailModel { ChannelId = chanId, ProductId = productId };

                            _affectedSegmentsList.Add(chanId); // List of all segments affected from item removal
                            _segmentDeletedItemsList.Add(item); // Add the deleted item and segment

                        }
                    }
                }
            }

            var json = new
            {
                success = true,
            };

            return Json(json);
        }

        /// <summary>
        /// Action method to add unlock a campaign
        /// </summary>
        /// <param name="campaignId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public ActionResult UnlockCampaign(int campaignId, [DataSourceRequest] DataSourceRequest request)
        {
            Campaign campaign = _campaigns.FirstOrDefault(c => c.CampaignId == campaignId);
            if (campaign != null)
            {
                campaign.BusinessFormat = campaign.BusinessFormat;
                campaign.CampaignName = campaign.CampaignName;
                campaign.CampaignTypeId = campaign.CampaignTypeId;
                campaign.Description = campaign.Description;
                campaign.StartDate = campaign.StartDate;
                campaign.EndDate = campaign.EndDate;
                campaign.RedemptionCodeId = campaign.RedemptionCodeId;
                campaign.IsLocked = false;

                ServiceManagerProvider.GetCampaignManager().UpdateCampaign(campaign);

                // check is_locked of updated campaign and lock its segments
                if (!campaign.IsLocked)
                {
                    // get list of channel_id from campaign_id
                    _channels = ServiceManagerProvider.GetChannelManager().GetChannels();
                    var campaignSegments = _channels.Where(w => w.CampaignId == campaign.CampaignId).ToList();

                    // iterate through list of channel and remove any items from segments
                    foreach (var segment in campaignSegments)
                    {
                        // Attempt to find item in segment
                        Channel channel = _channels.FirstOrDefault(c => c.ChannelId == segment.ChannelId);

                        if (channel != null)
                        {
                            channel.ChannelName = segment.ChannelName;
                            channel.ChannelTypeId = segment.ChannelTypeId;
                            channel.Description = segment.Description;
                            channel.StartDate = segment.StartDate;
                            channel.EndDate = segment.EndDate;
                            channel.RedemptionCodeId = segment.RedemptionCodeId;
                            channel.IsLocked = false;

                            ServiceManagerProvider.GetChannelManager().UpdateChannel(channel);
                        }
                    }
                }
            }

            var json = new
            {
                success = true,
            };

            return Json(json);
        }

        /// <summary>
        /// Using the popup window, set and update the campaign offer code
        /// </summary>
        /// <param name="campaignId"></param>
        /// <param name="redemptionCodeId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public ActionResult SetCampaignOffer(int campaignId, int redemptionCodeId, [DataSourceRequest] DataSourceRequest request)
        {
                var campaign = _campaigns.FirstOrDefault(c => c.CampaignId == campaignId);
                if (campaign != null)
                {
                    campaign.RedemptionCodeId = redemptionCodeId;

                    ServiceManagerProvider.GetCampaignManager().UpdateCampaign(campaign);
                }

            var json = new
            {
                success = true,
            };

            return Json(json);
        }

        /// <summary>
        /// Using the popup window, set and update the campaign store code
        /// </summary>
        /// <param name="campaignId"></param>
        /// <param name="storeId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public ActionResult AddCampaignStore(int campaignId, int storeId,[DataSourceRequest] DataSourceRequest request)
        {
            if (ModelState.IsValid)
            {
                var date = DateTime.Now;
                var campaignStore = new CampaignStore { CampaignId = campaignId, StoreId = storeId,DateAdded = date};
                var campaignStoreToAdd = ServiceManagerProvider.GetCampaignStoreManager().GetCampaignStore(campaignId, storeId); 
                if (campaignStoreToAdd == null)
                {
                    ServiceManagerProvider.GetCampaignStoreManager().AddCampaignStore(campaignStore);
                }
            }  
            var json = new
            {
                success = true,
            };

            return Json(json);
        }

        /// <summary>
        ///  Action method to create stores from campaign
        /// </summary>
        /// <param name="campaign"></param>
        /// <returns></returns>
        private static void CreateCampaignStore(int campaignId)
        {
            var date = DateTime.Now;
            var campaign = ServiceManagerProvider.GetCampaignManager().GetCampaign(campaignId);
            var storeSet = ServiceManagerProvider.GetStoreManager().GetStoreFromBusinessName(campaign.BusinessFormat);
            //Adding M010 & M110  to store Set
            var storeCode = ConfigurationManager.GetValue("IMOStoreCode");
            var storeImo = ServiceManagerProvider.GetStoreManager().GetStoreFromBusinessName(storeCode);
            foreach (var item in storeImo)
            {
                storeSet.Add(item);
            }
            if (campaign.BusinessFormat.ToUpper() == "COMPANY")
            {
                storeSet = ServiceManagerProvider.GetStoreManager().GetStore();
            }
            foreach (var item in storeSet)
            {
                var campaignStore = new CampaignStore
                {
                    CampaignId = campaign.CampaignId,
                    StoreId = item.StoreId,
                    DateAdded = date,
                    IsSelected = true
                };
                if (campaign.StoreOptionId == 2)
                {
                    campaignStore.IsSelected = false;
                }
                ServiceManagerProvider.GetCampaignStoreManager().AddCampaignStore(campaignStore);
            }

        }

        /// <summary>
        ///  Action method to remove stores from campaign
        /// </summary>
        /// <param name="campaignId"></param>
        /// <returns></returns>
        private static void RemoveCampaignStore(int campaignId)
        {
            var existedCampaignStores = ServiceManagerProvider.GetCampaignStoreManager().GetCampaignStoreById(campaignId);
            ServiceManagerProvider.GetCampaignStoreManager().DeleteCampaignItem(existedCampaignStores);
        }

        /// <summary>
        ///  Action method to update stores from campaign if campaign store option change
        /// </summary>
        /// <param name="campaign"></param>
        /// <returns></returns>
        private static void UpdateCampaignStore(Campaign campaign)
        {
            try
            {
                var campaignStoreSet = ServiceManagerProvider.GetCampaignStoreManager().GetCampaignStores();
                var campaignStore = campaignStoreSet.Where(e => e.CampaignId == campaign.CampaignId);
                foreach (var item in campaignStore)
                {
                    item.IsSelected = false || campaign.StoreOptionId == 1;
                    ServiceManagerProvider.GetCampaignStoreManager().UpdateCampaignStore(item);
                }
            }
            catch (Exception exception)
            {
                Logger.Error(exception, $"MECCA CMT |Campaign ID: {campaign.CampaignId} | Updating Campaign Store ERROR: {exception.Message}");
                throw;
            }
        }


        /// <summary>
        ///  Action method to set stores from campaign
        /// </summary>
        /// <param name="campaignId"></param>
        /// <param name="storeId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public ActionResult ActivateCampaignStore(int campaignId, int storeId,int campaignStoreId, [DataSourceRequest] DataSourceRequest request)
        {
            if (ModelState.IsValid)
            {
                var campaignStoreSet = ServiceManagerProvider.GetCampaignStoreManager().GetCampaignStores();
                var campaignStoreToUpdate = campaignStoreSet.FirstOrDefault(c => c.CampaignId == campaignId && c.StoreId == storeId);
                if (campaignStoreToUpdate != null)
                {
                    campaignStoreToUpdate.IsSelected = true;
                    ServiceManagerProvider.GetCampaignStoreManager().UpdateCampaignStore(campaignStoreToUpdate);
                }
            }
            var json = new
            {
                success = true,
            };

            return Json(json);
        }

        /// <summary>
        /// Action method to delete stores from campaign
        /// </summary>
        /// <param name="campaignId"></param>
        /// <param name="storeId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public ActionResult DeleteCampaignStore(int campaignId, int storeId, [DataSourceRequest] DataSourceRequest request)
        {
            if (ModelState.IsValid)
            {
                var campaignStoreSet = ServiceManagerProvider.GetCampaignStoreManager().GetCampaignStores();
                var campaignStoreToDelete = campaignStoreSet.FirstOrDefault(c => c.CampaignId == campaignId && c.StoreId == storeId);
                if (campaignStoreToDelete != null)
                {
                    campaignStoreToDelete.IsSelected = false;
                    ServiceManagerProvider.GetCampaignStoreManager().UpdateCampaignStore(campaignStoreToDelete);
                }
            }
            var json = new
            {
                success = true,
            };

            return Json(json);
        }

        #endregion

        #region Filter Methods
        /// <summary>
        /// Return distinct business formats to dropdownlist for filtering
        /// </summary>
        /// <returns></returns>
        public ActionResult FilterMenuCustomization_Business()
        {
            return Json(GetCampaignViewModels().Select(e => e.BusinessFormat).Distinct(), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// Return distinct campaign codes to autocomplete for filtering
        /// </summary>
        /// <returns></returns>
        public ActionResult FilterMenuCustomization_CampaignCode()
        {
            return Json(GetCampaignViewModels().Select(e => e.CampaignCode).Distinct(), JsonRequestBehavior.AllowGet);
        }


        /// <summary>
        /// Return distinct offer codes to autocomplete for filtering
        /// </summary>
        /// <returns></returns>
        public ActionResult FilterMenuCustomization_OfferCode()
        {
            return Json(GetRedemptionCodesModels().Select(e => e.OfferCode).Distinct(), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// Return distinct offer codes to autocomplete for filtering
        /// </summary>
        /// <returns></returns>
        public ActionResult FilterMenuCustomization_StoreOption()
        {
            return Json(GetStoreOptionModels().Select(e => e.StoreOptionId).Distinct(), JsonRequestBehavior.AllowGet);
        }


        /// <summary>
        /// Return distinct store options to dropdownlist for filtering
        /// </summary>
        /// <returns></returns>
        public ActionResult FilterMenuCustomization_Store()
        {
            return Json(GetCampaignViewModels().Select(e => e.StoreOptionId).Distinct(), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// Return distinct store options to dropdownlist for filtering
        /// </summary>
        /// <returns></returns>
        public ActionResult FilterMenuCustomization_BusinessName()
        {
            return Json(GetStoresModels().Select(e => e.BusinessName).Distinct(), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// Return distinct vendors to dropdownlist for filtering
        /// </summary>
        /// <returns></returns>
        public ActionResult FilterMenuCustomization_Vendor()
        {
            return Json(GetProductItemModels().Result.OrderBy(e => e.VendorCode).Select(e => e.VendorCode).Distinct(), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// Return distinct department names for filtering
        /// </summary>
        /// <returns></returns>
        public ActionResult FilterMenuCustomization_Department()
        {
            return Json(GetProductItemModels().Result.Select(e => e.DepartmentName).Distinct(), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// Return distinct category names for filtering
        /// </summary>
        /// <returns></returns>
        public ActionResult FilterMenuCustomization_Category()
        {
            return Json(GetProductItemModels().Result.Select(e => e.CategoryName).Distinct(), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// Return distinct lifestages to dropdownlist for filtering
        /// </summary>
        /// <returns></returns>
        public ActionResult FilterMenuCustomization_Lifestage()
        {
            return Json(GetProductItemModels().Result.OrderBy(e => e.Lifestage).Select(e => e.Lifestage).Distinct(), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region Email Methods

        private string GetUserEmail(string user)
        {
            string emailAddress = "";

            try
            {
                var ctx = new PrincipalContext(ContextType.Domain, "ccubed.local");
                UserPrincipal userPrincipal = UserPrincipal.FindByIdentity(ctx, user);

                // Check the user email
                if (userPrincipal != null)
                {
                    PropertyCollection properties = ((DirectoryEntry)userPrincipal.GetUnderlyingObject()).Properties;
                    foreach (object property in properties["mail"])
                    {
                        emailAddress = property.ToString();
                    }
                    userPrincipal.Dispose();
                }

                ctx.Dispose();
            }
            catch (Exception)
            {
                ViewBag.Error = "Error attempting to retrieve user email.";
            }

            return emailAddress;
        }

        /// <summary>
        /// Consolidate all deleted items from segment into single email.
        /// </summary>
        /// <returns></returns>
        public ActionResult ProcessEmail()
        {
            // iterate through members and find email address to send
            IList<string> members = GetAdGroupMembers("ccubed.local");
            
            ProductItemSet productItemSet = ServiceManagerProvider.GetProductItemManager().GetProductItems();
            _affectedSegmentsList = _affectedSegmentsList.Distinct().ToList();

            foreach (var segmentId in _affectedSegmentsList)
            {
                var id = segmentId;
                var channelCreatedBy = _channels.Where(w => w.ChannelId == id).Select(s => s.CreatedBy).First();

                foreach (var cmtUser in members)
                {
                    var user = ClearDomain(cmtUser);
                    var emailAddress = GetUserEmail(user);

                    // FInd segment created_by and send mail to user via email address
                    if (user == channelCreatedBy)
                    {
                        var subject = "CMT Campaign C" + _selectedCampaignId + ": Items Removal Notification";
                        var line = "These items have been removed from your segment: S" + segmentId + "<br />=================================================<br />";
                            
                        string items = "";

                        foreach (var segmentItems in _segmentDeletedItemsList)
                        {
                            if (segmentItems.ChannelId == segmentId)
                            {
                                // Use productId to get Item information
                                ProductItem productItem = productItemSet.FirstOrDefault(c => c.ProductId == segmentItems.ProductId);

                                if (productItem != null)
                                {
                                    items += productItem.ItemCode + "," + productItem.VendorCode + "," + productItem.Description + "<br />";
                                }
                                else
                                {
                                    items += segmentItems.ProductId + "<br />";
                                }
                            }
                        }

                        const string endLine = "<br />Please be advised that it is recommended that you review your segment items. " +
                                               "Manage your segment by accessing the Campaign Management Tool: <br />" +
                                               "<a href=\"http://cmt.ccubed.local\" target=\"_blank\">http://cmt.ccubed.local</a>";
                        var body = line + items + endLine;

                        SendEmail(emailAddress, subject, body);
                    }
                }
            }

            var json = new
            {
                success = true,
            };

            return Json(json);
        }

        /// <summary>
        /// Send email notification for changes in campaign items
        /// </summary>
        /// <param name="toAddress"></param>
        /// <param name="subject"></param>
        /// <param name="body"></param>
        /// <param name="isBodyHtml"></param>
        public void SendEmail(string toAddress, string subject, string body, bool isBodyHtml = true)
        {
            try
            {
                var mailMessage = new MailMessage();
                mailMessage.To.Add(toAddress);
                mailMessage.Subject = subject;
                mailMessage.Body = body;
                mailMessage.IsBodyHtml = isBodyHtml;

                //var smtpClient = new SmtpClient { EnableSsl = false };
                var smtpClient = new SmtpClient();
                Object message = mailMessage;

                smtpClient.Send(mailMessage);
                //event handler for asynchronous call
                //smtpClient.SendCompleted += smtpClient_SendCompleted;
                //try
                //{
                //    smtpClient.SendAsync(mailMessage, message);
                //}
                //catch (Exception ex)
                //{
                //    TempData["EmailMsg"] = ex.Message;
                //}
            }
            catch (Exception ex)
            {
                var error = ex.Message;
                TempData["EmailMsg"] = error;
            }
            
        }

        void smtpClient_SendCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                //handle error
            }
            else if (e.Cancelled)
            {
                //handle cancelled
            }
            else
            {
                //Get the Original MailMessage object
                //handle sent email
                var message = (MailMessage)e.UserState;
                message.Dispose();
            }
        }
        #endregion

        #region Campain Item Uploading
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Upload(IEnumerable<HttpPostedFileBase> files, int campaignId)
        {
            var itemsNotAddedList = new List<UploadItemErrorModel>();

            if(files == null)
            {
                TempData["UploadResult"] = "Campaign C" + campaignId + ": " + "No file was selected";
                return RedirectToAction("CampaignItems");
            }
            try
            {
                //Loop through multiple uploaded files
                foreach(var file in files)
                {
                    if(file.ContentLength>0)
                    {
                        //Upload file on to sever dictionary
                        var fileName = Path.GetFileName(file.FileName);
                        var path = AppDomain.CurrentDomain.BaseDirectory + ConfigurationManager.GetValue("UploadFolderName") + fileName;
                        file.SaveAs(path);
                        var  csv = new StreamReader(path);
                        var resultMessage = "";
                        var warningMessage = "";
                        var errorMessage = "";
                        var counter = 0;
                        var date = DateTime.Now;
                        var error = 0;
                        
                        try
                        {
                            var itemCode = string.Empty;
                            while((itemCode = csv.ReadLine())!= null )
                            {
                                var productItemSet = ServiceManagerProvider.GetProductItemManager().GetProductItem(itemCode);
                                var uploadItems = new UploadItemErrorModel();
                                uploadItems.CampaignId = campaignId;
                                uploadItems.ItemCode = itemCode;
                                
                                //Check Item exist 
                                if (productItemSet != null)
                                {
                                    var selectedCampaign = ServiceManagerProvider.GetCampaignManager().GetCampaign(campaignId);
                                    var item = new CampaignItem { CampaignId = campaignId, CampaignItemId = campaignId , ProductId = productItemSet.ProductId, DateAdded = date, StartDate = selectedCampaign.StartDate, EndDate = null};

                                    /*To do Check item.productID  has been existed in this campaign */
                                    CampaignItemSet campaignItemSet = ServiceManagerProvider.GetCampaignItemManager().GetCampaignItems();
                                    CampaignItem campaignItemToAdd = campaignItemSet.FirstOrDefault(c => c.CampaignId == campaignId && c.ProductId == item.ProductId);
                                    if (campaignItemToAdd == null)
                                    {
                                        //Save to Database
                                        ServiceManagerProvider.GetCampaignItemManager().AddCampaignItem(item);
                                        counter++;
                                        resultMessage = "Campaign C" + campaignId + ": " + counter + " items added";
                                    }
                                    else
                                    {
                                        error++;
                                        errorMessage = "Campaign C" + campaignId + ": Item already exists in this campaign";                          
                                        uploadItems.ErrorMessage = errorMessage;
                                        itemsNotAddedList.Add(uploadItems);

                                    }
                                }
                                else{
                                    error++;
                                    errorMessage = "Campaign C" + campaignId + ": Item has invalid code";
                                    uploadItems.ErrorMessage = errorMessage;
                                    itemsNotAddedList.Add(uploadItems);
                                }
                            }
                            //Display Message
                            TempData["UploadResult"] = resultMessage;
                            TempData["WarningResult"] = null;
                            if (errorMessage != "" )
                            {
                                TempData["WarningResult"] = "Campaign C" + campaignId + " : Cannot add "+ error + " items";
                            }
                                
                           
                            // LOOP through and generate the log file
                            GenerateErrorLogFile(itemsNotAddedList, campaignId);

                        }
                        catch (Exception e)
                        {
                            ViewBag.Error = "The file could not be read:";
                        }

                        var fileToDelete = ConfigurationManager.GetValue("RemoveFolderName") + fileName;
                        csv.Dispose();

                        try
                        {
                            // Delete uploaded file after processing
                            System.IO.File.Delete(Server.MapPath(fileToDelete));
                        }
                        catch (Exception ex)
                        {
                            ViewBag.Error = ex.Message + " :Unable to delete file.";
                        }
                    }
                }
            }
            catch(Exception exception)
            {
                ViewBag.Error = "Upload Failed.";
            }

            return RedirectToAction("CampaignItems");
        }
        #endregion

        public bool GenerateErrorLogFile(List<UploadItemErrorModel> logs , int campaignId)
        {
            DateTime saveNow = DateTime.Now;
            var formatDate = saveNow.ToString("yyyyMMdd");
            var filename = "C" + campaignId + "_" + formatDate + ".csv";
            var output = AppDomain.CurrentDomain.BaseDirectory + ConfigurationManager.GetValue("LogFolderName") + filename;
            var writer = new StreamWriter(output,true);
            writer.Write("Campaign Id");
            writer.Write(",");
            writer.Write("Item Code");
            writer.Write(","); ;
            writer.Write("Messages");
            writer.WriteLine();
            foreach (var log in logs)
            {
                Console.WriteLine(logs);
                // Create file and log
                if (log !=null)
                {
                    writer.Write(log.CampaignId);
                    writer.Write(",");
                    writer.Write(log.ItemCode);
                    writer.Write(",");
                    writer.Write(log.ErrorMessage);
                    writer.WriteLine();
                }
            }
            writer.Flush();
            writer.Close();

            _fileDownload = filename;

            TempData["DownloadFile"] =  output;
            return true;
        }
        public ActionResult Download()
        {
            var filename = _fileDownload;
            var root = AppDomain.CurrentDomain.BaseDirectory + ConfigurationManager.GetValue("LogFolderName");
            var path = Path.Combine(root, filename);
            return File(path, "text/csv",filename);
        }


        /// <summary>
        /// Method to return item price from API based on siteId, item code and dates
        /// </summary>
        /// <param name="itemCode"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        private static async Task<IEnumerable<ProductItemModel>> GetItemPrice(int siteId, string itemCode, DateTime startTime, DateTime endTime)
        {
            var itemList = new List<ProductItemModel>();
            var client = new HttpClient();
            var dateFormat = "dd-MM-yyyy";
            var startTimeAttr = startTime.ToString(dateFormat).Trim('"');
            var endTimeAttr = endTime.ToString(dateFormat).Trim('"');
            var query = ConfigurationManager.GetConfigValueFromSection("pricingIntegration", "GetItemPriceBySiteIdItemCodeAndDates" ) + siteId + "/" + itemCode + "/startDate=" + startTimeAttr + "/endDate=" + endTimeAttr;
            var response = await client.GetAsync(query).ConfigureAwait(false);  
            var contentString = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode) return itemList;
            var prices = JsonConvert.DeserializeObject<IEnumerable<ProductItemModel>>(contentString);                
            itemList.AddRange(prices);

            client.Dispose();

            return itemList;
        }

        private static async Task<ProductItemModel> GetLatestItemPrice(string itemCode,int siteId)
        {

            var client = new HttpClient();            
            var query  = ConfigurationManager.GetConfigValueFromSection("pricingIntegration", "GetItemPriceBySiteIdItemCodeAndDates") + siteId + "/" + itemCode;

            var response = await client.GetAsync(query).ConfigureAwait(false);
            var contentString = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode) return null;
            var prices = JsonConvert.DeserializeObject<ProductItemModel>(contentString);

            client.Dispose();

            return prices;
        }
    }
}
 