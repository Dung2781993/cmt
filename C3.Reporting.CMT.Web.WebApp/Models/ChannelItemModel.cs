namespace C3.Reporting.CMT.Web.WebApp.Models
{
    public class ChannelItemModel
    {
        public int ChannelItemId { get; set; }

        public int ChannelId { get; set; }

        public int ProductId { get; set; }

        public int? TesterMerchQty { get; set; }

        public int? LiveMerchQty { get; set; }

        public int? NumStores { get; set; }

        public string Comments { get; set; }

        public int? SampleQty { get; set; }
    }
}