using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mecca.CMT.DAL.EntityClasses;

namespace C3.Reporting.CMT.Business.Entities
{
    public class Store : BaseDataEntity<Store, StoreEntity>
    {
        public Store() { }
        public Store(int storeId) { _entity = new StoreEntity(storeId);}
        public Store(StoreEntity entity): base(entity) { }

        public int StoreId
        {
            get { return _entity.StoreId; }
            set { _entity.StoreId = value; }
        }

        public string StoreCode
        {
            get { return _entity.StoreCode; }
            set { _entity.StoreCode = value; }
        }

        public string StoreName
        {
            get { return _entity.StoreName; }
            set { _entity.StoreName = value; }
        }

        public string BusinessName
        {
            get { return _entity.BusinessName; }
            set { _entity.BusinessName = value; }
        }

        public DateTime? OpenDate
        {
            get { return _entity.OpenDate; }
            set { _entity.OpenDate = value; }
        }
    }
}
