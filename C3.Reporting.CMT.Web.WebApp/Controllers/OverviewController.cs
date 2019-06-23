using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using C3.Reporting.CMT.Business.Entities;
using C3.Reporting.CMT.Business.Services;
using C3.Reporting.CMT.Web.WebApp.Models;

namespace C3.Reporting.CMT.Web.WebApp.Controllers
{
    public class OverviewController : Controller
    {

        private static CampaignSet _campaigns;

        public ActionResult CampaignOverview()
        {
            return View();
        }

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
                CreatedBy = campaign.CreatedBy
            }).ToList();
        }



    }
}
