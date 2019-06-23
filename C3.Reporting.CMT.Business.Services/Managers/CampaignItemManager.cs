using System.Linq;
using C3.Reporting.CMT.Business.Entities;
using C3.Reporting.CMT.Core.Caching;
using Mecca.CMT.DAL.CollectionClasses;
using Mecca.CMT.DAL.EntityClasses;
using Mecca.CMT.DAL.Linq;
using SD.LLBLGen.Pro.LinqSupportClasses;

namespace C3.Reporting.CMT.Business.Services.Managers
{
    public class CampaignItemManager
    {
         /// <summary>
        ///     Get the collection of all campaign items. The cache is enabled by default.
        /// </summary>
        /// <returns></returns>
        public CampaignItemSet GetCampaignItems()
        {
            return GetCampaignItems(false);
        }

        /// <summary>
        ///     Get the collection of all campaign items.
        /// </summary>
        /// <param name="noCache">Bypass the cache</param>
        /// <returns>A set of campaign items</returns>
        public CampaignItemSet GetCampaignItems(bool noCache)
        {
            return GetCampaignItems(noCache, false);
        }

        /// <summary>
        ///     Get the collection of all campaign items.
        /// </summary>
        /// <param name="noCache">Bypass the cache</param>
        /// <param name="refreshCache">Force refresh the cache</param>
        /// <returns>A set of campaign items</returns>
        public CampaignItemSet GetCampaignItems(bool noCache, bool refreshCache)
        {
            // If no cache the load and return a entity set from the database
            if (noCache && !refreshCache)
            {
                return LoadCampaignItemSet();
            }

            CampaignItemSet campaignItemSet;

            string cacheKey = CampaignItemSet.StaticGetCacheKey();

            if (!CacheManagerProvider.GetCacheManagerInstance().Contains<CampaignItemSet>(cacheKey) || refreshCache)
            {
                // Load the entity set from the database
                campaignItemSet = LoadCampaignItemSet();

                if (campaignItemSet != null)
                {
                    // Add the entity set to the cache by reading caching parameters from the configuration
                    CacheManagerProvider.GetCacheManagerInstance().Insert(cacheKey, campaignItemSet,
                                                                     ConfigurationManager.GetCacheExpirationByType(
                                                                         campaignItemSet.GetType()));
                }
            }
            else
            {
                campaignItemSet = CacheManagerProvider.GetCacheManagerInstance().Get<CampaignItemSet>(cacheKey);
            }

            return campaignItemSet;
        }

        /// <summary>
        ///     Load all campaign items from the database.
        /// </summary>
        /// <returns></returns>
        private CampaignItemSet LoadCampaignItemSet()
        {
            var campaignItemSet = new CampaignItemSet();

            // Get the collection from the ORM data layer
            var metaData = new LinqMetaData();

            IQueryable<CampaignItemEntity> campaignItems = from c in metaData.CampaignItem select c;

            var campaignItemCollection = ((ILLBLGenProQuery)campaignItems).Execute<CampaignItemCollection>();

            // Fill the entity set from the data collection 
            if (campaignItemCollection.Count > 0)
            {
                foreach (var campaignItemEntity in campaignItemCollection)
                {
                    var campaignItem = new CampaignItem(campaignItemEntity);

                    campaignItemSet.Add(campaignItem);
                }
            }

            // Return the entity set
            return campaignItemSet;
        }

        /// <summary>
        ///     Get the campaign item. The cache is not bypassed by default.
        /// </summary>
        public CampaignItem GetCampaignItem(int campaignItemId)
        {
            return GetCampaignItem(campaignItemId, false);
        }

        /// <summary>
        ///     Get the campaign item. The cache is not bypassed by default.
        /// </summary>
        /// <param name="campaignItemId">The campaign identifier</param>
        /// <param name="noCache">No-Cache parameters</param>
        /// <returns></returns>
        public CampaignItem GetCampaignItem(int campaignItemId, bool noCache)
        {
            return GetCampaignItem(campaignItemId, noCache, false);
        }

        /// <summary>
        ///     Get the campaign item. The cache is not bypassed by default.
        /// </summary>
        /// <param name="campaignItemId">The campaign item identifier</param>
        /// <param name="noCache">Bypass the cache</param>
        /// <param name="refreshCache">Force refresh the cache</param>
        /// <returns>A campaign item</returns>
        public CampaignItem GetCampaignItem(int campaignItemId, bool noCache, bool refreshCache)
        {
            // If no cache the load and return a entity from the database
            if (noCache && !refreshCache)
            {
                return LoadCampaign(campaignItemId);
            }

            CampaignItem campaignItem;

            string cacheKey = CampaignItem.GetCacheKeyById(campaignItemId);

            if (!CacheManagerProvider.GetCacheManagerInstance().Contains<CampaignItem>(cacheKey) || refreshCache)
            {
                // Load the entity from the database
                campaignItem = LoadCampaign(campaignItemId);

                if (campaignItem != null)
                {
                    // Add the entity to the cache by reading caching parameters from the configuration
                    CacheManagerProvider.GetCacheManagerInstance().Insert(cacheKey, campaignItem,
                                                                     ConfigurationManager.GetCacheExpirationByType(
                                                                         campaignItem.GetType()));
                }
            }
            else
            {
                campaignItem = CacheManagerProvider.GetCacheManagerInstance().Get<CampaignItem>(cacheKey);
            }

            return campaignItem;
        }

        /// <summary>
        ///     Load a campaign from the database given its Id.
        /// </summary>
        /// <returns></returns>
        private CampaignItem LoadCampaign(int campaignItemId)
        {
            var campaignItem = new CampaignItem(new CampaignItemEntity(campaignItemId));
           
            return campaignItem;            
        }



        /// <summary>
        /// Create a new campaign item object and persist it into the database.
        /// </summary>
        /// <param name="campaignItem">The campaign item object</param>
        public CampaignItem AddCampaignItem(CampaignItem campaignItem)
        {            
            // Persist the object into the database
            campaignItem.Save();

            // Return the new object with the new identifier (AUTO)
            return campaignItem;
        }
       
        /// <summary>
        /// Update a campaign item object and persist changes into the database
        /// </summary>
        /// <param name="campaignItem"></param>
        public void UpdateCampaignItem(CampaignItem campaignItem)
        {
            // Persist the object into the database
            campaignItem.Save();
        }

        /// <summary>
        /// Delete a campaign object and persist changes into the database
        /// </summary>
        /// <param name="campaignItem"></param>
        public void DeleteCampaignItem(CampaignItem campaignItem)
        {
            // Remove the object into the database
            campaignItem.Delete();
        }
    }
}
