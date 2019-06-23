using System;
using Mecca.CMT.DAL.EntityClasses;

namespace C3.Reporting.CMT.Business.Entities
{
    [Serializable]
    public class ChannelType : BaseDataEntity<ChannelType, ChannelTypeEntity>
    {
        public ChannelType(){ }
        public ChannelType(int channelTypeId) { _entity = new ChannelTypeEntity(channelTypeId); }
        public ChannelType(ChannelTypeEntity entity) : base(entity) { }


        public ChannelTypeEntity Entity
        {
            get { return _entity; }
        }

        public int ChannelTypeId
        {
            get { return _entity.ChannelTypeId; }
            set { _entity.ChannelTypeId = value; }
        }

        public string ChannelTypeName
        {
            get { return _entity.ChannelTypeName; }
            set { _entity.ChannelTypeName = value; }
        }
    }
}
