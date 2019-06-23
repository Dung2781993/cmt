using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mecca.CMT.DAL.EntityClasses;

namespace C3.Reporting.CMT.Business.Entities
{
    [Serializable]
    public class CampaignStore : BaseDataEntity<CampaignStore, CampaignStoreEntity>
    {
        public CampaignStore() { }
        public CampaignStore(int campaignStoreId) { _entity = new CampaignStoreEntity(campaignStoreId);}
        public CampaignStore(CampaignStoreEntity entity) : base(entity) { }

        public int CampaignStoreId
        {
            get { return _entity.CampaignStoreId; }
            set { _entity.CampaignStoreId = value; }
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
