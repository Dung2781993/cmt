using System;
using Mecca.CMT.DAL.EntityClasses;

namespace C3.Reporting.CMT.Business.Entities
{
    [Serializable]
    public class ChannelOwner : BaseDataEntity<Channel, ChannelOwnerEntity>
    {
        public ChannelOwner(){ }
        public ChannelOwner(int channelOwnerId) { _entity = new ChannelOwnerEntity(channelOwnerId); }
        public ChannelOwner(ChannelOwnerEntity entity) : base(entity) { }       
        
        public int ChannelOwnerId
        {
            get { return _entity.ChannelOwnerId; }
            set
            {
                _entity.ChannelOwnerId = value;
            }
        }

        public int CampaignId
        {
            get { return _entity.CampaignId; }
            set
            {
                _entity.CampaignId = value;
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

        public string Owner
        {
            get { return _entity.Owner; }
            set { _entity.Owner = value;
            }
        }
    }
}
