using System;
using Mecca.CMT.DAL.EntityClasses;

namespace C3.Reporting.CMT.Business.Entities
{
    [Serializable]
    public class CampaignType : BaseDataEntity<CampaignType, CampaignTypeEntity>
    {
        public CampaignType(){ }
        public CampaignType(int campaignTypeId) { _entity = new CampaignTypeEntity(campaignTypeId); }
        public CampaignType(CampaignTypeEntity entity) : base(entity) { }           
     

        public CampaignTypeEntity Entity
        {
            get { return _entity; }
        }

        public int CampaignTypeId
        {
            get { return _entity.CampaignTypeId; }
            set { _entity.CampaignTypeId = value; }
        }

        public string CampaignTypeName
        {
            get { return _entity.CampaignTypeName; }
            set { _entity.CampaignTypeName = value; }
        }
    }
}