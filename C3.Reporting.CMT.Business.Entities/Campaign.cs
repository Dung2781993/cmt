using System;
using Mecca.CMT.DAL.EntityClasses;

namespace C3.Reporting.CMT.Business.Entities
{
    [Serializable]
    public class Campaign : BaseDataEntity<Campaign, CampaignEntity>
    {
        public Campaign(){ }
        public Campaign(int campaignId) {_entity = new CampaignEntity(campaignId);}
        public Campaign(CampaignEntity entity) : base(entity) { }       
        
        public string CampaignCode
        {
            get { return _entity.CampaignCode; }
            set { _entity.CampaignCode = value;
            }
        }

        public int CampaignId
        {
            get { return _entity.CampaignId; }
            set { _entity.CampaignId = value;
            }
        }

        public string CampaignName
        {
            get { return _entity.CampaignName; }
            set { _entity.CampaignName = value;
            }
        }

        public string BusinessFormat
        {
            get { return _entity.BusinessFormat; }
            set
            {
                _entity.BusinessFormat = value;
            }
        }

        public string CreatedBy
        {
            get { return _entity.CreatedBy; }
            set { _entity.CreatedBy = value;
            }
        }

        public string Description
        {
            get { return _entity.Description; }
            set { _entity.Description = value;
            }
        }

        public DateTime EndDate
        {
            get { return _entity.EndDate; }
            set { _entity.EndDate = value;
            }
        }

        public bool IsLocked
        {
            get { return Convert.ToBoolean(_entity.IsLocked); }
            set { _entity.IsLocked = Convert.ToInt32(value);
            }
        }

        public DateTime StartDate
        {
            get { return _entity.StartDate; }
            set { _entity.StartDate = value;
            }
        }

        public int RedemptionCodeId
        {
            get { return _entity.RedemptionCodeId; }
            set { _entity.RedemptionCodeId = value; }
        }

        public int CampaignTypeId
        {
            get { return _entity.CampaignTypeId; }
            set { _entity.CampaignTypeId = value;
            }
        }

        public CampaignType CampaignType { get; set; }
        public RedemptionCode RedemptionCode { get; set; }

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