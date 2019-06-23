using System.Linq;
using C3.Reporting.CMT.Business.Entities;
using C3.Reporting.CMT.Core.Caching;
using Mecca.CMT.DAL.CollectionClasses;
using Mecca.CMT.DAL.EntityClasses;
using Mecca.CMT.DAL.Linq;
using SD.LLBLGen.Pro.LinqSupportClasses;

namespace C3.Reporting.CMT.Business.Services.Managers
{
    public class ChannelManager
    {
        /// <summary>
        ///     Get the collection of all campaigns. The cache is enabled by default.
        /// </summary>
        /// <returns></returns>
        public ChannelSet GetChannels()
        {
            return GetChannels(false);
        }

        /// <summary>
        ///     Get the collection of all campaigns.
        /// </summary>
        /// <param name="noCache">Bypass the cache</param>
        /// <returns>A set of campaigns</returns>
        public ChannelSet GetChannels(bool noCache)
        {
            return GetChannels(noCache, false);
        }

        /// <summary>
        ///     Get the collection of all campaigns.
        /// </summary>
        /// <param name="noCache">Bypass the cache</param>
        /// <param name="refreshCache">Force refresh the cache</param>
        /// <returns>A set of campaigns</returns>
        public ChannelSet GetChannels(bool noCache, bool refreshCache)
        {
            // If no cache the load and return a entity set from the database
            if (noCache && !refreshCache)
            {
                return LoadChannelSet();
            }

            ChannelSet channelSet;

            string cacheKey = ChannelSet.StaticGetCacheKey();

            if (!CacheManagerProvider.GetCacheManagerInstance().Contains<ChannelSet>(cacheKey) || refreshCache)
            {
                // Load the entity set from the database
                channelSet = LoadChannelSet();

                if (channelSet != null)
                {
                    // Add the entity set to the cache by reading caching parameters from the configuration
                    CacheManagerProvider.GetCacheManagerInstance().Insert(cacheKey, channelSet,
                                                                     ConfigurationManager.GetCacheExpirationByType(
                                                                         channelSet.GetType()));
                }
            }
            else
            {
                channelSet = CacheManagerProvider.GetCacheManagerInstance().Get<ChannelSet>(cacheKey);
            }

            return channelSet;
        }

        /// <summary>
        ///     Load all campaigns from the database.
        /// </summary>
        /// <returns></returns>
        private ChannelSet LoadChannelSet()
        {
            var channelSet = new ChannelSet();

            // Get the collection from the ORM data layer
            var metaData = new LinqMetaData();

            IQueryable<ChannelEntity> channels = from c in metaData.Channel select c;

            var channelCollection = ((ILLBLGenProQuery)channels).Execute<ChannelCollection>();

            // Fill the entity set from the data collection 
            if (channelCollection.Count > 0)
            {
                foreach (var channelEntity in channelCollection)
                {
                    var channel = new Channel(channelEntity);
                    channelSet.Add(channel);
                }
            }

            // Return the entity set
            return channelSet;
        }

        /// <summary>
        ///     Get the current campaign of a campaign. The cache is not bypassed by default.
        /// </summary>
        public Channel GetChannel(int channelId)
        {
            return GetChannel(channelId, false);
        }

        /// <summary>
        ///     Get the current campaign of a campaign. The cache is not bypassed by default.
        /// </summary>
        /// <param name="channelId">The campaign identifier</param>
        /// <param name="noCache">No-Cache parameters</param>
        /// <returns></returns>
        public Channel GetChannel(int channelId, bool noCache)
        {
            return GetChannel(channelId, noCache, false);
        }

        /// <summary>
        ///     Get the current campaign of a campaign. The cache is not bypassed by default.
        /// </summary>
        /// <param name="channelId">The campaign identifier</param>
        /// <param name="noCache">Bypass the= cache</param>
        /// <param name="refreshCache">Force refresh the cache</param>
        /// <returns>A campaign</returns>
        public Channel GetChannel(int channelId, bool noCache, bool refreshCache)
        {
            // If no cache the load and return a entity from the database
            if (noCache && !refreshCache)
            {
                return LoadChannel(channelId);
            }

            Channel campaign;

            string cacheKey = Channel.GetCacheKeyById(channelId);

            if (!CacheManagerProvider.GetCacheManagerInstance().Contains<Channel>(cacheKey) || refreshCache)
            {
                // Load the entity from the database
                campaign = LoadChannel(channelId);

                if (campaign != null)
                {
                    // Add the entity to the cache by reading caching parameters from the configuration
                    CacheManagerProvider.GetCacheManagerInstance().Insert(cacheKey, campaign,
                                                                     ConfigurationManager.GetCacheExpirationByType(
                                                                         campaign.GetType()));
                }
            }
            else
            {
                campaign = CacheManagerProvider.GetCacheManagerInstance().Get<Channel>(cacheKey);
            }

            return campaign;
        }

        /// <summary>
        ///     Load a campaign from the database given its Id.
        /// </summary>
        /// <returns></returns>
        private Channel LoadChannel(int channelId)
        {
            var channel = new Channel(new ChannelEntity(channelId));
            return channel;
        }

        /// <summary>
        /// Create a new campaign object and persist it into the database.
        /// </summary>
        /// <param name="campaign">The campaign object</param>
        public Channel AddChannel(Channel campaign)
        {
            // Persist the object into the database
            campaign.Save();

            // Return the new object with the new identifier (AUTO)
            return campaign;
        }

        /// <summary>
        /// Update a campaign object and persist changes into the database
        /// </summary>
        /// <param name="campaign"></param>
        public void UpdateChannel(Channel campaign)
        {
            // Persist the object into the database
            campaign.Save();
        }

        /// <summary>
        /// Delete a campaign object and persist changes into the database
        /// </summary>
        /// <param name="campaign"></param>
        public void DeleteChannel(Channel campaign)
        {
            // Remove the object into the database
            campaign.Delete();
        }
    }
}
