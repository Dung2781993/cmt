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
    public class ChannelItemManager
    {
        /// <summary>
        ///     Get the collection of all channel items. The cache is enabled by default.
        /// </summary>
        /// <returns></returns>
        public ChannelItemSet GetChannelItems()
        {
            return GetChannelItems(false);
        }


        /// <summary>
        ///     Get the collection of all channel items.
        /// </summary>
        /// <param name="noCache">Bypass the cache</param>
        /// <returns>A set of channel items</returns>
        public ChannelItemSet GetChannelItems(bool noCache)
        {
            return GetChannelItems(noCache, false);
        }

        /// <summary>
        ///     Get the collection of all channel items.
        /// </summary>
        /// <param name="noCache">Bypass the cache</param>
        /// <param name="refreshCache">Force refresh the cache</param>
        /// <returns>A set of channel items</returns>
        public ChannelItemSet GetChannelItems(bool noCache, bool refreshCache)
        {
            // If no cache the load and return a entity set from the database
            if (noCache && !refreshCache)
            {
                return LoadChannelItemSet();
            }

            ChannelItemSet channelItemSet;

            string cacheKey = ChannelItemSet.StaticGetCacheKey();

            if (!CacheManagerProvider.GetCacheManagerInstance().Contains<ChannelItemSet>(cacheKey) || refreshCache)
            {
                // Load the entity set from the database
                channelItemSet = LoadChannelItemSet();

                if (channelItemSet != null)
                {
                    // Add the entity set to the cache by reading caching parameters from the configuration
                    CacheManagerProvider.GetCacheManagerInstance().Insert(cacheKey, channelItemSet,
                                                                     ConfigurationManager.GetCacheExpirationByType(
                                                                         channelItemSet.GetType()));
                }
            }
            else
            {
                channelItemSet = CacheManagerProvider.GetCacheManagerInstance().Get<ChannelItemSet>(cacheKey);
            }

            return channelItemSet;
        }

        /// <summary>
        ///     Load all channel items from the database.
        /// </summary>
        /// <returns></returns>
        private ChannelItemSet LoadChannelItemSet()
        {
            var channelItemSet = new ChannelItemSet();

            // Get the collection from the ORM data layer
            var metaData = new LinqMetaData();

            IQueryable<ChannelItemEntity> channelItems = from c in metaData.ChannelItem select c;

            var channelItemCollection = ((ILLBLGenProQuery)channelItems).Execute<ChannelItemCollection>();

            // Fill the entity set from the data collection 
            if (channelItemCollection.Count > 0)
            {
                foreach (var channelItemEntity in channelItemCollection)
                {
                    var channelItem = new ChannelItem(channelItemEntity);

                    channelItemSet.Add(channelItem);
                }
            }

            // Return the entity set
            return channelItemSet;
        }

        /// <summary>
        ///     Get the channel item. The cache is not bypassed by default.
        /// </summary>
        public ChannelItem GetChannelItem(int channelItemId)
        {
            return GetChannelItem(channelItemId, false);
        }

        /// <summary>
        ///     Get the channel item. The cache is not bypassed by default.
        /// </summary>
        /// <param name="channelItemId">The channel identifier</param>
        /// <param name="noCache">No-Cache parameters</param>
        /// <returns></returns>
        public ChannelItem GetChannelItem(int channelItemId, bool noCache)
        {
            return GetChannelItem(channelItemId, noCache, false);
        }

        /// <summary>
        ///     Get the channel item. The cache is not bypassed by default.
        /// </summary>
        /// <param name="channelItemId">The channel item identifier</param>
        /// <param name="noCache">Bypass the cache</param>
        /// <param name="refreshCache">Force refresh the cache</param>
        /// <returns>A channel item</returns>
        public ChannelItem GetChannelItem(int channelItemId, bool noCache, bool refreshCache)
        {
            // If no cache the load and return a entity from the database
            if (noCache && !refreshCache)
            {
                return LoadChannel(channelItemId);
            }

            ChannelItem channelItem;

            string cacheKey = ChannelItem.GetCacheKeyById(channelItemId);

            if (!CacheManagerProvider.GetCacheManagerInstance().Contains<ChannelItem>(cacheKey) || refreshCache)
            {
                // Load the entity from the database
                channelItem = LoadChannel(channelItemId);

                if (channelItem != null)
                {
                    // Add the entity to the cache by reading caching parameters from the configuration
                    CacheManagerProvider.GetCacheManagerInstance().Insert(cacheKey, channelItem,
                                                                     ConfigurationManager.GetCacheExpirationByType(
                                                                         channelItem.GetType()));
                }
            }
            else
            {
                channelItem = CacheManagerProvider.GetCacheManagerInstance().Get<ChannelItem>(cacheKey);
            }

            return channelItem;
        }


        /// <summary>
        ///     Load a channel from the database given its Id.
        /// </summary>
        /// <returns></returns>
        private ChannelItem LoadChannel(int channelItemId)
        {
            var channelItem = new ChannelItem(new ChannelItemEntity(channelItemId));

            return channelItem;
        }

        /// <summary>
        ///     Get the channel item from product ID. The cache is not bypassed by default.
        /// </summary>
        public ChannelItem GetChannelProcduct(int productId,int channelId)
        {
            return GetChannelProcduct(productId, channelId,  false);
        }

        /// <summary>
        ///     Get the channel item from product ID. The cache is not bypassed by default.
        /// </summary>
        /// <param name="productId">The product identifier</param>
        /// <param name="noCache">No-Cache parameters</param>
        /// <returns></returns>
        public ChannelItem GetChannelProcduct(int productId,int channelId , bool noCache)
        {
            return GetChannelProcduct(productId, channelId, noCache, false);
        }

        /// <summary>
        ///     Get the channel item from product ID. The cache is not bypassed by default.
        /// </summary>
        /// <param name="productId">The product identifier</param>
        /// <param name="noCache">Bypass the cache</param>
        /// <param name="refreshCache">Force refresh the cache</param>
        /// <returns>A Channel</returns>
        public ChannelItem GetChannelProcduct(int productId,int channelId, bool noCache, bool refreshCache)
        {
            // If no cache the load and return a entity from the database
            if (noCache && !refreshCache)
            {
                return GetChannelProductByProductId(productId, channelId);
            }

            ChannelItem channel;

            string cacheKey = ChannelItem.GetCustomCacheKey(productId.ToString());

            if (!CacheManagerProvider.GetCacheManagerInstance().Contains<ChannelItem>(cacheKey) || refreshCache)
            {
                // Load the entity from the database
                channel = GetChannelProductByProductId(productId, channelId);

                if (channel != null)
                {
                    // Add the entity to the cache by reading caching parameters from the configuration
                    CacheManagerProvider.GetCacheManagerInstance().Insert(cacheKey, channel,
                                                                     ConfigurationManager.GetCacheExpirationByType(
                                                                         channel.GetType()));
                }
            }
            else
            {
                channel = CacheManagerProvider.GetCacheManagerInstance().Get<ChannelItem>(cacheKey);
            }
            return channel;

        }

        private ChannelItem GetChannelProductByProductId(int productId, int channelId)
        {
            var metaData = new LinqMetaData();
            var channel = metaData.ChannelItem.SingleOrDefault(p => p.ProductId == productId && p.ChannelId == channelId);

            if (channel == null) return null;
            var channelItem = new ChannelItem();

            //Mapping fields
            channelItem.ChannelId = channel.ChannelId;
            channelItem.ChannelItemId = channel.ChannelItemId;
            channelItem.ProductId = channel.ProductId;
            channelItem.TesterMerchQty = channel.TesterMerchQty;
            channelItem.Comments = channel.Comments;
            channelItem.LiveMerchQty = channel.LiveMerchQty;
            channelItem.NumStores = channel.NumStores;
            channelItem.SampleQty = channel.SampleQty;

            return channelItem;

        }


        /// <summary>
        /// Create a new channel item object and persist it into the database.
        /// </summary>
        /// <param name="channelItem">The channel item object</param>
        public ChannelItem AddChannelItem(ChannelItem channelItem)
        {
            // Persist the object into the database
            channelItem.Save();

            // Return the new object with the new identifier (AUTO)
            return channelItem;
        }

        /// <summary>
        /// Update a channel item object and persist changes into the database
        /// </summary>
        /// <param name="channelItem"></param>
        public void UpdateChannelItem(ChannelItem channelItem)
        {
            // Persist the object into the database
            channelItem.Save();
        }

        /// <summary>
        /// Delete a channel object and persist changes into the database
        /// </summary>
        /// <param name="channelItem"></param>
        public void DeleteChannelItem(ChannelItem channelItem)
        {
            // Remove the object into the database
            channelItem.Delete();
        }
    }
}
