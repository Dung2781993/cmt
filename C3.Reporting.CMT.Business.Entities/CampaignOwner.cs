using System;
using Mecca.CMT.DAL.EntityClasses;

namespace C3.Reporting.CMT.Business.Entities
{
    [Serializable]
    public class CampaignOwner : BaseDataEntity<Campaign, CampaignOwnerEntity>
    {
        public CampaignOwner(){ }
        public CampaignOwner(int campaignOwnerId) {_entity = new CampaignOwnerEntity(campaignOwnerId);}
        public CampaignOwner(CampaignOwnerEntity entity) : base(entity) { }       
        
        public int CampaignOwnerId
        {
            get { return _entity.CampaignOwnerId; }
            set
            {
                _entity.CampaignOwnerId = value;
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

        public string Owner
        {
            get { return _entity.Owner; }
            set { _entity.Owner = value;
            }
        }
    }
}
