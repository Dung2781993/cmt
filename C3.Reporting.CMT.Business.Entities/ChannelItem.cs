using Mecca.CMT.DAL.EntityClasses;

namespace C3.Reporting.CMT.Business.Entities
{
    public class ChannelItem : BaseDataEntity<CampaignItem, ChannelItemEntity>
    {
        public ChannelItem(){ }
        public ChannelItem(int channelItemId) { _entity = new ChannelItemEntity(channelItemId); }
        public ChannelItem(ChannelItemEntity entity) : base(entity) { }       
        
        public int ChannelItemId
        {
            get { return _entity.ChannelItemId; }
            set
            {
                _entity.ChannelItemId = value;
            }
        }

        public int ChannelId
        {
            get { return _entity.ChannelId; }
            set
            {
                _entity.ChannelId = value;
            }
        }

        public int ProductId
        {
            get { return _entity.ProductId; }
            set
            {
                _entity.ProductId = value;
            }
        }

        public int? TesterMerchQty
        {
            get { return _entity.TesterMerchQty; }
            set
            {
                _entity.TesterMerchQty = value;
            }
        }

        public int? LiveMerchQty
        {
            get { return _entity.LiveMerchQty; }
            set
            {
                _entity.LiveMerchQty = value;
            }
        }

        public int? NumStores
        {
            get { return _entity.NumStores; }
            set
            {
                _entity.NumStores = value;
            }
        }

        public string Comments
        {
            get { return _entity.Comments; }
            set
            {
                _entity.Comments = value;
            }
        }

        
        public int? SampleQty
        {
            get { return _entity.SampleQty; }
            set
            {
                _entity.SampleQty = value;
            }
        }
        

    }
}
