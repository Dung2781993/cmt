using System;
using Mecca.CMT.DAL.EntityClasses;

namespace C3.Reporting.CMT.Business.Entities
{
    [Serializable]
    public class ProductItem : BaseDataEntity<ProductItem, ProductEntity>
    {
        public ProductItem(){ }
        public ProductItem(int productId) { _entity = new ProductEntity(productId); }
        public ProductItem(ProductEntity entity) : base(entity) { }

        public int ProductId
        {
            get { return _entity.ProductId; }
            set
            {
                _entity.ProductId = value;
            }
        }

        public string ItemCode
        {
            get { return _entity.ItemCode; }
            set
            {
                _entity.ItemCode = value;
            }
        }

        public string Description
        {
            get { return _entity.Description; }
            set
            {
                _entity.Description = value;
            }
        }

        public string VendorCode
        {
            get { return _entity.VendorCode; }
            set
            {
                _entity.VendorCode = value;
            }
        }

        public string DepartmentName
        {
            get { return _entity.DepartmentName; }
            set
            {
                _entity.DepartmentName = value;
            }
        }

        public string CategoryName
        {
            get { return _entity.CategoryName; }
            set
            {
                _entity.CategoryName = value;
            }
        }

        public string Lifestage
        {
            get { return _entity.Lifestage; }
            set
            {
                _entity.Lifestage = value;
            }
        }

        public string LimitedEdition
        {
            get { return _entity.LimitedEdition; }
            set
            {
                _entity.LimitedEdition = value;
            }
        }

        public decimal? UnitPrice
        {
            get { return _entity.UnitPrice; }
            set
            {
                _entity.UnitPrice = value;
            }
        }

        public decimal? NzUnitPrice
        {
            get { return _entity.NzUnitPrice; }
            set
            {
                _entity.NzUnitPrice = value;
            }
        }

        public DateTime? LaunchDate
        {
            get { return _entity.LaunchDate; }
            set
            {
                _entity.LaunchDate = value;
            }
        }


        public String TerminationDate
        {
            get { return _entity.TerminationDate; }
            set
            {
                _entity.TerminationDate = value;
            }
        }

        public string RangingCodeMecca
        {
            get { return _entity.RangingCodeMecca; }
            set
            {
                _entity.RangingCodeMecca = value;
            }
        }

        public string RangingCodeKit
        {
            get { return _entity.RangingCodeKit; }
            set
            {
                _entity.RangingCodeKit = value;
            }
        }

        public string RangingCodeMaxima
        {
            get { return _entity.RangingCodeMaxima; }
            set
            {
                _entity.RangingCodeMaxima = value;
            }
        }

        public string RangingCodeImo
        {
            get { return _entity.RangingCodeImo; }
            set
            {
                _entity.RangingCodeImo = value;
            }
        }

        public int? CompanySoh
        {
            get { return _entity.CompanySoh; }
            set
            {
                _entity.CompanySoh = value;
            }
        }

        public string TransitionItemCode
        {
            get { return _entity.TransitionItemCode; }
            set
            {
                _entity.TransitionItemCode = value;
            }
        }


        public int? StockOnOrder
        {
            get { return _entity.StockOnOrder; }
            set
            {
                _entity.StockOnOrder = value;
            }
        }

        public DateTime? ExpectedReceiptDate
        {
            get { return _entity.ExpectedReceiptDate; }
            set
            {
                _entity.ExpectedReceiptDate = value;
            }
        }

        public string TravelSize
        {
            get { return _entity.TravelSize; }
            set
            {
                _entity.TravelSize = value;
            }
        }


        public string NoTester
        {
            get { return _entity.NoTester; }
            set
            {
                _entity.NoTester = value;
            }
        }
    }
}
