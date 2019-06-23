using System;
using System.Linq;
using C3.Reporting.CMT.Business.Entities;
using C3.Reporting.CMT.Core.Caching;
using Mecca.CMT.DAL.CollectionClasses;
using Mecca.CMT.DAL.EntityClasses;
using Mecca.CMT.DAL.Linq;
using SD.LLBLGen.Pro.LinqSupportClasses;

namespace C3.Reporting.CMT.Business.Services.Managers
{
    public class ProductItemManager
    {
        /// <summary>
        ///     Get the collection of all product items. The cache is enabled by default.
        /// </summary>
        /// <returns></returns>
        public ProductItemSet GetProductItems()
        {
            return GetProductItems(false);
        }

        /// <summary>
        ///     Get the collection of all product items.
        /// </summary>
        /// <param name="noCache">Bypass the cache</param>
        /// <returns>A set of product items</returns>
        public ProductItemSet GetProductItems(bool noCache)
        {
            return GetProductItems(noCache, false);
        }

        /// <summary>
        ///     Get the collection of all product items.
        /// </summary>
        /// <param name="noCache">Bypass the cache</param>
        /// <param name="refreshCache">Force refresh the cache</param>
        /// <returns>A set of product items</returns>
        public ProductItemSet GetProductItems(bool noCache, bool refreshCache)
        {
            // If no cache the load and return a entity set from the database
            if (noCache && !refreshCache)
            {
                return LoadProductItemSet();
            }

            ProductItemSet productItemSet;

            string cacheKey = ProductItemSet.StaticGetCacheKey();

            if (!CacheManagerProvider.GetCacheManagerInstance().Contains<ProductItemSet>(cacheKey) || refreshCache)
            {
                // Load the entity set from the database
                productItemSet = LoadProductItemSet();

                if (productItemSet != null)
                {
                    // Add the entity set to the cache by reading caching parameters from the configuration
                    CacheManagerProvider.GetCacheManagerInstance().Insert(cacheKey, productItemSet,
                                                                     ConfigurationManager.GetCacheExpirationByType(
                                                                         productItemSet.GetType()));
                }
            }
            else
            {
                productItemSet = CacheManagerProvider.GetCacheManagerInstance().Get<ProductItemSet>(cacheKey);
            }

            return productItemSet;
        }




        /// <summary>
        ///     Load all product items from the database.
        /// </summary>
        /// <returns></returns>
        private ProductItemSet LoadProductItemSet()
        {
            var productItemSet = new ProductItemSet();

            // Get the collection from the ORM data layer
            var metaData = new LinqMetaData();
            var productItems = from c in metaData.Product select c;

            // add values to the page or display whatever..
            var productItemCollection = ((ILLBLGenProQuery)productItems).Execute<ProductCollection>();
            // Fill the entity set from the data collection
            if (productItemCollection.Count > 0)
            {
                foreach (var productEntity in productItemCollection)
                {
                    var product = new ProductItem(productEntity);

                    productItemSet.Add(product);
                }
            }
            // Return the entity set
            return productItemSet;
        }

        /// <summary>
        ///     Get the product item. The cache is not bypassed by default.
        /// </summary>
        public ProductItem GetProductItem(int productId)
        {
            return GetProductItem(productId, false);
        }

        /// <summary>
        ///     Get the product item. The cache is not bypassed by default.
        /// </summary>
        /// <param name="productId">The product identifier</param>
        /// <param name="noCache">No-Cache parameters</param>
        /// <returns></returns>
        public ProductItem GetProductItem(int productId, bool noCache)
        {
            return GetProductItem(productId, noCache, false);
        }

        /// <summary>
        ///     Get the product item. The cache is not bypassed by default.
        /// </summary>
        /// <param name="productId">The product identifier</param>
        /// <param name="noCache">Bypass the cache</param>
        /// <param name="refreshCache">Force refresh the cache</param>
        /// <returns>A product</returns>
        public ProductItem GetProductItem(int productId, bool noCache, bool refreshCache)
        {
            // If no cache the load and return a entity from the database
            if (noCache && !refreshCache)
            {
                return LoadCampaign(productId);
            }

            ProductItem product;

            string cacheKey = ProductItem.GetCacheKeyById(productId);

            if (!CacheManagerProvider.GetCacheManagerInstance().Contains<ProductItem>(cacheKey) || refreshCache)
            {
                // Load the entity from the database
                product = LoadCampaign(productId);

                if (product != null)
                {
                    // Add the entity to the cache by reading caching parameters from the configuration
                    CacheManagerProvider.GetCacheManagerInstance().Insert(cacheKey, product,
                                                                     ConfigurationManager.GetCacheExpirationByType(
                                                                         product.GetType()));
                }
            }
            else
            {
                product = CacheManagerProvider.GetCacheManagerInstance().Get<ProductItem>(cacheKey);
            }

            return product;
        }

        /// <summary>
        ///     Load a product item from the database given its Id.
        /// </summary>
        /// <returns></returns>
        private ProductItem LoadCampaign(int productId)
        {
            var productItem = new ProductItem(new ProductEntity(productId));

            return productItem;
        }

        /// <summary>
        ///     Get the product item. The cache is not bypassed by default.
        /// </summary>
        public ProductItem GetProductItem(string itemCode)
        {
            return GetProductItem(itemCode, false);
        }

        /// <summary>
        ///     Get the product item. The cache is not bypassed by default.
        /// </summary>
        /// <param name="itemCode">The product identifier</param>
        /// <param name="noCache">No-Cache parameters</param>
        /// <returns></returns>
        public ProductItem GetProductItem(string itemCode, bool noCache)
        {
            return GetProductItem(itemCode, noCache, false);
        }

        /// <summary>
        ///     Get the product item. The cache is not bypassed by default.
        /// </summary>
        /// <param name="productId">The product identifier</param>
        /// <param name="noCache">Bypass the cache</param>
        /// <param name="refreshCache">Force refresh the cache</param>
        /// <returns>A product</returns>
        public ProductItem GetProductItem(string itemCode, bool noCache, bool refreshCache)
        {
            // If no cache the load and return a entity from the database
            if (noCache && !refreshCache)
            {
                return GetProductByItemCode(itemCode);
            }

            ProductItem product;

            string cacheKey = ProductItem.GetCustomCacheKey(itemCode);

            if (!CacheManagerProvider.GetCacheManagerInstance().Contains<ProductItem>(cacheKey) || refreshCache)
            {
                // Load the entity from the database
                product = GetProductByItemCode(itemCode);

                if (product != null)
                {
                    // Add the entity to the cache by reading caching parameters from the configuration
                    CacheManagerProvider.GetCacheManagerInstance().Insert(cacheKey, product,
                                                                     ConfigurationManager.GetCacheExpirationByType(
                                                                         product.GetType()));
                }
            }
            else
            {
                product = CacheManagerProvider.GetCacheManagerInstance().Get<ProductItem>(cacheKey);
            }

            return product;
        }

        private ProductItem GetProductByItemCode(string itemCode)
        {
            var metaData = new LinqMetaData();
            var product = metaData.Product.SingleOrDefault(e => e.ItemCode == itemCode);
            
            if (product == null) return null;
            var productItem = new ProductItem();    

            //Mapping fields
            productItem.ItemCode = product.ItemCode;
            productItem.ProductId = product.ProductId;
            productItem.Description = product.Description;
            productItem.VendorCode = product.VendorCode;
            productItem.DepartmentName = product.DepartmentName;
            productItem.CategoryName = product.CategoryName;
            productItem.Lifestage = product.Lifestage;
            productItem.LimitedEdition = product.LimitedEdition;
            productItem.UnitPrice = product.UnitPrice;
            productItem.NzUnitPrice = product.NzUnitPrice;
            productItem.LaunchDate = product.LaunchDate;
            productItem.TerminationDate = product.TerminationDate;
            productItem.RangingCodeMecca = product.RangingCodeMecca;
            productItem.RangingCodeKit = product.RangingCodeKit;
            productItem.RangingCodeMaxima = product.RangingCodeMaxima;
            productItem.RangingCodeImo = product.RangingCodeImo;
            productItem.CompanySoh = product.CompanySoh;
            productItem.TransitionItemCode = product.TransitionItemCode;
            return productItem;
        }

        /// <summary>
        /// Create a new product item object and persist it into the database.
        /// </summary>
        /// <param name="productItem">The campaign item object</param>
        public ProductItem AddProductItem(ProductItem productItem)
        {
            // Persist the object into the database
            productItem.Save();

            // Return the new object with the new identifier (AUTO)
            return productItem;
        }

        /// <summary>
        /// Update a product item object and persist changes into the database
        /// </summary>
        /// <param name="productItem"></param>
        public void UpdateProductItem(ProductItem productItem)
        {
            // Persist the object into the database
            productItem.Save();
        }

        /// <summary>
        /// Delete a product object and persist changes into the database
        /// </summary>
        /// <param name="productItem"></param>
        public void DeleteProductItem(ProductItem productItem)
        {
            // Remove the object into the database
            productItem.Delete();
        }











    }
}
