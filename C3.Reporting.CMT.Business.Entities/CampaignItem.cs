using System;
using Mecca.CMT.DAL.EntityClasses;

namespace C3.Reporting.CMT.Business.Entities
{
    [Serializable]
    public class CampaignItem : BaseDataEntity<CampaignItem, CampaignItemEntity>
    {
        public CampaignItem(){ }
        public CampaignItem(int campaignItemId) { _entity = new CampaignItemEntity(campaignItemId); }
        public CampaignItem(CampaignItemEntity entity) : base(entity) { }       
        
        public int CampaignItemId
        {
            get { return _entity.CampaignItemId; }
            set
            {
                _entity.CampaignItemId = value;
            }
        }

        public int CampaignId
        {
            get { return _entity.CampaignId; }
            set { _entity.CampaignId = value;
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

        public DateTime? DateAdded
        {
            get { return _entity.DateAdded; }
            set
            {
                _entity.DateAdded = value;
            }
        }

        public DateTime? StartDate
        {
            get { return _entity.StartDate; }
            set
            {
                _entity.StartDate = value;
            }
        }


        public DateTime? EndDate
        {
            get { return _entity.EndDate; }
            set
            {
                _entity.EndDate = value;
            }
        }

    }
}
