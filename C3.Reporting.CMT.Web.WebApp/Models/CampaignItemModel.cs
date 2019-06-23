using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace C3.Reporting.CMT.Web.WebApp.Models
{
    public class CampaignItemModel
    {
        [Editable(false)]
        public int CampaignItemId { get; set; }

        [Editable(false)]
        public int CampaignId { get; set; }

        [Editable(false)]
        public int ProductId { get; set; }

        [Editable(false)]
        public DateTime? DateAdded { get; set; }

        [Editable(false)]
        public string ItemCode { get; set; }

        [Editable(false)]
        public string Description { get; set; }

        [Editable(false)]
        public string VendorCode { get; set; }

        [Editable(false)]
        public string DepartmentName { get; set; }

        [Editable(false)]
        public string CategoryName { get; set; }

        [Editable(false)]
        public string Lifestage { get; set; }

        [Editable(false)]
        public string LimitedEdition { get; set; }

        [Editable(false)]
        public decimal? UnitPrice { get; set; }

        [Editable(false)]
        public decimal? NzUnitPrice { get; set; }

        [UIHint("Date")]
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }

        [UIHint("Date")]
        [DataType(DataType.Date)]
        public DateTime? EndDate { get; set; }

        [Editable(false)]
        [UIHint("Date")]
        [DataType(DataType.Date)]
        public DateTime? LaunchDate { get; set; }

        [Editable(false)]
        [UIHint("Date")]
        [DataType(DataType.Date)]
        public string TerminationDate { get; set; }

        [Editable(false)]
        [DisplayName("Mecca")]
        public string RangingCodeMecca { get; set; }

        [Editable(false)]
        [DisplayName("Kit")]
        public string RangingCodeKit { get; set; }

        [Editable(false)]
        [DisplayName("Maxima")]
        public string RangingCodeMaxima { get; set; }

        [Editable(false)]
        [DisplayName("Imo")]
        public string RangingCodeImo { get; set; }

        [Editable(false)]
        public int? CompanySoh { get; set; }

        [Editable(false)]
        public string TransitionItemCode { get; set; }

        [Editable(false)]
        [UIHint("Date")]
        [DataType(DataType.Date)]
        public DateTime? ExpectedReceiptDate { get; set; }

        [Editable(false)]
        public int? StockOnOrder { get; set; }

        [Editable(false)]
        public string TravelSize { get; set; }

        [Editable(false)]
        public string NoTester { get; set; }
    }
}