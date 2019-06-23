using System.Linq;
using C3.Reporting.CMT.Business.Entities;
using C3.Reporting.CMT.Core.Caching;
using Mecca.CMT.DAL.CollectionClasses;
using Mecca.CMT.DAL.EntityClasses;
using Mecca.CMT.DAL.Linq;
using SD.LLBLGen.Pro.LinqSupportClasses;

namespace C3.Reporting.CMT.Business.Services.Managers
{
    public class ChannelTypeManager
    {
        /// <summary>
        ///     Get the collection of all channelTypes. The cache is enabled by default.
        /// </summary>
        /// <returns></returns>
        public ChannelTypeSet GetChannelTypes()
        {
            return GetChannelTypes(false);
        }

        /// <summary>
        ///     Get the collection of all channelTypes.
        /// </summary>
        /// <param name="noCache">Bypass the cache</param>
        /// <returns>A set of channelTypes</returns>
        public ChannelTypeSet GetChannelTypes(bool noCache)
        {
            return GetChannelTypes(noCache, false);
        }

        /// <summary>
        ///     Get the collection of all channelTypes.
        /// </summary>
        /// <param name="noCache">Bypass the cache</param>
        /// <param name="refreshCache">Force refresh the cache</param>
        /// <returns>A set of channelTypes</returns>
        public ChannelTypeSet GetChannelTypes(bool noCache, bool refreshCache)
        {
            // If no cache the load and return a entity set from the database
            if (noCache && !refreshCache)
            {
                return LoadChannelTypeSet();
            }

            ChannelTypeSet channelTypeSet;

            string cacheKey = ChannelTypeSet.StaticGetCacheKey();

            if (!CacheManagerProvider.GetCacheManagerInstance().Contains<ChannelTypeSet>(cacheKey) || refreshCache)
            {
                // Load the entity set from the database
                channelTypeSet = LoadChannelTypeSet();

                if (channelTypeSet != null)
                {
                    // Add the entity set to the cache by reading caching parameters from the configuration
                    CacheManagerProvider.GetCacheManagerInstance().Insert(cacheKey, channelTypeSet,
                                                                     ConfigurationManager.GetCacheExpirationByType(
                                                                         channelTypeSet.GetType()));
                }
            }
            else
            {
                channelTypeSet = CacheManagerProvider.GetCacheManagerInstance().Get<ChannelTypeSet>(cacheKey);
            }

            return channelTypeSet;
        }

        /// <summary>
        ///     Load all channelTypes from the database.
        /// </summary>
        /// <returns></returns>
        private ChannelTypeSet LoadChannelTypeSet()
        {
            var channelTypeSet = new ChannelTypeSet();

            // Get the collection from the ORM data layer
            var metaData = new LinqMetaData();

            IQueryable<ChannelTypeEntity> channelTypes = from c in metaData.ChannelType select c;

            var campaignTypeCollection = ((ILLBLGenProQuery)channelTypes).Execute<ChannelTypeCollection>();

            // Fill the entity set from the data collection 
            if (campaignTypeCollection.Count > 0)
            {
                channelTypeSet.AddRange(campaignTypeCollection.Select(entity => new ChannelType(entity)));
            }

            // Return the entity set
            return channelTypeSet;
        }

        /// <summary>
        ///     Get the current campaignType of a campaignType. The cache is not bypassed by default.
        /// </summary>
        public ChannelType GetChannelType(int channelTypeId)
        {
            return GetChannelType(channelTypeId, false);
        }

        /// <summary>
        ///     Get the current campaignType of a campaignType. The cache is not bypassed by default.
        /// </summary>
        /// <param name="channelTypeId">The campaignType identifier</param>
        /// <param name="noCache">No-Cache parameters</param>
        /// <returns></returns>
        public ChannelType GetChannelType(int channelTypeId, bool noCache)
        {
            return GetChannelType(channelTypeId, noCache, false);
        }

        /// <summary>
        ///     Get the current campaignType of a campaignType. The cache is not bypassed by default.
        /// </summary>
        /// <param name="channelTypeId">The campaignType identifier</param>
        /// <param name="noCache">Bypass the cache</param>
        /// <param name="refreshCache">Force refresh the cache</param>
        /// <returns>A campaignType</returns>
        public ChannelType GetChannelType(int channelTypeId, bool noCache, bool refreshCache)
        {
            // If no cache the load and return a entity from the database
            if (noCache && !refreshCache)
            {
                return LoadChannelType(channelTypeId);
            }

            ChannelType campaignType;

            string cacheKey = ChannelType.GetCacheKeyById(channelTypeId);

            if (!CacheManagerProvider.GetCacheManagerInstance().Contains<ChannelType>(cacheKey) || refreshCache)
            {
                // Load the entity from the database
                campaignType = LoadChannelType(channelTypeId);

                if (campaignType != null)
                {
                    // Add the entity to the cache by reading caching parameters from the configuration
                    CacheManagerProvider.GetCacheManagerInstance().Insert(cacheKey, campaignType,
                                                                     ConfigurationManager.GetCacheExpirationByType(
                                                                         campaignType.GetType()));
                }
            }
            else
            {
                campaignType = CacheManagerProvider.GetCacheManagerInstance().Get<ChannelType>(cacheKey);
            }

            return campaignType;
        }

        /// <summary>
        ///     Load a campaignType from the database given its Id.
        /// </summary>
        /// <returns></returns>
        private ChannelType LoadChannelType(int channelTypeId)
        {
            return new ChannelType(new ChannelTypeEntity(channelTypeId));
        }
    }
}
