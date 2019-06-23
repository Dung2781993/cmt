using System;
using Mecca.CMT.DAL.EntityClasses;

namespace C3.Reporting.CMT.Business.Entities
{   
    /// <summary>
    /// Redemption Code object
    /// </summary>
    [Serializable]
    public class RedemptionCode : BaseDataEntity<RedemptionCode, RedemptionCodeEntity>
    {
        public RedemptionCode(){ }
        public RedemptionCode(int redemptionCodeId) { _entity = new RedemptionCodeEntity(redemptionCodeId); }
        public RedemptionCode(RedemptionCodeEntity entity) : base(entity) { }           
     
        public int RedemptionCodeId
        {
            get { return _entity.RedemptionCodeId; }
            set { _entity.RedemptionCodeId = value; }
        }

        public string OfferCode
        {
            get { return _entity.OfferCode; }
            set { _entity.OfferCode = value; }
        }

        public string Description
        {
            get { return _entity.Description; }
            set { _entity.Description = value; }
        }
    }
}