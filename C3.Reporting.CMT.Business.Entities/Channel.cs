using System;
using Mecca.CMT.DAL.EntityClasses;

namespace C3.Reporting.CMT.Business.Entities
{
    [Serializable]
    public class Channel : BaseDataEntity<Channel, ChannelEntity>
    {
        public Channel() { }
        public Channel(int channelId) { _entity = new ChannelEntity(channelId); }
        public Channel(ChannelEntity entity) : base(entity) { }

        public int CampaignId
        {
            get { return _entity.CampaignId; }
            set
            {
                _entity.CampaignId = value;
            }
        }

        public string ChannelCode
        {
            get { return _entity.ChannelCode; }
            set
            {
                _entity.ChannelCode = value;
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

        public string ChannelName
        {
            get { return _entity.ChannelName; }
            set
            {
                _entity.ChannelName = value;
            }
        }

        public string CreatedBy
        {
            get { return _entity.CreatedBy; }
            set
            {
                _entity.CreatedBy = value;
            }
        }

        public string Description
        {
            get { return _entity.Description; }
            set
            {
                _entity.Description = value;
            }
        }

        public DateTime EndDate
        {
            get { return _entity.EndDate; }
            set
            {
                _entity.EndDate = value;
            }
        }

        public bool IsLocked
        {
            get { return Convert.ToBoolean(_entity.IsLocked); }
            set
            {
                _entity.IsLocked = Convert.ToInt32(value);
            }
        }

        public DateTime StartDate
        {
            get { return _entity.StartDate; }
            set
            {
                _entity.StartDate = value;
            }
        }

        public int RedemptionCodeId
        {
            get { return _entity.RedemptionCodeId; }
            set { _entity.RedemptionCodeId = value; }
        }

        public int ChannelTypeId
        {
            get { return _entity.ChannelTypeId; }
            set
            {
                _entity.ChannelTypeId = value;
            }
        }
        public int StoreOptionId
        {
            get { return _entity.StoreOptionId; }
            set
            {
                _entity.StoreOptionId = value;
            }
        }
    }
}
