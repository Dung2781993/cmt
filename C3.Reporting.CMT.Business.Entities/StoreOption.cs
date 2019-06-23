using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mecca.CMT.DAL.EntityClasses;

namespace C3.Reporting.CMT.Business.Entities
{
    [Serializable]
    public class StoreOption : BaseDataEntity<StoreOption, StoreOptionEntity>
    {
        public StoreOption() { }
        public StoreOption(int storeOptionId) { _entity = new StoreOptionEntity(storeOptionId);}

        public StoreOption(StoreOptionEntity entity) : base(entity){}

        public StoreOptionEntity Entity
        {
            get { return _entity; }
        }

        public int StoreOptionId
        {
            get { return _entity.StoreOptionId; }
            set { _entity.StoreOptionId = value; }
        }

        public string StoreOptionName
        {
            get { return _entity.StoreOptionName;  }
            set { _entity.StoreOptionName = value; }
        }

    }
}
