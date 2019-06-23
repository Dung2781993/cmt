using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace C3.Reporting.CMT.Web.WebApp.Models
{
    public class CampaignOwnerModel
    {
        public int CampaignOwnerId { get; set; }
        
        public int CampaignId { get; set; }

        public string Owner { get; set; }
    }
}