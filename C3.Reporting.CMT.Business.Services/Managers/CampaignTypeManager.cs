using System.Linq;
using C3.Reporting.CMT.Business.Entities;
using C3.Reporting.CMT.Core.Caching;
using Mecca.CMT.DAL.CollectionClasses;
using Mecca.CMT.DAL.EntityClasses;
using Mecca.CMT.DAL.Linq;
using SD.LLBLGen.Pro.LinqSupportClasses;

namespace C3.Reporting.CMT.Business.Services.Managers
{
    public class CampaignTypeManager
    {
        /// <summary>
        ///     Get the collection of all campaignTypes. The cache is enabled by default.
        /// </summary>
        /// <returns></returns>
        public CampaignTypeSet GetCampaignTypes()
        {
            return GetCampaignTypes(false);
        }

        /// <summary>
        ///     Get the collection of all campaignTypes.
        /// </summary>
        /// <param name="noCache">Bypass the cache</param>
        /// <returns>A set of campaignTypes</returns>
        public CampaignTypeSet GetCampaignTypes(bool noCache)
        {
            return GetCampaignTypes(noCache, false);
        }

        /// <summary>
        ///     Get the collection of all campaignTypes.
        /// </summary>
        /// <param name="noCache">Bypass the cache</param>
        /// <param name="refreshCache">Force refresh the cache</param>
        /// <returns>A set of campaignTypes</returns>
        public CampaignTypeSet GetCampaignTypes(bool noCache, bool refreshCache)
        {
            // If no cache the load and return a entity set from the database
            if (noCache && !refreshCache)
            {
                return LoadCampaignTypeSet();
            }

            CampaignTypeSet campaignTypeSet;

            string cacheKey = CampaignTypeSet.StaticGetCacheKey();

            if (!CacheManagerProvider.GetCacheManagerInstance().Contains<CampaignTypeSet>(cacheKey) || refreshCache)
            {
                // Load the entity set from the database
                campaignTypeSet = LoadCampaignTypeSet();

                if (campaignTypeSet != null)
                {
                    // Add the entity set to the cache by reading caching parameters from the configuration
                    CacheManagerProvider.GetCacheManagerInstance().Insert(cacheKey, campaignTypeSet,
                                                                     ConfigurationManager.GetCacheExpirationByType(
                                                                         campaignTypeSet.GetType()));
                }
            }
            else
            {
                campaignTypeSet = CacheManagerProvider.GetCacheManagerInstance().Get<CampaignTypeSet>(cacheKey);
            }

            return campaignTypeSet;
        }

        /// <summary>
        ///     Load all campaignTypes from the database.
        /// </summary>
        /// <returns></returns>
        private CampaignTypeSet LoadCampaignTypeSet()
        {
            var campaignTypeSet = new CampaignTypeSet();

            // Get the collection from the ORM data layer
            var metaData = new LinqMetaData();

            IQueryable<CampaignTypeEntity> campaignTypes = from c in metaData.CampaignType select c;

            var campaignTypeCollection = ((ILLBLGenProQuery) campaignTypes).Execute<CampaignTypeCollection>();

            // Fill the entity set from the data collection 
            if (campaignTypeCollection.Count > 0)
            {
                campaignTypeSet.AddRange(campaignTypeCollection.Select(entity => new CampaignType(entity)));
            }

            // Return the entity set
            return campaignTypeSet;
        }

        /// <summary>
        ///     Get the current campaignType of a campaignType. The cache is not bypassed by default.
        /// </summary>
        public CampaignType GetCampaignType(int campaignTypeId)
        {
            return GetCampaignType(campaignTypeId, false);
        }

        /// <summary>
        ///     Get the current campaignType of a campaignType. The cache is not bypassed by default.
        /// </summary>
        /// <param name="campaignTypeId">The campaignType identifier</param>
        /// <param name="noCache">No-Cache parameters</param>
        /// <returns></returns>
        public CampaignType GetCampaignType(int campaignTypeId, bool noCache)
        {
            return GetCampaignType(campaignTypeId, noCache, false);
        }

        /// <summary>
        ///     Get the current campaignType of a campaignType. The cache is not bypassed by default.
        /// </summary>
        /// <param name="campaignTypeId">The campaignType identifier</param>
        /// <param name="noCache">Bypass the cache</param>
        /// <param name="refreshCache">Force refresh the cache</param>
        /// <returns>A campaignType</returns>
        public CampaignType GetCampaignType(int campaignTypeId, bool noCache, bool refreshCache)
        {
            // If no cache the load and return a entity from the database
            if (noCache && !refreshCache)
            {
                return LoadCampaignType(campaignTypeId);
            }

            CampaignType campaignType;

            string cacheKey = CampaignType.GetCacheKeyById(campaignTypeId);

            if (!CacheManagerProvider.GetCacheManagerInstance().Contains<CampaignType>(cacheKey) || refreshCache)
            {
                // Load the entity from the database
                campaignType = LoadCampaignType(campaignTypeId);

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
                campaignType = CacheManagerProvider.GetCacheManagerInstance().Get<CampaignType>(cacheKey);
            }

            return campaignType;
        }

        /// <summary>
        ///     Load a campaignType from the database given its Id.
        /// </summary>
        /// <returns></returns>
        private CampaignType LoadCampaignType(int campaignTypeId)
        {
            return new CampaignType(new CampaignTypeEntity(campaignTypeId));
        }
    }
}
