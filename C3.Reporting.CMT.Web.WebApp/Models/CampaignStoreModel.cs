using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace C3.Reporting.CMT.Web.WebApp.Models
{
    public class CampaignStoreModel
    {
        public int CampaignStoreId { get; set; }
        public int CampaignId { get; set; }
        public int StoreId { get; set; }

        public string StoreCode { get; set; }

        public string StoreName { get; set; }
        public string BusinessName { get; set; }
        public DateTime? DateAdded { get; set; }

        public DateTime? OpenDate { get; set; }

        [Editable(true)]
        [DisplayName("Campaign Store")]
        public bool IsSelected { get; set; }
    }
}