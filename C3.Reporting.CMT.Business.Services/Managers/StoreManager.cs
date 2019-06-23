using System.Collections.Generic;
using System.Linq;
using C3.Reporting.CMT.Business.Entities;
using C3.Reporting.CMT.Core.Caching;
using Mecca.CMT.DAL.CollectionClasses;
using Mecca.CMT.DAL.EntityClasses;
using Mecca.CMT.DAL.Linq;
using SD.LLBLGen.Pro.LinqSupportClasses;

namespace C3.Reporting.CMT.Business.Services.Managers
{
    public class StoreManager
    {
        /// <summary>
        ///     Get the collection of all stores. The cache is enabled by default.
        /// </summary>
        /// <returns></returns>
        public StoreSet GetStore()
        {
            return GetStore(false);
        }

        /// <summary>
        ///     Get the collection of all stores. The cache is enabled by default.
        /// </summary>
        /// <param name="noCache">Bypass the cache</param>
        /// <returns></returns>
        public StoreSet GetStore(bool noCache)
        {
            return GetStore(noCache, false);
        }

        /// <summary>
        ///     Get the collection of all stores. The cache is enabled by default.
        /// </summary>
        /// <param name="noCache">Bypass the cache</param>
        /// <param name="refreshCache">Force refresh the cache</param>
        /// <returns></returns>
        public StoreSet GetStore(bool noCache, bool refreshCache)
        {
            // If no cache the load and return a entity set from the database
            if (noCache && !refreshCache)
            {
                return LoadStoreSet();
            }

            StoreSet storeSet;

            var cacheKey = StoreSet.StaticGetCacheKey();

            if (!CacheManagerProvider.GetCacheManagerInstance().Contains<StoreSet>(cacheKey) || refreshCache)
            {
                // Load the entity set from the database
                storeSet = LoadStoreSet();
                if (storeSet != null)
                {
                    // Add the entity set to the cache by reading caching parameters from the configuration
                    CacheManagerProvider.GetCacheManagerInstance().Insert(cacheKey, storeSet, 
                        ConfigurationManager.GetCacheExpirationByType(
                            storeSet.GetType()));
                }
            }
            else
            {
                storeSet = CacheManagerProvider.GetCacheManagerInstance().Get<StoreSet>(cacheKey);
            }
            return storeSet;
        }

        /// <summary>
        ///     Load all stores from the database.
        /// </summary>
        /// <returns></returns>
        private StoreSet LoadStoreSet()
        {
            var storeSet = new StoreSet();
            // Get the collection from the ORM data layer
            var metaData = new LinqMetaData();

            IQueryable<StoreEntity> storeOptions = from s in metaData.Store select s;

            var storeCollection = ((ILLBLGenProQuery)storeOptions).Execute<StoreCollection>();

            // Fill the entity set from the data collection
            if (storeCollection.Count > 0)
            {
                storeSet.AddRange(storeCollection.Select(entity => new Store(entity)));
            }

            // Return the entity set
            return storeSet;
        }

        /// <summary>
        ///     Get the collection of all stores based on business Name. The cache is enabled by default.
        /// </summary>
        /// <param name="businessName"></param>
        /// <returns></returns>
        public StoreSet GetStoreFromBusinessName(string businessName)
        {
            return GetStoreFromBusinessName(businessName,false);
        }


        /// <summary>
        ///     Get the collection of all stores based on business Name. The cache is enabled by default.
        /// </summary>
        /// <param name="businessName"></param>
        /// <param name="noCache"></param>
        /// <returns></returns>
        private StoreSet GetStoreFromBusinessName(string businessName, bool noCache)
        {
            return GetStoreFromBusinessName(businessName,noCache, false);
        }

        /// <summary>
        ///      Get the collection of all stores based on business Name. The cache is enabled by default.
        /// </summary>
        /// <param name="businessName"></param>
        /// <param name="noCache">Bypass the cache</param>
        /// <param name="refreshCache">Force refresh the cache</param>
        /// <returns></returns>
        private StoreSet GetStoreFromBusinessName(string businessName ,bool noCache, bool refreshCache)
        {
            // If no cache the load and return a entity set from the database
            if (noCache && !refreshCache)
            {
                return LoadStoreSetFromBusinessName(businessName);
            }

            StoreSet storeSet;

            var cacheKey = StoreSet.StaticGetCacheKey();

            if (!CacheManagerProvider.GetCacheManagerInstance().Contains<StoreSet>(cacheKey) || refreshCache)
            {
                // Load the entity set from the database
                storeSet = LoadStoreSetFromBusinessName(businessName);
                if (storeSet != null)
                {
                    // Add the entity set to the cache by reading caching parameters from the configuration
                    CacheManagerProvider.GetCacheManagerInstance().Insert(cacheKey, storeSet,
                        ConfigurationManager.GetCacheExpirationByType(
                            storeSet.GetType()));
                }
            }
            else
            {
                storeSet = CacheManagerProvider.GetCacheManagerInstance().Get<StoreSet>(cacheKey);
            }
            return storeSet;
        }

        /// <summary>
        ///     Load all stores from the database based on businessName.
        /// </summary>
        /// <param name="businessName"></param>
        /// <returns></returns>
        private StoreSet LoadStoreSetFromBusinessName(string businessName)
        {
            var storeSet = new StoreSet();
            var metaData = new LinqMetaData();
            var storeCollection = metaData.Store.Where(s => s.BusinessName == businessName);
            if (storeCollection.Any())
            {
                storeSet.AddRange(storeCollection.Select(entity => new Store(entity)));
            }
            return storeSet;
        }


        /// <summary>
        ///     Get the store based on store Id. The cache is enabled by default.
        /// </summary>
        /// <param name="storeId"></param>
        /// <returns></returns>
        public Store GetStoreFromId(int storeId)
        {
            return GetStoreFromId(storeId, false);
        }

        /// <summary>
        ///     Get the store based on store Id. The cache is enabled by default.
        /// </summary>
        /// <param name="storeId"></param>
        /// <param name="noCache">Bypass the cache</param>
        /// <returns></returns>
        private Store GetStoreFromId(int storeId, bool noCache)
        {
            return GetStoreFromId(storeId, noCache, false);
        }

        /// <summary>
        ///     Get the store based on store Id. The cache is enabled by default.
        /// </summary>
        /// <param name="storeId"></param>
        /// <param name="noCache">Bypass the cache</param>
        /// <param name="refreshCache">Force refresh the cache</param>
        /// <returns></returns>
        private Store GetStoreFromId(int storeId, bool noCache, bool refreshCache)
        {
            // If no cache the load and return a entity set from the database
            if (noCache && !refreshCache)
            {
                return LoadStoreFromId(storeId);
            }

            Store storeSet;

            var cacheKey = StoreSet.StaticGetCacheKey();

            if (!CacheManagerProvider.GetCacheManagerInstance().Contains<StoreSet>(cacheKey) || refreshCache)
            {
                // Load the entity set from the database
                storeSet = LoadStoreFromId(storeId);
                if (storeSet != null)
                {
                    // Add the entity set to the cache by reading caching parameters from the configuration
                    CacheManagerProvider.GetCacheManagerInstance().Insert(cacheKey, storeSet,
                        ConfigurationManager.GetCacheExpirationByType(
                            storeSet.GetType()));
                }
            }
            else
            {
                storeSet = CacheManagerProvider.GetCacheManagerInstance().Get<Store>(cacheKey);
            }
            return storeSet;
        }

        /// <summary>
        ///     Load  store based on Store Id.
        /// </summary>
        /// <returns></returns>
        private static Store LoadStoreFromId(int storeId)
        {
            var metaData = new LinqMetaData();
            var storeEntity = metaData.Store.SingleOrDefault(e => e.StoreId == storeId);
            if (storeEntity == null) return null;
            var store = new Store
            {
                StoreId = storeEntity.StoreId,
                StoreCode = storeEntity.StoreCode,
                StoreName =  storeEntity.StoreName,
                BusinessName = storeEntity.BusinessName,
                OpenDate = storeEntity.OpenDate
            };

            return store;
        }

        public Store GetStoreByStoreCode(string storeCode)
        {
            var metaData = new LinqMetaData();
            var storeEntity = metaData.Store.SingleOrDefault(e => e.StoreCode == storeCode);
            if (storeEntity == null) return null;
            var store =  new Store
            {
                StoreId = storeEntity.StoreId,
                StoreCode = storeCode,
                BusinessName = storeEntity.BusinessName,
                OpenDate = storeEntity.OpenDate
            };
            return store;
        }


    }
}
