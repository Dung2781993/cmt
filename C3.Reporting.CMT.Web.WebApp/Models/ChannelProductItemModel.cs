using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace C3.Reporting.CMT.Web.WebApp.Models
{
    public class ChannelProductItemModel
    {
        [Editable(false)]
        public int ChannelItemId { get; set; }

        [Editable(false)]
        public int ChannelId { get; set; }

        [Editable(false)]
        public int ProductId { get; set; }

        public int? TesterMerchQty { get; set; }

        public int? LiveMerchQty { get; set; }

        public int? NumStores { get; set; }

        public string Comments { get; set; }

        public int? SampleQty { get; set; }


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
        [Editable(false)]
        public DateTime? LaunchDate { get; set; }

        [DisplayName("Mecca")]
        [Editable(false)]
        public string RangingCodeMecca { get; set; }

        [DisplayName("Kit")]
        [Editable(false)]
        public string RangingCodeKit { get; set; }

        [DisplayName("Maxima")]
        [Editable(false)]
        public string RangingCodeMaxima { get; set; }

        [DisplayName("Imo")]
        [Editable(false)]
        public string RangingCodeImo { get; set; }

        [Editable(false)]
        [StringLength(500)]
        [DataType(DataType.MultilineText)]
        public int? CompanySoh { get; set; }

        [Editable(false)]
        public string TransitionItemCode { get; set; }

        public string CurrencyCode { get; set; }

    }
}