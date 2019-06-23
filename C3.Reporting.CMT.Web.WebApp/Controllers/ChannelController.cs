using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using C3.Reporting.CMT.Business.Entities;
using C3.Reporting.CMT.Business.Services;
using C3.Reporting.CMT.Core.Caching;
using C3.Reporting.CMT.Web.WebApp.Mappings;
using C3.Reporting.CMT.Web.WebApp.Models;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using CsvHelper;
using Newtonsoft.Json;
using NLog;


namespace C3.Reporting.CMT.Web.WebApp.Controllers
{
    public class ChannelController : Controller
    {
        #region Variables

        private static ChannelSet _channels;
        private static CampaignSet _campaigns;
        private static StoreSet _stores;
        private static ChannelTypeSet _channelTypeSet;
        private static RedemptionCodeSet _redemptionCodeSet;
        private static CampaignTypeSet _campaignTypeSet;
        private static CampaignItemSet _campaignItems;
        private static ProductItemSet _productItemSet;
        private static ChannelItemSet _channelItems;
        private static StoreOptionTypeSet _storeOptionSet;
        private static string _fileDownload;


        // NLog 
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        #endregion

        #region Init Methods
        public ActionResult Channel()
        {
            if (ViewBag.RedemptionCodes == null)
                ViewBag.RedemptionCodes = GetRedemptionCodesModels();
            if (ViewBag.CampaignTypes == null)
                ViewBag.CampaignTypes = GetCampaignTypeModels();
            if (ViewBag.ChannelTypes == null)
                ViewBag.ChannelTypes = GetChannelTypeModels();
            if (ViewBag.Campaigns == null)
                ViewBag.Campaigns = GetCampaignViewModels();
            if (ViewBag.StoreOption == null)
                ViewBag.StoreOption = GetStoreOptionModels();

            return View();
        }

        //
        // GET: /ChannelCustomer/

        public ActionResult ChannelCustomer()
        {
            if (ViewBag.RedemptionCodes == null)
                ViewBag.RedemptionCodes = GetRedemptionCodesModels();
            if (ViewBag.ChannelTypes == null)
                ViewBag.ChannelTypes = GetChannelTypeModels();
            if (ViewBag.Campaigns == null)
                ViewBag.Campaigns = GetCampaignViewModels();

            return View();
        }

        //
        // GET: /ChannelItem/

        public ActionResult ChannelItems()
        {
            if (ViewBag.RedemptionCodes == null)
                ViewBag.RedemptionCodes = GetRedemptionCodesModels();
            if (ViewBag.CampaignTypes == null)
                ViewBag.CampaignTypes = GetCampaignTypeModels();
            if (ViewBag.ChannelTypes == null)
                ViewBag.ChannelTypes = GetChannelTypeModels();
            if (ViewBag.SegmentProducts == null)
                ViewBag.SegmentProducts = GetProductItemModels();
            if (ViewBag.Campaigns == null)
                ViewBag.Campaigns = GetCampaignViewModels();

            return View();
        }
        #endregion

        #region Load Models
        private static IEnumerable<ChannelModel> GetChannelModels()
        {
            _channels = ServiceManagerProvider.GetChannelManager().GetChannels();

            return _channels
                .OrderByDescending(channel => channel.StartDate)
                .Select(channel => new ChannelModel
                {
                    ChannelId = channel.ChannelId,
                    MasterCampaignId = channel.CampaignId,
                    ChannelCode = channel.ChannelCode,
                    ChannelName = channel.ChannelName,
                    ChannelTypeId = channel.ChannelTypeId,
                    Description = channel.Description,
                    SegStartDate = channel.StartDate,
                    SegEndDate = channel.EndDate,
                    StoreOptionId = channel.StoreOptionId,
                    RedemptionCodeId = channel.RedemptionCodeId,
                    IsLocked = channel.IsLocked,
                    CreatedBy = channel.CreatedBy
                }).ToList();

            // change this to show segments owned, ordered by start date
        }

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
                CreatedBy = campaign.CreatedBy
            }).ToList();
        }

        /// <summary>
        /// Method to retrieve all product items from database and store into a campaign set
        /// </summary>
        /// <returns></returns>
        private static IEnumerable<ProductItemModel> GetProductItemModels()
        {
            _productItemSet = ServiceManagerProvider.GetProductItemManager().GetProductItems();

            return _productItemSet.Select(productItem => new ProductItemModel
            {
                ProductId = productItem.ProductId,
                ItemCode = productItem.ItemCode,
                Description = productItem.Description,
                VendorCode = productItem.VendorCode,
                DepartmentName = productItem.DepartmentName,
                CategoryName = productItem.CategoryName,
                Lifestage = productItem.Lifestage,
                LimitedEdition = productItem.LimitedEdition,
                TerminationDate =  productItem.TerminationDate,
                Price = productItem.UnitPrice,
                NzUnitPrice = productItem.NzUnitPrice,
                LaunchDate = productItem.LaunchDate,
                RangingCodeMecca = productItem.RangingCodeMecca,
                RangingCodeImo = productItem.RangingCodeImo,
                RangingCodeKit = productItem.RangingCodeKit,
                RangingCodeMaxima = productItem.RangingCodeMaxima,
                CompanySoh = productItem.CompanySoh,
                TransitionItemCode = productItem.TransitionItemCode
            }).ToList();
        }

        private static CampaignTypeSet GetCampaignTypeModels()
        {
            if (_campaignTypeSet == null)
            {
                _campaignTypeSet = ServiceManagerProvider.GetCampaignTypeManager().GetCampaignTypes();

                foreach (var source in _campaignTypeSet.Select(campaignType => new CampaignTypeModel
                {
                    CampaignTypeId = campaignType.CampaignTypeId,
                    CampaignTypeName = campaignType.CampaignTypeName
                }).ToList())
                {
                }
            }

            return _campaignTypeSet;
        }

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

        /// <summary>
        /// Method to retrieve all store options from database
        /// </summary>
        /// <returns></returns>
        private static StoreOptionTypeSet GetStoreOptionModels()
        {
            _storeOptionSet = ServiceManagerProvider.GetStoreOptionManager().GetStoreOptions();

            foreach (var source in _storeOptionSet.Select(storeOption => new StoreOptionModel
            {
                StoreOptionId = storeOption.StoreOptionId,
                StoreOptionName = storeOption.StoreOptionName
            }).ToList())
            {
            }

            return _storeOptionSet;
        }

        private static IEnumerable<RedemptionCodeModel> GetRedemptionCodesModels()
        {
            _redemptionCodeSet = ServiceManagerProvider.GetRedemptionCodeManager().GetRedemptionCodes();
            var lst = _redemptionCodeSet.Select(redemptionCode => new RedemptionCodeModel
            {
                RedemptionCodeId = redemptionCode.RedemptionCodeId,
                OfferCode = redemptionCode.OfferCode,
                Description = redemptionCode.Description
            }).ToList().Where(redemptionCode => redemptionCode.RedemptionCodeId == 219).ToList();
            lst.AddRange(_redemptionCodeSet.Select(redemptionCode => new RedemptionCodeModel
            {
                RedemptionCodeId = redemptionCode.RedemptionCodeId,
                OfferCode = redemptionCode.OfferCode,
                Description = redemptionCode.Description
            }).ToList().Where(redemptionCode => redemptionCode.RedemptionCodeId != 219));

            return lst;
        }

        /// <summary>
        /// Method to retrieve all campaigns from database and store into a campaign set
        /// </summary>
        /// <returns></returns>
        private static IEnumerable<CampaignItemModel> GetCampaignItemModels(int campaignId)
        {
            _campaignItems = ServiceManagerProvider.GetCampaignItemManager().GetCampaignItems();

            var _selectedCampaign = _campaignItems.Where(e => e.CampaignId == campaignId);
            var campaignItemLists = new List<CampaignItemModel>();

            foreach (var campaignItem in _selectedCampaign)
            {
                var productInfo = _productItemSet.FirstOrDefault(e => e.ProductId == campaignItem.ProductId);

                if (productInfo != null)
                {
                    var productItemModel = new CampaignItemModel
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
                        TerminationDate = productInfo.TerminationDate,
                        UnitPrice = productInfo.UnitPrice,
                        NzUnitPrice = productInfo.NzUnitPrice,
                        LaunchDate = productInfo.LaunchDate,
                        RangingCodeMecca = productInfo.RangingCodeMecca,
                        RangingCodeKit = productInfo.RangingCodeKit,
                        RangingCodeMaxima = productInfo.RangingCodeMaxima,
                        RangingCodeImo = productInfo.RangingCodeImo,
                        TransitionItemCode = productInfo.TransitionItemCode,
                        DateAdded = campaignItem.DateAdded
                    };
                    campaignItemLists.Add(productItemModel);
                }
            }

            return campaignItemLists;
        }


        /// <summary>
        /// Method to retrieve all campaign store from database
        /// </summary>
        /// <returns></returns>
        private static IEnumerable<ChannelStoreModel> ChannelStores_Read(int channelId)
        {
            var campaign = ServiceManagerProvider.GetChannelManager().GetChannel(channelId);
            var campaignStores = ServiceManagerProvider.GetCampaignStoreManager().GetCampaignStoreByIdandSelectedStores(campaign.CampaignId);
            var channelStores = ServiceManagerProvider.GetChannelStoreManager().GetChannelStoreById(channelId);
            List<ChannelStoreModel> channelStoreLists;
            if (campaignStores.Count == channelStores.Count)
            {            
                channelStoreLists = GetChannelStores(channelStores);
            }
            else
            {
                /*To do remove existing segment stores and add the update stores*/
                RemoveSegmentStore(channelId);
                CreateSegmentStore(channelId,campaign.CampaignId);
                channelStores = ServiceManagerProvider.GetChannelStoreManager().GetChannelStoreById(channelId);
                channelStoreLists = GetChannelStores(channelStores);
            }
            return channelStoreLists;
        }

        /// <summary>
        /// Method to get all segment stores from database 
        /// </summary>
        /// <returns></returns>
        private static List<ChannelStoreModel> GetChannelStores(IEnumerable<ChannelStore> channelStores)
        {
            var channelStoreLists = new List<ChannelStoreModel>();
            foreach (var channelStore in channelStores)
            {
                var storeSet = GetStoresModels();
                var storeInfo = storeSet.FirstOrDefault(c => c.StoreId == channelStore.StoreId);
                if (storeInfo == null) continue;
                var channelStoreModel = new ChannelStoreModel
                {
                    ChannelStoreId = channelStore.ChannelStoreId,
                    ChannelId = channelStore.ChannelId,
                    CampaignId = channelStore.CampaignId,
                    DateAdded = channelStore.DateAdded,
                    StoreId = channelStore.StoreId,
                    StoreCode = storeInfo.StoreCode,
                    StoreName = storeInfo.StoreName,
                    BusinessName = storeInfo.BusinessName,
                    OpenDate = storeInfo.OpenDate,
                    IsSelected = channelStore.IsSelected
                };
                channelStoreLists.Add(channelStoreModel);
            }
            return channelStoreLists;
        }

        /// <summary>
        /// Method to retrieve all channel items from database and store into a channel item set
        /// </summary>
        /// <returns></returns>
        //private static IEnumerable<ChannelItemModel> GetChannelItemModels()
        private static async Task<IEnumerable<ChannelProductItemModel>> GetChannelItemModels(int channelId)
        {
            _channelItems = ServiceManagerProvider.GetChannelItemManager().GetChannelItems();

            var _selectedChannel = _channelItems.Where(e => e.ChannelId == channelId);
            var channelItemLists = new List<ChannelProductItemModel>();
            try
            {
                foreach (var channeltem in _selectedChannel)
                {
                    var productInfo = _productItemSet.FirstOrDefault(e => e.ProductId == channeltem.ProductId);
                    if (productInfo != null)
                    {
                        var productItemModel = new ChannelProductItemModel
                        {
                            ChannelItemId = channeltem.ChannelItemId,
                            ChannelId = channeltem.ChannelId,
                            ProductId = channeltem.ProductId,
                            TesterMerchQty = channeltem.TesterMerchQty,
                            LiveMerchQty = channeltem.LiveMerchQty,
                            Comments = channeltem.Comments,
                            SampleQty = channeltem.SampleQty,
                            ItemCode = productInfo.ItemCode,
                            Description = productInfo.Description,
                            VendorCode = productInfo.VendorCode,
                            DepartmentName = productInfo.DepartmentName,
                            CategoryName = productInfo.CategoryName,
                            Lifestage = productInfo.Lifestage,
                            LimitedEdition = productInfo.LimitedEdition,
                            UnitPrice = productInfo.UnitPrice,
                            NzUnitPrice = productInfo.NzUnitPrice,
                            LaunchDate = productInfo.LaunchDate,
                            RangingCodeMecca = productInfo.RangingCodeMecca,
                            RangingCodeKit = productInfo.RangingCodeKit,
                            RangingCodeMaxima = productInfo.RangingCodeMaxima,
                            RangingCodeImo = productInfo.RangingCodeImo,
                            TransitionItemCode = productInfo.TransitionItemCode,
                            NumStores = channeltem.NumStores
                        };
                        
                        var channel = _channels.FirstOrDefault(c => c.ChannelId == channelId);
                        if (channel == null) return null;

                        var itemListAu = await GetItemPrice(int.Parse(ConfigurationManager.GetValue("AustralianSite")), productItemModel.ItemCode, channel.StartDate, channel.EndDate).ConfigureAwait(false);
                        var itemListNz = await GetItemPrice(int.Parse(ConfigurationManager.GetValue("NewZealandSite")), productItemModel.ItemCode, channel.StartDate, channel.EndDate).ConfigureAwait(false);

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
                        if (countAu == 0)
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

                        channelItemLists.Add(productItemModel);
                    }
                }
            }
            catch (Exception exception)
            {
                Logger.Error(exception, $"MECCA CMT | ERROR: {exception.Message}");                
                throw;
            }

            return channelItemLists;
        }
        #endregion

        #region Kendo Grid methods
        public ActionResult Campaign_Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(GetCampaignViewModels().Where(s => s.IsLocked == false).ToDataSourceResult(request));
        }

        public ActionResult FilterMenuCustomization_BusinessName()
        {
            return Json(GetStoresModels().Select(e => e.BusinessName).Distinct(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Channel_Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(GetChannelModels().Where(s => s.IsLocked == false).ToDataSourceResult(request));
        }


        public ActionResult HierarchyBinding_Channels(int campaignId, [DataSourceRequest] DataSourceRequest request)
        {
            return Json(GetChannelModels()
                .Where(channel => channel.MasterCampaignId == campaignId)
                .ToDataSourceResult(request));
        }

        public ActionResult Channels_Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(GetChannelModels()
                .ToDataSourceResult(request));
        }

        public ActionResult FilterMenuCustomization_StoreOption()
        {
            return Json(GetStoreOptionModels().Select(e => e.StoreOptionId).Distinct(), JsonRequestBehavior.AllowGet);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult HierarchyBinding_Create([DataSourceRequest] DataSourceRequest request, ChannelModel channelModel, int campaignId)
        {
            if (channelModel != null && ModelState.IsValid)
            {
                var channel = new Channel
                {
                    CampaignId = campaignId,
                    ChannelName = channelModel.ChannelName,
                    ChannelTypeId = channelModel.ChannelTypeId,
                    Description = channelModel.Description,
                    StartDate = channelModel.SegStartDate,
                    EndDate = channelModel.SegEndDate,
                    StoreOptionId = channelModel.StoreOptionId,
                    RedemptionCodeId = 219, // Create segment with default offer of 'No Offer'
                    CreatedBy = ClearDomain(System.Web.HttpContext.Current.User.Identity.Name)
                };

                var newChannel = ServiceManagerProvider.GetChannelManager().AddChannel(channel); // persist new channel object to database

                // generate channel_code and update channel from newly inserted channel
                var channelCode = "S" + newChannel.ChannelId;
                newChannel.ChannelCode = channelCode;
                ServiceManagerProvider.GetChannelManager().UpdateChannel(newChannel); // update object to database
                channelModel.ChannelCode = newChannel.ChannelCode; // Set channel code to return to view

                // add to channel_owner table after channel insert
                //var channelOwner = new ChannelOwner { CampaignId = newChannel.CampaignId, ChannelId = newChannel.ChannelId, Owner = newChannel.CreatedBy };
                //ServiceManagerProvider.GetChannelOwnerManager().AddChannelOwner(channelOwner);

                channel.ChannelCode = newChannel.ChannelCode; // set channel_code to the returned channel
                channelModel.RedemptionCodeId = 219; // set the model to contain a offer code
                channelModel.ChannelId = newChannel.ChannelId; // set the model to contain the channel id returned from database

                //Create Stores for new Channel 

                CreateSegmentStore( channel.ChannelId, channel.CampaignId);
            }

            return Json(new[] { channelModel }.ToDataSourceResult(request, ModelState));
        }

        public ActionResult HierarchyBinding_Update([DataSourceRequest] DataSourceRequest request, ChannelModel channelModel)
        {
            if (channelModel != null && ModelState.IsValid)
            {
                var channel = _channels.FirstOrDefault(c => c.ChannelId == channelModel.ChannelId);
                if (channel != null)
                {
                    channel.ChannelName = channelModel.ChannelName;
                    channel.ChannelTypeId = channelModel.ChannelTypeId;
                    channel.Description = channelModel.Description;
                    channel.StartDate = channelModel.SegStartDate;
                    channel.EndDate = channelModel.SegEndDate;
                    channel.StoreOptionId = channelModel.StoreOptionId;
                    channel.RedemptionCodeId = channelModel.RedemptionCodeId;

                    ServiceManagerProvider.GetChannelManager().UpdateChannel(channel);
                }
                //Update campaign Store after changing store option ID
                UpdateSegmentStore(channel);

            }
            return Json(new[] { channelModel }.ToDataSourceResult(request, ModelState));
        }

        /// <summary>
        /// Action method to return campaign items to view
        /// </summary>
        /// <param name="campaignId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public ActionResult CampaignItems_SegmentRead(int campaignId, [DataSourceRequest] DataSourceRequest request)
        {
            return Json(GetCampaignItemModels(campaignId).Where(e => e.CampaignId == campaignId).ToDataSourceResult(request));
        }

        /// <summary>
        /// Action method to return campaign stores to view
        /// </summary>
        /// <param name="campaignId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public ActionResult CampaignStores_SegmentRead(int channelId, [DataSourceRequest] DataSourceRequest request)
        {
            return Json(ChannelStores_Read(channelId).Where(e => e.ChannelId == channelId).ToDataSourceResult(request));        
        }

        /// <summary>
        /// Action method to return campaign items to view
        /// </summary>
        /// <param name="channelId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public ActionResult SegmentItems_Read(int channelId, [DataSourceRequest] DataSourceRequest request)
        {
            return Json(GetChannelItemModels(channelId).Result.OrderBy(e => e.VendorCode)
                .Where(channelItem => channelItem.ChannelId == channelId)
                .ToDataSourceResult(request));
        }

        /// <summary>
        /// Action method to return campaign items to view
        /// </summary>
        /// <param name="channelId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public ActionResult SegmentItems_Update(int channelId, [DataSourceRequest] DataSourceRequest request, ChannelItemModel channelItemModel)
        {
            if (channelItemModel != null && ModelState.IsValid)
            {
                // Check if item is in campaign
                var channelItemSet = ServiceManagerProvider.GetChannelItemManager().GetChannelItems();
                var channelItemToUpdate = channelItemSet.FirstOrDefault(c => c.ChannelId == channelId && c.ProductId == channelItemModel.ProductId);

                if (channelItemToUpdate != null)
                {
                    channelItemToUpdate.TesterMerchQty = channelItemModel.TesterMerchQty;
                    channelItemToUpdate.LiveMerchQty = channelItemModel.LiveMerchQty;
                    channelItemToUpdate.Comments = channelItemModel.Comments;
                    channelItemToUpdate.SampleQty = channelItemModel.SampleQty;
                    channelItemToUpdate.NumStores = channelItemModel.NumStores;

                    ServiceManagerProvider.GetChannelItemManager().UpdateChannelItem(channelItemToUpdate);
                }
            }
            return Json(ModelState.IsValid ? new object() : ModelState.ToDataSourceResult());
        }

        #endregion

        #region Functionality Methods
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Upload(IEnumerable<HttpPostedFileBase> files, int channelId)
        {
            if (files == null)
            {
                TempData["UploadResult"] = "Segment S" + channelId + ": " + "No file was selected.";

                return RedirectToAction("ChannelCustomer");
            }

            var channelCustomerSet = new ChannelCustomerSet();
            var conn = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString.SQL Server (SqlClient)"].ConnectionString;
            try
            {
                // Loop through multiple uploaded files
                foreach (var file in files)
                {
                    if (file.ContentLength > 0)
                    {
                        // Upload file on to server directory
                        var fileName = Path.GetFileName(file.FileName);
                        var path = AppDomain.CurrentDomain.BaseDirectory + "Upload\\" + fileName;
                        file.SaveAs(path);

                        // CsvHelper configuration
                        var csv = new CsvReader(new StreamReader(path));
                        csv.Configuration.RegisterClassMap<CsvFieldMapper>();
                        var readChannelCustomers = csv.GetRecords<UploadCustomerModel>().ToList();

                        foreach (var readChannelCustomer in readChannelCustomers)
                        {
                            var customer = new ChannelCustomer { ChannelId = channelId, CustomerSid = readChannelCustomer.CustomerSid };
                            channelCustomerSet.Add(customer);
                        }

                        var fileToDelete = "~/Upload/" + fileName;
                        csv.Dispose();


                        // bulk insert customers to segment using SqlBulkCopy into MSSQL
                        var rdr = new StreamReader(path);

                        //Stream reader reads a file. File path and name are supplied from where to read the file. 
                        var inputLine = "";
                        var dt = new DataTable();
                        //A data table is similar to a Database table. 
                        //Define the columns.
                        dt.Columns.Add("channel_customer_id");
                        dt.Columns.Add("channel_id");
                        dt.Columns.Add("customer_sid");

                        DataRow row; //Declare a row, which will be added to the above data table
                        while ((inputLine = rdr.ReadLine()) != null)
                        //Read while the line is not null
                        {
                            var arr = inputLine.Split(',');
                            //splitting the line which was read by the stream reader object
                            row = dt.NewRow();
                            row["channel_id"] = channelId;
                            row["customer_sid"] = arr[0];
                            dt.Rows.Add(row);
                        }
                        dt.Rows.RemoveAt(0); //Remove the first column since its the column name

                        rdr.Close(); //release the stream reader

                        // Use SqlBulkCopy to write to server ignoring duplicates are set on the channel_customer database
                        using (var copy = new SqlBulkCopy(conn))
                        {
                            copy.ColumnMappings.Add("channel_id", "channel_id");
                            copy.ColumnMappings.Add("customer_sid", "customer_sid");
                            copy.DestinationTableName = "channel_customers";
                            copy.WriteToServer(dt);
                        }

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
            catch (Exception ex)
            {
                TempData["UploadResult"] = "Segment S" + channelId + ": Upload Failed.";
                return RedirectToAction("ChannelCustomer");
            }

            // Use Stored Procedure to read total customers in given segment
            using (var connection = new SqlConnection(conn))
            using (var command = new SqlCommand("GetSegmentCustomers", connection)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            })
            {
                command.Parameters.Add("@channelId", SqlDbType.Int).Value = channelId;

                var countCustomers = command.Parameters.Add("@totalCustomers", SqlDbType.Int);
                countCustomers.Direction = ParameterDirection.Output;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                var res = (int)command.Parameters["@totalCustomers"].Value;

                var resultMessage = "Segment S" + channelId + ": " + res + " customers uploaded.";
                TempData["UploadResult"] = resultMessage;
            }

            return RedirectToAction("ChannelCustomer");
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Delete(int channelId)
        {
            try
            {
                // Use Stored Procedure to read total customers in given segment, using the LoadChannelCustomer method was receiving OutOfMemory exception
                var conn = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString.SQL Server (SqlClient)"].ConnectionString;
                using (var connection = new SqlConnection(conn))
                using (var command = new SqlCommand("DeleteSegmentCustomers", connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                })
                {
                    command.Parameters.Add("@channelId", SqlDbType.Int).Value = channelId;

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    // Redirect to a view showing the result of the form submission.
                    var resultMessage = "Segment S" + channelId + ": All customers removed.";
                    TempData["UploadResult"] = resultMessage;
                }
            }
            catch (Exception)
            {
                ViewBag.Error = "Unable to delete customers.";
            }

            return RedirectToAction("ChannelCustomer");
        }

        /// <summary>
        /// Method used in Segment Customers to verify the count of customers for a selected segment
        /// </summary>
        /// <param name="channelId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult VerifySegmentCustomer(int channelId, [DataSourceRequest] DataSourceRequest request)
        {
            try
            {
                var conn = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString.SQL Server (SqlClient)"].ConnectionString;
                // Use Stored Procedure to read total customers in given segment
                using (var connection = new SqlConnection(conn))
                using (var command = new SqlCommand("GetSegmentCustomers", connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                })
                {
                    command.Parameters.Add("@channelId", SqlDbType.Int).Value = channelId;

                    var countCustomers = command.Parameters.Add("@totalCustomers", SqlDbType.Int);
                    countCustomers.Direction = ParameterDirection.Output;

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    var res = (int)command.Parameters["@totalCustomers"].Value;

                    var resultMessage = "Segment S" + channelId + ": " + res + " total customer(s) in segment.";
                    TempData["UploadResult"] = resultMessage;
                }
            }
            catch (Exception)
            {
                ViewBag.Error = "Unable to verify customers.";
            }

            return RedirectToAction("ChannelCustomer");
        }

        /// <summary>
        /// Action method to add items to segment from a list of campaign items
        /// </summary>
        /// <param name="channelId"></param>
        /// <param name="productId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public ActionResult AddChannelItem(int channelId, int productId, [DataSourceRequest] DataSourceRequest request)
        {
            // Test if campaignItem object and modelstate is valid.
            if (ModelState.IsValid)
            {
                var channelItem = new ChannelItem { ChannelId = channelId, ProductId = productId };

                // Check if item is already in campaign
                var channelItemSet = ServiceManagerProvider.GetChannelItemManager().GetChannelItems();
                var channelItemToAdd = channelItemSet.FirstOrDefault(c => c.ChannelId == channelId && c.ProductId == productId);

                if (channelItemToAdd == null)
                {
                    ServiceManagerProvider.GetChannelItemManager().AddChannelItem(channelItem);
                }
            }

            var json = new
            {
                success = true,
            };

            return Json(json);
        }

        /// <summary>
        /// Action method to delete items from segment
        /// </summary>
        /// <param name="channelId"></param>
        /// <param name="productId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public ActionResult DeleteSegmentItem(int channelId, int productId, [DataSourceRequest] DataSourceRequest request)
        {
            // Test if campaignItem object and modelstate is valid.
            if (ModelState.IsValid)
            {
                var channelItemSet = ServiceManagerProvider.GetChannelItemManager().GetChannelItems();
                var channelItemToDelete = channelItemSet.FirstOrDefault(c => c.ChannelId == channelId && c.ProductId == productId);

                if (channelItemToDelete != null)
                {
                    ServiceManagerProvider.GetChannelItemManager().DeleteChannelItem(channelItemToDelete);
                }
            }

            var json = new
            {
                success = true,
            };

            return Json(json);
        }

        protected string ClearDomain(string sItem)
        {
            var sLoc = (sItem.IndexOf("\\", StringComparison.Ordinal) + 1);
            var sOutPut = sItem.Substring(sLoc);

            return sOutPut;
        }

        /// <summary>
        /// Using the popup window, set and update the campaign offer code
        /// </summary>
        /// <param name="channelId"></param>
        /// <param name="redemptionCodeId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public ActionResult SetSegmentOffer(int channelId, int redemptionCodeId, [DataSourceRequest] DataSourceRequest request)
        {
            var channel = _channels.FirstOrDefault(c => c.ChannelId == channelId);
            if (channel != null)
            {
                channel.RedemptionCodeId = redemptionCodeId;

                ServiceManagerProvider.GetChannelManager().UpdateChannel(channel);
            }

            var json = new
            {
                success = true,
            };

            return Json(json);
        }

        /// <summary>
        ///  Action method to create stores from channel
        /// </summary>
        /// <param name="campaign"></param>
        /// <returns></returns>
        private static void CreateSegmentStore( int channelId, int campaignId)
        {
            var date = DateTime.Now;
            var channel = ServiceManagerProvider.GetChannelManager().GetChannel(channelId);
            var campaignStoreList = ServiceManagerProvider.GetCampaignStoreManager().GetCampaignStoreByIdandSelectedStores(campaignId);

            foreach (var item in campaignStoreList)
            {
                var channelStore = new ChannelStore
                {
                    ChannelId = channel.ChannelId,
                    CampaignId = item.CampaignId,
                    StoreId = item.StoreId,
                    DateAdded = date,
                    IsSelected = true
                };
                if (channel.StoreOptionId == 2)
                {
                    channelStore.IsSelected = false;
                }
                ServiceManagerProvider.GetChannelStoreManager().AddChannelStore(channelStore);
            }

        }

        /// <summary>
        ///  Action method to update stores from segment if segment store option change
        /// </summary>
        /// <param name="channelId"></param>
        /// <returns></returns>
        private static void UpdateSegmentStore(Channel channel)
        {
            try
            {
                var segmentStoreSet = ServiceManagerProvider.GetChannelStoreManager().GetChannelStores();
                var segmentStore = segmentStoreSet.Where(e => e.ChannelId == channel.ChannelId);
                foreach (var item in segmentStore)
                {
                    item.IsSelected = false || channel.StoreOptionId == 1;
                    ServiceManagerProvider.GetChannelStoreManager().UpdateChannelStore(item);
                }
            }
            catch (Exception exception)
            {
                Logger.Error(exception, $"MECCA CMT |channel ID: {channel.ChannelId} | Updating Segment Store ERROR: {exception.Message}");
                throw;
            }
        }

        private static void RemoveSegmentStore(int channelId)
        {
            var existedChannelStores = ServiceManagerProvider.GetChannelStoreManager() .GetChannelStoreById(channelId);
            ServiceManagerProvider.GetChannelStoreManager().DeleteChannelStore(existedChannelStores);
        }

        /// <summary>
        ///  Action method to set stores from campaign
        /// </summary>
        /// <param name="campaignId"></param>
        /// <param name="storeId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public ActionResult ActivateChannelStore(int channelId, int storeId, [DataSourceRequest] DataSourceRequest request)
        {
            if (ModelState.IsValid)
            {
                var channelStoreSet = ServiceManagerProvider.GetChannelStoreManager().GetChannelStores();
                var channelStoreToUpdate = channelStoreSet.FirstOrDefault(c => c.ChannelId == channelId && c.StoreId == storeId);
                if (channelStoreToUpdate != null)
                {
                    channelStoreToUpdate.IsSelected = true;
                    ServiceManagerProvider.GetChannelStoreManager().UpdateChannelStore(channelStoreToUpdate);
                }
            }
            var json = new
            {
                success = true,
            };

            return Json(json);
        }


        /// <summary>
        /// Action method to delete stores from segment
        /// </summary>
        /// <param name="channelId"></param>
        /// <param name="storeId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public ActionResult DeleteSegmentStore(int channelId, int storeId, [DataSourceRequest] DataSourceRequest request)
        {
            if (ModelState.IsValid)
            {
                var channelStoreSet = ServiceManagerProvider.GetChannelStoreManager().GetChannelStores();
                var channelStoreToDelete = channelStoreSet.FirstOrDefault(c => c.ChannelId == channelId && c.StoreId == storeId);
                if (channelStoreToDelete != null)
                {
                    channelStoreToDelete.IsSelected = false;
                    ServiceManagerProvider.GetChannelStoreManager().UpdateChannelStore(channelStoreToDelete);
                }
            }
            var json = new
            {
                success = true,
            };

            return Json(json);
        }

        public JsonResult InitOffer_Check(int channelId, [DataSourceRequest] DataSourceRequest request)
        {
            var resultMessage = "";
            var offerErrorMsg = "";
            var customerErrorMsg = "";
            var activeErrorMsg = "";

            try
            {
                // Code to check customers in segment by calling a stored procedure
                var conn = ConfigurationManager.GetConfigValueFromSection("connectionStrings", "ConnectionStringSQLServer");
                int initCustomerCheck;
                var initOfferCheck = 0;
                var initIsAlreadyActive = 0;

                // Use Stored Procedure to read total customers in given segment
                using (var connection = new SqlConnection(conn))
                using (var command = new SqlCommand("GetSegmentCustomers", connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                })
                {
                    command.Parameters.Add("@channelId", SqlDbType.Int).Value = channelId;

                    var countCustomers = command.Parameters.Add("@totalCustomers", SqlDbType.Int);
                    countCustomers.Direction = ParameterDirection.Output;

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    initCustomerCheck = (int)command.Parameters["@totalCustomers"].Value;

                    if (initCustomerCheck == 0)
                    {
                        customerErrorMsg = "Customer check failed: there are NO customers in segment.\n";
                    }
                }

                // Check if a offer code has been set using channel id
                var mySegment = _channels.FirstOrDefault(e => e.ChannelId == channelId);
                if (mySegment != null)
                {
                    initOfferCheck = mySegment.RedemptionCodeId;

                    if (initOfferCheck == 219)
                    {
                        offerErrorMsg = "Offer check failed: NO offer has been set.\n";
                    }

                    // TODO: add flag is_offer_active to channel
                    //initIsAlreadyActive = mySegment.OfferActive;
                    if (initIsAlreadyActive != 0)
                    {
                        activeErrorMsg = "Active check failed: Offer is already active.\n";
                    }
                }

                // Activate the offer if all checks are passed
                if (initCustomerCheck != 0 && initOfferCheck != 219 && initIsAlreadyActive == 0)
                {
                    // TODO perform offer initiation; 


                    resultMessage = "Offer has been activated for POS.";
                }
                else
                {
                    // Compile messages to be returned
                    resultMessage = customerErrorMsg + offerErrorMsg + activeErrorMsg;
                }
            }
            catch (Exception exception)
            {
                Logger.Error(exception, $"MECCA CMT | ERROR: {exception.Message}");
                throw;
            }

            //return Json(resultMessage);

            return Json(new { result = resultMessage }, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// Export campaign items to CSV, allow users to save file
        /// </summary>
        /// <param name="request"></param>
        /// <param name="channelId"></param>
        /// <returns></returns>
        public FileResult Export([DataSourceRequest]DataSourceRequest request, int channelId)
        {
            var channelItems = GetChannelItemModels(channelId).Result.Where(item => item.ChannelId == channelId).ToList();

            var output = new MemoryStream();
            var writer = new StreamWriter(output, Encoding.UTF8);

            writer.Write("ItemCode,");
            writer.Write("Description,");
            writer.Write("Vendor,");
            writer.Write("LimitedEd,");
            writer.Write("Lifestage,");
            writer.Write("AUD,");
            writer.Write("NZD,");
            writer.Write("LaunchDate,");
            writer.Write("RangeMecca,");
            writer.Write("RangeMaxima,");
            writer.Write("RangeImo,");
            writer.Write("RangeKit,");
            writer.Write("CompanySoh,");
            writer.Write("TransitionItemCode,");
            writer.Write("TesterMerchQty,");
            writer.Write("LiveMerchQty,");
            writer.Write("SampleQty");
            writer.Write("Comments");
            writer.WriteLine();

            foreach (var item in channelItems)
            {
                var product = GetProductItemModels().FirstOrDefault(o => o.ProductId == item.ProductId);

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
                    writer.Write("{0:dd/MM/yyyy}", product.LaunchDate);
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
                    writer.Write(product.TransitionItemCode);
                    writer.Write(",");
                    writer.Write(item.TesterMerchQty);
                    writer.Write(",");
                    writer.Write(item.LiveMerchQty);
                    writer.Write(",");
                    writer.Write(item.SampleQty);
                    writer.Write(",");
                    writer.Write("\"");
                    writer.Write(item.Comments);
                    writer.Write("\"");

                    writer.WriteLine();
                }
            }
            writer.Flush();
            output.Position = 0;

            var saveNow = DateTime.Now;
            var formatDate = saveNow.ToString("yyyyMMdd");
            var filename = "S" + channelId + "_ChannelItems_" + formatDate + ".csv";

            return File(output, "text/comma-separated-values", filename);
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
        /// Return distinct vendors to dropdownlist for filtering
        /// </summary>
        /// <returns></returns>
        public ActionResult FilterMenuCustomization_Vendor()
        {
            return Json(GetProductItemModels().Select(e => e.VendorCode).Distinct(), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// Return distinct department names for filtering
        /// </summary>
        /// <returns></returns>
        public ActionResult FilterMenuCustomization_Department()
        {
            return Json(GetProductItemModels().Select(e => e.DepartmentName).Distinct(), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// Return distinct category names for filtering
        /// </summary>
        /// <returns></returns>
        public ActionResult FilterMenuCustomization_Category()
        {
            return Json(GetProductItemModels().Select(e => e.CategoryName).Distinct(), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// Return distinct lifestages to dropdownlist for filtering
        /// </summary>
        /// <returns></returns>
        public ActionResult FilterMenuCustomization_Lifestage()
        {
            return Json(GetProductItemModels().Select(e => e.Lifestage).Distinct(), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// Return distinct offer codes to autocomplete for filtering
        /// </summary>
        /// <returns></returns>
        public ActionResult FilterMenuCustomization_OfferCode()
        {
            return Json(GetRedemptionCodesModels().Select(e => e.OfferCode).Distinct(), JsonRequestBehavior.AllowGet);
        }
        #endregion

        /// <summary>
        /// Upload campaign items from CSV file
        /// </summary>
        /// <param name="channelId"></param>
        /// <returns></returns>

        #region Segment Items Uploading
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult UploadSegmentItems(IEnumerable<HttpPostedFileBase> uploadFiles, int channelId)
        {

            var itemsNotAddedList = new List<UploadItemSegementErrorModel>();

            if (uploadFiles == null)
            {
                TempData["UploadResult"] = "Segment S" + channelId + ": " + "No file was selected";
                return RedirectToAction("ChannelItems");
            }
            try
            {
                //Loop through multiple uploaded files
                foreach (var upload in uploadFiles)
                {
                    if (upload.ContentLength > 0)
                    {
                        var fileName = Path.GetFileName(upload.FileName);
                        var path = AppDomain.CurrentDomain.BaseDirectory + ConfigurationManager.GetValue("UploadFolderName") + fileName;
                        upload.SaveAs(path);
                        var csv = new StreamReader(path);
                        var errorMessage = "";
                        var resultMessage = "";
                        var counter = 0;
                        var error = 0;
                        try
                        {
                            var itemCode = string.Empty;
                            while ((itemCode = csv.ReadLine()) != null)
                            {
                                //Check item exist in campain
                                var productItemSet = ServiceManagerProvider.GetProductItemManager().GetProductItem(itemCode);
                                var uploadItems = new UploadItemSegementErrorModel();
                                uploadItems.ChannelId = channelId;
                                uploadItems.ItemCode = itemCode;

                                //Check Item exist 
                                if (productItemSet != null)
                                {
                                    var campaignChannelSet =
                                        ServiceManagerProvider.GetChannelManager().GetChannel(channelId);
                                    /*To do Check product  has been existed in this campaign */
                                    var campaignItemSet = ServiceManagerProvider.GetCampaignItemManager().GetCampaignItems();
                                    var campaignItemToAdd = campaignItemSet.FirstOrDefault( c =>c.CampaignId == campaignChannelSet.CampaignId && c.ProductId == productItemSet.ProductId);
                                    if (campaignItemToAdd == null)
                                    {
                                        error++;
                                        errorMessage = "Segment S" + channelId + ": Item does not exist in the Campaign C" + campaignChannelSet.CampaignId+". Please add this item to the Campaign C"+ campaignChannelSet.CampaignId;
                                        uploadItems.ErrorMessage = errorMessage;
                                        itemsNotAddedList.Add(uploadItems);
                                    }
                                    else
                                    {
                                        /*To do Check product  has been existed in this Channel */
                                        var channelProductSet = ServiceManagerProvider.GetChannelItemManager().GetChannelProcduct(productItemSet.ProductId, channelId);

                                        var item = new ChannelItem
                                        {
                                            ChannelId = channelId,
                                            ProductId = productItemSet.ProductId
                                        };


                                        if (channelProductSet == null)
                                        {
                                            ServiceManagerProvider.GetChannelItemManager().AddChannelItem(item);
                                            counter++;
                                            resultMessage = "Segment S" + channelId + ": " + counter + " items updated";
                                        }
                                        else
                                        {
                                            error++;
                                            errorMessage = "Segment S" + channelId +": Item already exists in this segment";
                                            uploadItems.ErrorMessage = errorMessage;
                                            itemsNotAddedList.Add(uploadItems);
                                        }
                                    }
                                }
                                else
                                {
                                    error++;
                                    errorMessage = "Segment S" + channelId +": Item has invalid code";
                                    uploadItems.ErrorMessage = errorMessage;
                                    itemsNotAddedList.Add(uploadItems);
                                }
                            }

                            //Display Message
                            TempData["UploadResult"] = resultMessage;
                            TempData["WarningResult"] = null;
                            if (errorMessage != "")
                            {
                                TempData["WarningResult"] = "Segment S" + channelId + " : Cannot upload " + error + " items";
                            }

                            // LOOP through and generate the log file
                            var createLog = GenerateErrorLogFile(itemsNotAddedList, channelId);
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
            catch (Exception exception)
            {
                Logger.Error(exception, $"MECCA CMT | ERROR: {exception.Message}");
                throw;
            }


            return RedirectToAction("ChannelItems");
        }

        #endregion

        public bool GenerateErrorLogFile(List<UploadItemSegementErrorModel> logs, int channelId)
        {
            var saveNow = DateTime.Now;
            var formatDate = saveNow.ToString("yyyyMMdd");
            var filename = "S" + channelId + "_" + formatDate + ".csv";
            var output = AppDomain.CurrentDomain.BaseDirectory + ConfigurationManager.GetValue("LogFolderName") + filename;
            var writer = new StreamWriter(output, true);
            writer.Write("Segment Id");
            writer.Write(",");
            writer.Write("Item Code");
            writer.Write(","); ;
            writer.Write("Messages");
            writer.WriteLine();
            foreach (var log in logs)
            {
                Console.WriteLine(logs);
                // Create file and log
                if (log != null)
                {
                    writer.Write(log.ChannelId);
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

            TempData["DownloadFile"] = output;
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult Download()
        {
            var filename = _fileDownload;
            var root = AppDomain.CurrentDomain.BaseDirectory + ConfigurationManager.GetValue("LogFolderName");
            var path = Path.Combine(root, filename);
            return File(path, "text/csv", filename);
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

            var query = ConfigurationManager.GetConfigValueFromSection("pricingIntegration", "GetItemPriceBySiteIdItemCodeAndDates") + siteId + "/" + itemCode + "/startDate=" + startTimeAttr + "/endDate=" + endTimeAttr;
            var response = await client.GetAsync(query).ConfigureAwait(false);
            var contentString = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode) return itemList;
            var prices = JsonConvert.DeserializeObject<IEnumerable<ProductItemModel>>(contentString);
            itemList.AddRange(prices);

            client.Dispose();

            return itemList;
        }

        private static async Task<ProductItemModel> GetLatestItemPrice(string itemCode, int siteId)
        {

            var client = new HttpClient();
            var query = ConfigurationManager.GetConfigValueFromSection("pricingIntegration", "GetItemPriceBySiteIdItemCodeAndDates") + siteId + "/"+ itemCode;

            var response = await client.GetAsync(query).ConfigureAwait(false);
            var contentString = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode) return null;
            var prices = JsonConvert.DeserializeObject<ProductItemModel>(contentString);

            client.Dispose();

            return prices;
        }

    }
}
