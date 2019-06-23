using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C3.Reporting.CMT.Business.Entities;
using C3.Reporting.CMT.Core.Caching;
using Mecca.CMT.DAL.CollectionClasses;
using Mecca.CMT.DAL.EntityClasses;
using Mecca.CMT.DAL.Linq;
using SD.LLBLGen.Pro.LinqSupportClasses;

namespace C3.Reporting.CMT.Business.Services.Managers
{
    public class ChannelStoreManager
    {
        /// <summary>
        ///     Get the collection of all channel stores. The cache is enabled by default.
        /// </summary>
        /// <returns></returns>
        public ChannelStoreSet GetChannelStores()
        {
            return GetChannelStores(false);
        }
        /// <summary>
        ///     Get the collection of all channel stores. The cache is enabled by default.
        /// </summary>
        /// <param name="noCache">Bypass the cache</param>
        /// <returns></returns>
        public ChannelStoreSet GetChannelStores(bool noCache)
        {
            return GetChannelStores(noCache, false);
        }

        /// <summary>
        ///     Get the collection of all channel stores. The cache is enabled by default.
        /// </summary>
        /// <param name="noCache">Bypass the cache</param>
        /// <param name="refreshCache">Force refresh the cache</param>
        /// <returns></returns>
        public  ChannelStoreSet GetChannelStores (bool noCache, bool refreshCache)
        {
            // If no cache the load and return a entity set from the database
            if (noCache && !refreshCache)
            {
                return LoadChannelStoreSet();
            }

            ChannelStoreSet channelStoreSet;

            var cacheKey = ChannelStoreSet.StaticGetCacheKey();
            if (!CacheManagerProvider.GetCacheManagerInstance().Contains<ChannelStoreSet>(cacheKey) || refreshCache)
            {
                // Load the entity set from the database
                channelStoreSet = LoadChannelStoreSet();

                if (channelStoreSet != null)
                {
                    // Add the entity set to the cache by reading caching parameters from the configuration
                    CacheManagerProvider.GetCacheManagerInstance().Insert(cacheKey, channelStoreSet,
                        ConfigurationManager.GetCacheExpirationByType(
                            channelStoreSet.GetType()));
                }
            }
            else
            {
                channelStoreSet = CacheManagerProvider.GetCacheManagerInstance().Get<ChannelStoreSet>(cacheKey);
            }
            return channelStoreSet;
        }

        /// <summary>
        ///     Load all channel stores from the database.
        /// </summary>
        /// <returns></returns>
        private ChannelStoreSet LoadChannelStoreSet()
        {
            var channelStoreSet = new ChannelStoreSet();

            // Get the collection from the ORM data layer
            var metaData = new LinqMetaData();
            IQueryable<ChannelStoreEntity> channelStores = from c in metaData.ChannelStore select c;

            var channelStoreCollection = ((ILLBLGenProQuery)channelStores).Execute<ChannelStoreCollection>();

            if (channelStoreCollection.Count > 0)
            {
                foreach (var channelStoreEntity in channelStoreCollection)
                {
                    var channelStore = new ChannelStore(channelStoreEntity);
                    channelStoreSet.Add(channelStore);
                }
            }
            return channelStoreSet;
        }

        /// <summary>
        /// Create a new channel store object and persist it into the database.
        /// </summary>
        /// <param name="channelStore">The channel item object</param>
        public ChannelStore AddChannelStore(ChannelStore channelStore)
        {
            channelStore.Save();
            return channelStore;
        }


        /// <summary>
        /// Delete a channel store object and persist changes into the database
        /// </summary>
        /// <param name="channelStore"></param>
        public void DeleteChannelStore(List<ChannelStore> channelStore)
        {
            // Remove the object into the database
            foreach (var item in channelStore)
            {
                item.Delete();
            }
        }

        /// <summary>
        /// Get campaign store by channel id and store id.
        /// </summary>
        /// <param name="channelId"></param>
        /// <param name="storeId"></param>
        /// <returns></returns>
        public ChannelStore GetChannelStoreByStoreIdAndChannelId(int channelId, int storeId)
        {
            var metaData = new LinqMetaData();
            var store = metaData.ChannelStore.FirstOrDefault(e => e.ChannelId == channelId && e.StoreId == storeId);
            if (store == null) return null;

            var channelStore = new ChannelStore
            {
                ChannelStoreId = store.ChannelStoreId,
                ChannelId = channelId,
                CampaignId = store.CampaignId,
                StoreId = storeId,
                DateAdded = store.DateAdded,
                IsSelected = false
            };

            if (store.IsSelected == 1)
            {
                channelStore.IsSelected = true;
            }

            return channelStore;

        }

    

        /// <summary>
        ///     Get the collection of all channel stores by channelId. The cache is enabled by default.
        /// </summary>
        /// <param name="channelId">Bypass the cache</param>
        /// <returns></returns>
        public List<ChannelStore> GetChannelStoresByChannelId(int channelId)
        {
            return GetChannelStoresByChannelId(channelId, false);
        }
        /// <summary>
        ///     Get the collection of all channel stores. The cache is enabled by default.
        /// </summary>
        /// <param name="noCache">Bypass the cache</param>
        /// <param name="channelId">Bypass the cache</param>
        /// <returns></returns>
        public List<ChannelStore> GetChannelStoresByChannelId(int channelId,bool noCache)
        {
            return GetChannelStoresByChannelId(channelId, noCache, false);
        }

        /// <summary>
        ///     Get the collection of all channel stores. The cache is enabled by default.
        /// </summary>
        /// <param name="noCache">Bypass the cache</param>
        /// <param name="refreshCache">Force refresh the cache</param>
        /// <param name="channelId">Bypass the cache</param>
        /// param name="channelId">Bypass the cache</param>
        /// <returns></returns>
        public List<ChannelStore> GetChannelStoresByChannelId(int channelId,bool noCache, bool refreshCache)
        {
            // If no cache the load and return a entity set from the database
            if (noCache && !refreshCache)
            {
                return GetChannelStoreById(channelId);
            }

            List<ChannelStore> channelStoreList;

            var cacheKey = ChannelStoreSet.StaticGetCacheKey();
            if (!CacheManagerProvider.GetCacheManagerInstance().Contains<ChannelStoreSet>(cacheKey) || refreshCache)
            {
                // Load the entity set from the database
                channelStoreList = GetChannelStoreById(channelId);

                if (channelStoreList != null)
                {
                    // Add the entity set to the cache by reading caching parameters from the configuration
                    CacheManagerProvider.GetCacheManagerInstance().Insert(cacheKey, channelStoreList,
                        ConfigurationManager.GetCacheExpirationByType(
                            channelStoreList.GetType()));
                }
            }
            else
            {
                channelStoreList = CacheManagerProvider.GetCacheManagerInstance().Get<List<ChannelStore>>(cacheKey);
            }
            return channelStoreList;
        }

        /// <summary>
        /// Get campaign store by campaign id
        /// </summary>
        /// <param name="channelId"></param>
        /// <returns></returns>
        public List<ChannelStore> GetChannelStoreById(int channelId)
        {
            var metaData = new LinqMetaData();
            var channelStoreList = metaData.ChannelStore.Where(e => e.ChannelId == channelId);
            var channelStoreSet = new List<ChannelStore>();
            foreach (var item in channelStoreList)
            {
                var channelStore = new ChannelStore
                {
                    ChannelStoreId = item.ChannelStoreId,
                    CampaignId = item.CampaignId,
                    ChannelId = channelId,
                    StoreId = item.StoreId,
                    DateAdded = item.DateAdded,
                    IsSelected = false
                };
                if (item.IsSelected == 1)
                {
                    channelStore.IsSelected = true;
                }
                channelStoreSet.Add(channelStore);
            }
            return channelStoreSet;
        }

        /// <summary>
        /// Update a channel store object and persist changes into the database
        /// </summary>
        /// <param name="channelStore"></param>
        public void UpdateChannelStore(ChannelStore channelStore)
        {
            channelStore.Save();
        }
    }
}
