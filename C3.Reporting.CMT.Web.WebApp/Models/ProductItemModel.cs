using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace C3.Reporting.CMT.Web.WebApp.Models
{
    public class ProductItemModel
    {
        [Required]
        public int ProductId { get; set; }

        public string ItemCode { get; set; }

        public string Description { get; set; }
       
        public string VendorCode { get; set; }

        public string DepartmentName { get; set; }

        public string CategoryName { get; set; }

        public string Lifestage { get; set; }
         
        public string LimitedEdition { get; set; }

        public decimal? Price { get; set; }

        public decimal? NzUnitPrice { get; set; }

        [UIHint("Date")]
        [DataType(DataType.Date)]
        public DateTime? LaunchDate { get; set; }

        [DisplayName("Mecca")]
        public string RangingCodeMecca { get; set; }

        [DisplayName("Kit")]
        public string RangingCodeKit { get; set; }

        [DisplayName("Maxima")]
        public string RangingCodeMaxima { get; set; }

        [DisplayName("Imo")]
        public string RangingCodeImo { get; set; }

        public int? CompanySoh { get; set; }

        public string TransitionItemCode { get; set; }

        [UIHint("Date")]
        [DataType(DataType.Date)]
        public string TerminationDate { get; set; }


        public int? StockOnOrder { get; set; }


        [UIHint("Date")]
        [DataType(DataType.Date)]
        public DateTime? ExpectedReceiptDate { get;  set; }


        public string TravelSize { get; set; }

        public string NoTester { get; set; }

        public string CurrencyCode { get; set; }

    }
}