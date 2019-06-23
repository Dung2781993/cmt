using System.Linq;
using C3.Reporting.CMT.Business.Entities;
using C3.Reporting.CMT.Core.Caching;
using Mecca.CMT.DAL.CollectionClasses;
using Mecca.CMT.DAL.EntityClasses;
using Mecca.CMT.DAL.Linq;
using SD.LLBLGen.Pro.LinqSupportClasses;

namespace C3.Reporting.CMT.Business.Services.Managers
{
    public class ChannelOwnerManager
    {
        /// <summary>
        ///     Get the collection of all channelOwners. The cache is enabled by default.
        /// </summary>
        /// <returns></returns>
        public ChannelOwnerSet GetChannelOwners()
        {
            return GetChannelOwners(false);
        }

        /// <summary>
        ///     Get the collection of all channelOwners.
        /// </summary>
        /// <param name="noCache">Bypass the cache</param>
        /// <returns>A set of channelOwners</returns>
        public ChannelOwnerSet GetChannelOwners(bool noCache)
        {
            return GetChannelOwners(noCache, false);
        }

        /// <summary>
        ///     Get the collection of all channelOwners.
        /// </summary>
        /// <param name="noCache">Bypass the cache</param>
        /// <param name="refreshCache">Force refresh the cache</param>
        /// <returns>A set of channelOwners</returns>
        public ChannelOwnerSet GetChannelOwners(bool noCache, bool refreshCache)
        {
            // If no cache the load and return a entity set from the database
            if (noCache && !refreshCache)
            {
                return LoadChannelOwnerSet();
            }

            ChannelOwnerSet channelOwnerSet;

            string cacheKey = ChannelOwnerSet.StaticGetCacheKey();

            if (!CacheManagerProvider.GetCacheManagerInstance().Contains<ChannelOwnerSet>(cacheKey) || refreshCache)
            {
                // Load the entity set from the database
                channelOwnerSet = LoadChannelOwnerSet();

                if (channelOwnerSet != null)
                {
                    // Add the entity set to the cache by reading caching parameters from the configuration
                    CacheManagerProvider.GetCacheManagerInstance().Insert(cacheKey, channelOwnerSet,
                                                                     ConfigurationManager.GetCacheExpirationByType(
                                                                         channelOwnerSet.GetType()));
                }
            }
            else
            {
                channelOwnerSet = CacheManagerProvider.GetCacheManagerInstance().Get<ChannelOwnerSet>(cacheKey);
            }

            return channelOwnerSet;
        }

        /// <summary>
        ///     Load all channelOwners from the database.
        /// </summary>
        /// <returns></returns>
        private ChannelOwnerSet LoadChannelOwnerSet()
        {
            var channelOwnerSet = new ChannelOwnerSet();

            // Get the collection from the ORM data layer
            var metaData = new LinqMetaData();

            IQueryable<ChannelOwnerEntity> channelOwners = from c in metaData.ChannelOwner select c;

            var channelOwnerCollection = ((ILLBLGenProQuery)channelOwners).Execute<ChannelOwnerCollection>();

            // Fill the entity set from the data collection 
            if (channelOwnerCollection.Count > 0)
            {
                foreach (var channelOwnerEntity in channelOwnerCollection)
                {
                    var channelnOwner = new ChannelOwner(channelOwnerEntity);

                    channelOwnerSet.Add(channelnOwner);
                }
            }

            // Return the entity set
            return channelOwnerSet;
        }

        /// <summary>
        ///     Get the current channelOwner of a channelOwner. The cache is not bypassed by default.
        /// </summary>
        public ChannelOwner GetChannelOwner(int channelOwnerId)
        {
            return GetChannelOwner(channelOwnerId, false);
        }

        /// <summary>
        ///     Get the current channelOwner of a channelOwner. The cache is not bypassed by default.
        /// </summary>
        /// <param name="channelOwnerId">The channelOwner identifier</param>
        /// <param name="noCache">No-Cache parameters</param>
        /// <returns></returns>
        public ChannelOwner GetChannelOwner(int channelOwnerId, bool noCache)
        {
            return GetChannelOwner(channelOwnerId, noCache, false);
        }

        /// <summary>
        ///     Get the current channelOwner of a channelOwner. The cache is not bypassed by default.
        /// </summary>
        /// <param name="channelOwnerId">The channelOwner identifier</param>
        /// <param name="noCache">Bypass the cache</param>
        /// <param name="refreshCache">Force refresh the cache</param>
        /// <returns>A channelOwner</returns>
        public ChannelOwner GetChannelOwner(int channelOwnerId, bool noCache, bool refreshCache)
        {
            // If no cache the load and return a entity from the database
            if (noCache && !refreshCache)
            {
                return LoadChannelOwner(channelOwnerId);
            }

            ChannelOwner channelOwner;

            string cacheKey = ChannelOwner.GetCacheKeyById(channelOwnerId);

            if (!CacheManagerProvider.GetCacheManagerInstance().Contains<ChannelOwner>(cacheKey) || refreshCache)
            {
                // Load the entity from the database
                channelOwner = LoadChannelOwner(channelOwnerId);

                if (channelOwner != null)
                {
                    // Add the entity to the cache by reading caching parameters from the configuration
                    CacheManagerProvider.GetCacheManagerInstance().Insert(cacheKey, channelOwner,
                                                                     ConfigurationManager.GetCacheExpirationByType(
                                                                         channelOwner.GetType()));
                }
            }
            else
            {
                channelOwner = CacheManagerProvider.GetCacheManagerInstance().Get<ChannelOwner>(cacheKey);
            }

            return channelOwner;
        }

        /// <summary>
        ///     Load a channelOwner from the database given its Id.
        /// </summary>
        /// <returns></returns>
        private ChannelOwner LoadChannelOwner(int channelOwnerId)
        {
            var channelOwner = new ChannelOwner(new ChannelOwnerEntity(channelOwnerId));
            return channelOwner;
        }

        /// <summary>
        /// Create a new channelOwner object and persist it into the database.
        /// </summary>
        /// <param name="channelOwner">The channelOwner object</param>
        public ChannelOwner AddChannelOwner(ChannelOwner channelOwner)
        {
            // Persist the object into the database
            channelOwner.Save();

            // Return the new object with the new identifier (AUTO)
            return channelOwner;
        }

        /// <summary>
        /// Update a channelOwner object and persist changes into the database
        /// </summary>
        /// <param name="channelOwner"></param>
        public void UpdateChannelOwner(ChannelOwner channelOwner)
        {
            // Persist the object into the database
            channelOwner.Save();
        }

        /// <summary>
        /// Delete a channelOwner object and persist changes into the database
        /// </summary>
        /// <param name="channelOwner"></param>
        public void DeleteChannelOwner(ChannelOwner channelOwner)
        {
            // Remove the object into the database
            channelOwner.Delete();
        }
    }
}
