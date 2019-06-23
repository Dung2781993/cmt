using System.Linq;
using C3.Reporting.CMT.Business.Entities;
using C3.Reporting.CMT.Core.Caching;
using Mecca.CMT.DAL.CollectionClasses;
using Mecca.CMT.DAL.EntityClasses;
using Mecca.CMT.DAL.Linq;
using SD.LLBLGen.Pro.LinqSupportClasses;

namespace C3.Reporting.CMT.Business.Services.Managers
{
    public class StoreOptionManager
    {
        /// <summary>
        ///     Get the collection of all StoreOptions. The cache is enabled by default.
        /// </summary>
        /// <returns></returns>
        public StoreOptionTypeSet GetStoreOptions()
        {
            return GetStoreOptions(false);
        }

        /// <summary>
        ///    Get the collection of all StoreOptions. The cache is enabled by default.
        /// </summary>
        /// <param name="noCache">Bypass the cache</param>
        /// <returns>A set of StoreOptions</returns>
        public StoreOptionTypeSet GetStoreOptions(bool noCache)
        {
            return GetStoreOptions(noCache, false);
        }

        /// <summary>
        ///    Get the collection of all StoreOptions. The cache is enabled by default.
        /// </summary>
        /// <param name="noCache">Bypass the cache</param>
        /// <param name="refreshCache">Force refresh the cache</param>
        /// <returns>A set of StoreOptions</returns>
        public StoreOptionTypeSet GetStoreOptions(bool noCache, bool refreshCache)
        {
            // If no cache the load and return a entity set from the database
            if (noCache && !refreshCache)
            {
                return LoadStoreOptionTypeSet();
            }

            StoreOptionTypeSet storeOptionSet;

            var cacheKey = StoreOptionTypeSet.StaticGetCacheKey();

            if (!CacheManagerProvider.GetCacheManagerInstance().Contains<StoreOptionTypeSet>(cacheKey) || refreshCache)
            {
                // Load the entity set from the database
                storeOptionSet = LoadStoreOptionTypeSet();
                if (storeOptionSet != null)
                {
                    // Add the entity set to the cache by reading caching parameters from the configuration
                    CacheManagerProvider.GetCacheManagerInstance().Insert(cacheKey, storeOptionSet,
                        ConfigurationManager.GetCacheExpirationByType(
                            storeOptionSet.GetType()));
                }
            }
            else
            {
                storeOptionSet = CacheManagerProvider.GetCacheManagerInstance().Get<StoreOptionTypeSet>(cacheKey);
            }

            return storeOptionSet;
        }

        /// <summary>
        ///     Load all storeOptions from the database.
        /// </summary>
        /// <returns></returns>
        private StoreOptionTypeSet LoadStoreOptionTypeSet()
        {
            var storeOptionSet = new StoreOptionTypeSet();
            // Get the collection from the ORM data layer
            var metaData = new LinqMetaData();

            IQueryable<StoreOptionEntity> storeOptions = from s in metaData.StoreOption select s;

            var storeOptionCollection = ((ILLBLGenProQuery) storeOptions).Execute<StoreOptionCollection>();

            // Fill the entity set from the data collection 
            if (storeOptionCollection.Count > 0)
            {
                storeOptionSet.AddRange(storeOptionCollection.Select(entity => new StoreOption(entity)));
            }

            // Return the entity set
            return storeOptionSet;
        }
    }
}
