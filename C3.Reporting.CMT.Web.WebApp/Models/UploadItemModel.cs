using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace C3.Reporting.CMT.Web.WebApp.Models
{
    public class UploadItemErrorModel
    {
        public int CampaignId { get; set; }
        public string ItemCode { get; set; }

        public string ErrorMessage { get; set; }

        //public string WarningMessage { get; set; }
    }
}