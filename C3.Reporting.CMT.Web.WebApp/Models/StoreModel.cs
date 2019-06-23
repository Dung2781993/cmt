using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace C3.Reporting.CMT.Web.WebApp.Models
{
    public class StoreModel
    {
        public int StoreId { get; set; }

        public string StoreCode { get; set; }

        public string StoreName { get; set; }

        public string BusinessName { get; set; }

        public DateTime? OpenDate { get; set; }

        [Editable(true)]
        [DisplayName("Campaign Store")]
        public bool IsSelected { get; set; }
    }
}