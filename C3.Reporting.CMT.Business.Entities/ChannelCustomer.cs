using System;
using Mecca.CMT.DAL.EntityClasses;

namespace C3.Reporting.CMT.Business.Entities
{
    [Serializable]
    public class ChannelCustomer : BaseDataEntity<ChannelCustomer, ChannelCustomerEntity>
    {
        public ChannelCustomer() { }
        public ChannelCustomer(int channelCustomerId) { _entity = new ChannelCustomerEntity(channelCustomerId); }
        public ChannelCustomer(ChannelCustomerEntity entity) : base(entity) { }

        public int ChannelCustomerId
        {
            get { return _entity.ChannelCustomerId; }
            set
            {
                _entity.ChannelCustomerId = value;
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

        public long CustomerSid
        {
            get { return _entity.CustomerSid; }
            set
            {
                _entity.CustomerSid = value;
            }
        }
    }
}
