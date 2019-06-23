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
    public class CampaignStoreManager
    {
        /// <summary>
        ///     Get the collection of all campaign stores. The cache is enabled by default.
        /// </summary>
        /// <returns></returns>
        public CampaignStoreSet GetCampaignStores()
        {
            return GetCampaignStores(false);
        }

        /// <summary>
        ///     Get the collection of all campaign stores. The cache is enabled by default.
        /// </summary>
        /// <param name="noCache">Bypass the cache</param>
        /// <returns></returns>
        public CampaignStoreSet GetCampaignStores(bool noCache)
        {
            return GetCampaignStores(noCache,false);
        }

        /// <summary>
        ///     Get the collection of all campaign stores. The cache is enabled by default.
        /// </summary>
        /// <param name="noCache">Bypass the cache</param>
        /// <param name="refreshCache">Force refresh the cache</param>
        /// <returns></returns>
        public CampaignStoreSet GetCampaignStores(bool noCache, bool refreshCache)
        {
            // If no cache the load and return a entity set from the database
            if (noCache && !refreshCache)
            {
                return LoadCampaignStoreSet();
            }

            CampaignStoreSet campaignStoreSet;

            string cacheKey = CampaignStoreSet.StaticGetCacheKey();
            if (!CacheManagerProvider.GetCacheManagerInstance().Contains<CampaignStoreSet>(cacheKey) || refreshCache)
            {
                // Load the entity set from the database
                campaignStoreSet = LoadCampaignStoreSet();

                if (campaignStoreSet != null)
                {
                    // Add the entity set to the cache by reading caching parameters from the configuration
                    CacheManagerProvider.GetCacheManagerInstance().Insert(cacheKey, campaignStoreSet,
                        ConfigurationManager.GetCacheExpirationByType(
                            campaignStoreSet.GetType()));
                }
            }
            else
            {
                campaignStoreSet = CacheManagerProvider.GetCacheManagerInstance().Get<CampaignStoreSet>(cacheKey);
            }
            return campaignStoreSet;
        }

        /// <summary>
        ///     Load all campaign stores from the database.
        /// </summary>
        /// <returns></returns>
        private CampaignStoreSet LoadCampaignStoreSet()
        {
            var campaignStoreSet = new CampaignStoreSet();

            // Get the collection from the ORM data layer
            var metaData = new LinqMetaData();
            IQueryable<CampaignStoreEntity> campaignStores = from c in metaData.CampaignStore select c;

            var campaignStoreCollection = ((ILLBLGenProQuery) campaignStores).Execute<CampaignStoreCollection>();

            if (campaignStoreCollection.Count > 0)
            {
                foreach (var campaignStoreEntity in campaignStoreCollection)
                {
                    var campaignStore = new CampaignStore(campaignStoreEntity);
                    campaignStoreSet.Add(campaignStore);
                }
            }
            return campaignStoreSet;
        }

        /// <summary>
        /// Create a new campaign store object and persist it into the database.
        /// </summary>
        /// <param name="campaignStore">The channel item object</param>
        public CampaignStore AddCampaignStore(CampaignStore campaignStore)
        {
            campaignStore.Save();
            return campaignStore;
        }


        /// <summary>
        /// Delete a campaign object and persist changes into the database
        /// </summary>
        /// <param name="campaignStore"></param>
        public void DeleteCampaignItem(List<CampaignStore> campaignStore)
        {
            // Remove the object into the database
            foreach (var item in campaignStore)
            {
                item.Delete();
            }
        }

        /// <summary>
        /// Get campaign store by campaign id and store id.
        /// </summary>
        /// <param name="campaignId"></param>
        /// <param name="storeId"></param>
        /// <returns></returns>
        public CampaignStore GetCampaignStore(int campaignId, int storeId)
        {
            var metaData = new LinqMetaData();
            var store = metaData.CampaignStore.FirstOrDefault(e => e.CampaignId == campaignId && e.StoreId == storeId);
            if (store == null) return null;

            var campaignStore = new CampaignStore
            {
                CampaignStoreId =  store.CampaignStoreId,
                CampaignId = campaignId,
                StoreId = storeId,
                DateAdded =  store.DateAdded,
                IsSelected = false
            };

            if (store.IsSelected == 1)
            {
                campaignStore.IsSelected = true;
            }

            return campaignStore;

        }

        /// <summary>
        /// Update a campaign object and persist changes into the database
        /// </summary>
        /// <param name="campaignStore"></param>
        public void UpdateCampaignStore(CampaignStore campaignStore)
        {
            campaignStore.Save();
        }


        /// <summary>
        /// Get campaign store by campaign id
        /// </summary>
        /// <param name="campaignId"></param>
        /// <returns></returns>
        public List<CampaignStore> GetCampaignStoreById(int campaignId)
        {
            var metaData = new LinqMetaData();
            var camapignStoreList = metaData.CampaignStore.Where(e => e.CampaignId == campaignId);
            var campaignStoreSet = new List<CampaignStore>();
            foreach(var item in camapignStoreList)
            {
                var campaignStore = new CampaignStore
                {
                    CampaignStoreId = item.CampaignStoreId,
                    CampaignId = campaignId,
                    StoreId = item.StoreId,
                    DateAdded = item.DateAdded
                };
                campaignStoreSet.Add(campaignStore);
            }
            return campaignStoreSet;
        }

        /// <summary>
        /// Get campaign store by campaign id
        /// </summary>
        /// <param name="campaignId"></param>
        /// <returns></returns>
        public List<CampaignStore> GetCampaignStoreByIdandSelectedStores(int campaignId)
        {
            var metaData = new LinqMetaData();
            var camapignStoreList = metaData.CampaignStore.Where(e => e.CampaignId == campaignId && e.IsSelected == 1);
            var campaignStoreSet = new List<CampaignStore>();
            foreach (var item in camapignStoreList)
            {
                var campaignStore = new CampaignStore
                {
                    CampaignStoreId = item.CampaignStoreId,
                    CampaignId = campaignId,
                    StoreId = item.StoreId,
                    DateAdded = item.DateAdded
                };
                campaignStoreSet.Add(campaignStore);
            }
            return campaignStoreSet;
        }
    }
}
