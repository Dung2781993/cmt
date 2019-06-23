using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace C3.Reporting.CMT.Web.WebApp.Models
{
    public class RedemptionCodeModel
    {
        public int RedemptionCodeId { get; set; }

        public string OfferCode { get; set; }
 
        public string Description { get; set; }
    }
}