using System.Linq;
using C3.Reporting.CMT.Business.Entities;
using C3.Reporting.CMT.Core.Caching;
using Mecca.CMT.DAL.CollectionClasses;
using Mecca.CMT.DAL.EntityClasses;
using Mecca.CMT.DAL.Linq;
using SD.LLBLGen.Pro.LinqSupportClasses;

namespace C3.Reporting.CMT.Business.Services.Managers
{
    public class CampaignOwnerManager
    {
         /// <summary>
        ///     Get the collection of all campaignOwners. The cache is enabled by default.
        /// </summary>
        /// <returns></returns>
        public CampaignOwnerSet GetCampaignOwners()
        {
            return GetCampaignOwners(false);
        }

        /// <summary>
        ///     Get the collection of all campaignOwners.
        /// </summary>
        /// <param name="noCache">Bypass the cache</param>
        /// <returns>A set of campaignOwners</returns>
        public CampaignOwnerSet GetCampaignOwners(bool noCache)
        {
            return GetCampaignOwners(noCache, false);
        }

        /// <summary>
        ///     Get the collection of all campaignOwners.
        /// </summary>
        /// <param name="noCache">Bypass the cache</param>
        /// <param name="refreshCache">Force refresh the cache</param>
        /// <returns>A set of campaignOwners</returns>
        public CampaignOwnerSet GetCampaignOwners(bool noCache, bool refreshCache)
        {
            // If no cache the load and return a entity set from the database
            if (noCache && !refreshCache)
            {
                return LoadCampaignOwnerSet();
            }

            CampaignOwnerSet campaignOwnerOwnerSet;

            string cacheKey = CampaignOwnerSet.StaticGetCacheKey();

            if (!CacheManagerProvider.GetCacheManagerInstance().Contains<CampaignOwnerSet>(cacheKey) || refreshCache)
            {
                // Load the entity set from the database
                campaignOwnerOwnerSet = LoadCampaignOwnerSet();

                if (campaignOwnerOwnerSet != null)
                {
                    // Add the entity set to the cache by reading caching parameters from the configuration
                    CacheManagerProvider.GetCacheManagerInstance().Insert(cacheKey, campaignOwnerOwnerSet,
                                                                     ConfigurationManager.GetCacheExpirationByType(
                                                                         campaignOwnerOwnerSet.GetType()));
                }
            }
            else
            {
                campaignOwnerOwnerSet = CacheManagerProvider.GetCacheManagerInstance().Get<CampaignOwnerSet>(cacheKey);
            }

            return campaignOwnerOwnerSet;
        }

        /// <summary>
        ///     Load all campaignOwners from the database.
        /// </summary>
        /// <returns></returns>
        private CampaignOwnerSet LoadCampaignOwnerSet()
        {
            var campaignOwnerOwnerSet = new CampaignOwnerSet();

            // Get the collection from the ORM data layer
            var metaData = new LinqMetaData();

            IQueryable<CampaignOwnerEntity> campaignOwners = from c in metaData.CampaignOwner select c;

            var campaignOwnerCollection = ((ILLBLGenProQuery)campaignOwners).Execute<CampaignOwnerCollection>();

            // Fill the entity set from the data collection 
            if (campaignOwnerCollection.Count > 0)
            {
                foreach (var campaignOwnerEntity in campaignOwnerCollection)
                {
                    var campaignOwner = new CampaignOwner(campaignOwnerEntity);

                    campaignOwnerOwnerSet.Add(campaignOwner);
                }
            }

            // Return the entity set
            return campaignOwnerOwnerSet;
        }

        /// <summary>
        ///     Get the current campaignOwner of a campaignOwner. The cache is not bypassed by default.
        /// </summary>
        public CampaignOwner GetCampaignOwner(int campaignOwnerId)
        {
            return GetCampaignOwner(campaignOwnerId, false);
        }

        /// <summary>
        ///     Get the current campaignOwner of a campaignOwner. The cache is not bypassed by default.
        /// </summary>
        /// <param name="campaignOwnerId">The campaignOwner identifier</param>
        /// <param name="noCache">No-Cache parameters</param>
        /// <returns></returns>
        public CampaignOwner GetCampaignOwner(int campaignOwnerId, bool noCache)
        {
            return GetCampaignOwner(campaignOwnerId, noCache, false);
        }

        /// <summary>
        ///     Get the current campaignOwner of a campaignOwner. The cache is not bypassed by default.
        /// </summary>
        /// <param name="campaignOwnerId">The campaignOwner identifier</param>
        /// <param name="noCache">Bypass the cache</param>
        /// <param name="refreshCache">Force refresh the cache</param>
        /// <returns>A campaignOwner</returns>
        public CampaignOwner GetCampaignOwner(int campaignOwnerId, bool noCache, bool refreshCache)
        {
            // If no cache the load and return a entity from the database
            if (noCache && !refreshCache)
            {
                return LoadCampaignOwner(campaignOwnerId);
            }

            CampaignOwner campaignOwner;

            string cacheKey = CampaignOwner.GetCacheKeyById(campaignOwnerId);

            if (!CacheManagerProvider.GetCacheManagerInstance().Contains<CampaignOwner>(cacheKey) || refreshCache)
            {
                // Load the entity from the database
                campaignOwner = LoadCampaignOwner(campaignOwnerId);

                if (campaignOwner != null)
                {
                    // Add the entity to the cache by reading caching parameters from the configuration
                    CacheManagerProvider.GetCacheManagerInstance().Insert(cacheKey, campaignOwner,
                                                                     ConfigurationManager.GetCacheExpirationByType(
                                                                         campaignOwner.GetType()));
                }
            }
            else
            {
                campaignOwner = CacheManagerProvider.GetCacheManagerInstance().Get<CampaignOwner>(cacheKey);
            }

            return campaignOwner;
        }

        /// <summary>
        ///     Load a campaignOwner from the database given its Id.
        /// </summary>
        /// <returns></returns>
        private CampaignOwner LoadCampaignOwner(int campaignOwnerId)
        {
            var campaignOwner = new CampaignOwner(new CampaignOwnerEntity(campaignOwnerId));
            return campaignOwner;            
        }        

        /// <summary>
        /// Create a new campaignOwner object and persist it into the database.
        /// </summary>
        /// <param name="campaignOwner">The campaignOwner object</param>
        public CampaignOwner AddCampaignOwner(CampaignOwner campaignOwner)
        {            
            // Persist the object into the database
            campaignOwner.Save();

            // Return the new object with the new identifier (AUTO)
            return campaignOwner;
        }
       
        /// <summary>
        /// Update a campaignOwner object and persist changes into the database
        /// </summary>
        /// <param name="campaignOwner"></param>
        public void UpdateCampaignOwner(CampaignOwner campaignOwner)
        {
            // Persist the object into the database
            campaignOwner.Save();
        }

        /// <summary>
        /// Delete a campaignOwner object and persist changes into the database
        /// </summary>
        /// <param name="campaignOwner"></param>
        public void DeleteCampaignOwner(CampaignOwner campaignOwner)
        {
            // Remove the object into the database
            campaignOwner.Delete();
        }
    }
}
