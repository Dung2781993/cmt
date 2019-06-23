using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mecca.CMT.DAL.EntityClasses;

namespace C3.Reporting.CMT.Business.Entities
{
    public class ChannelStore : BaseDataEntity<ChannelStore, ChannelStoreEntity>
    {
        public ChannelStore() { }
        public ChannelStore(int channelStoreId) { _entity = new ChannelStoreEntity(channelStoreId); }
        public ChannelStore(ChannelStoreEntity entity) : base(entity) { }

        public int ChannelStoreId
        {
            get { return _entity.ChannelStoreId; }
            set { _entity.ChannelStoreId = value; }
        }

        public int ChannelId
        {
            get { return _entity.ChannelId; }
            set { _entity.ChannelId = value; }
        }

        public int CampaignId
        {
            get { return _entity.CampaignId; }
            set { _entity.CampaignId = value; }
        }

        public int StoreId
        {
            get { return _entity.StoreId; }
            set { _entity.StoreId = value; }
        }

        public DateTime? DateAdded
        {
            get { return _entity.DateAdded; }
            set { _entity.DateAdded = value; }
        }

        public bool IsSelected
        {
            get { return Convert.ToBoolean(_entity.IsSelected); }
            set
            {
                _entity.IsSelected = Convert.ToInt32(value);
            }
        }

    }
}
