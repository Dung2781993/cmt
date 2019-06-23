using System.Linq;
using C3.Reporting.CMT.Business.Entities;
using C3.Reporting.CMT.Core.Caching;
using Mecca.CMT.DAL.CollectionClasses;
using SD.LLBLGen.Pro.LinqSupportClasses;
using Mecca.CMT.DAL.Linq;
using Mecca.CMT.DAL.EntityClasses;

namespace C3.Reporting.CMT.Business.Services.Managers
{
    public class CampaignManager
    {
        /// <summary>
        ///     Get the collection of all campaigns. The cache is enabled by default.
        /// </summary>
        /// <returns></returns>
        public CampaignSet GetCampaigns()
        {
            return GetCampaigns(false);
        }

        /// <summary>
        ///     Get the collection of all campaigns.
        /// </summary>
        /// <param name="noCache">Bypass the cache</param>
        /// <returns>A set of campaigns</returns>
        public CampaignSet GetCampaigns(bool noCache)
        {
            return GetCampaigns(noCache, false);
        }

        /// <summary>
        ///     Get the collection of all campaigns.
        /// </summary>
        /// <param name="noCache">Bypass the cache</param>
        /// <param name="refreshCache">Force refresh the cache</param>
        /// <returns>A set of campaigns</returns>
        public CampaignSet GetCampaigns(bool noCache, bool refreshCache)
        {
            // If no cache the load and return a entity set from the database
            if (noCache && !refreshCache)
            {
                return LoadCampaignSet();
            }

            CampaignSet campaignSet;

            string cacheKey = CampaignSet.StaticGetCacheKey();

            if (!CacheManagerProvider.GetCacheManagerInstance().Contains<CampaignSet>(cacheKey) || refreshCache)
            {
                // Load the entity set from the database
                campaignSet = LoadCampaignSet();

                if (campaignSet != null)
                {
                    // Add the entity set to the cache by reading caching parameters from the configuration
                    CacheManagerProvider.GetCacheManagerInstance().Insert(cacheKey, campaignSet,
                                                                     ConfigurationManager.GetCacheExpirationByType(
                                                                         campaignSet.GetType()));
                }
            }
            else
            {
                campaignSet = CacheManagerProvider.GetCacheManagerInstance().Get<CampaignSet>(cacheKey);
            }

            return campaignSet;
        }

        /// <summary>
        ///     Load all campaigns from the database.
        /// </summary>
        /// <returns></returns>
        private CampaignSet LoadCampaignSet()
        {
            var campaignSet = new CampaignSet();

            // Get the collection from the ORM data layer
            var metaData = new LinqMetaData();

            IQueryable<CampaignEntity> campaigns = from c in metaData.Campaign select c;

            var campaignCollection = ((ILLBLGenProQuery)campaigns).Execute<CampaignCollection>();

            // Fill the entity set from the data collection 
            if (campaignCollection.Count > 0)
            {
                foreach (var campaignEntity in campaignCollection)
                {
                    var campaign = new Campaign(campaignEntity);
                    campaign.CampaignType = ServiceManagerProvider.GetCampaignTypeManager().GetCampaignType(campaign.CampaignTypeId);
                    campaign.RedemptionCode = ServiceManagerProvider.GetRedemptionCodeManager().GetRedemptionCode(campaign.RedemptionCodeId);

                    campaignSet.Add(campaign);
                }
            }

            // Return the entity set
            return campaignSet;
        }

        /// <summary>
        ///     Get the current campaign of a campaign. The cache is not bypassed by default.
        /// </summary>
        public Campaign GetCampaign(int campaignId)
        {
            return GetCampaign(campaignId, false);
        }

        /// <summary>
        ///     Get the current campaign of a campaign. The cache is not bypassed by default.
        /// </summary>
        /// <param name="campaignId">The campaign identifier</param>
        /// <param name="noCache">No-Cache parameters</param>
        /// <returns></returns>
        public Campaign GetCampaign(int campaignId, bool noCache)
        {
            return GetCampaign(campaignId, noCache, false);
        }

        /// <summary>
        ///     Get the current campaign of a campaign. The cache is not bypassed by default.
        /// </summary>
        /// <param name="campaignId">The campaign identifier</param>
        /// <param name="noCache">Bypass the cache</param>
        /// <param name="refreshCache">Force refresh the cache</param>
        /// <returns>A campaign</returns>
        public Campaign GetCampaign(int campaignId, bool noCache, bool refreshCache)
        {
            // If no cache the load and return a entity from the database
            if (noCache && !refreshCache)
            {
                return LoadCampaign(campaignId);
            }

            Campaign campaign;

            string cacheKey = Campaign.GetCacheKeyById(campaignId);

            if (!CacheManagerProvider.GetCacheManagerInstance().Contains<Campaign>(cacheKey) || refreshCache)
            {
                // Load the entity from the database
                campaign = LoadCampaign(campaignId);

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
                campaign = CacheManagerProvider.GetCacheManagerInstance().Get<Campaign>(cacheKey);
            }

            return campaign;
        }

        /// <summary>
        ///     Load a campaign from the database given its Id.
        /// </summary>
        /// <returns></returns>
        private Campaign LoadCampaign(int campaignId)
        {
            var campaign = new Campaign(new CampaignEntity(campaignId));
            campaign.CampaignType = ServiceManagerProvider.GetCampaignTypeManager().GetCampaignType(campaign.CampaignTypeId);
            campaign.RedemptionCode = ServiceManagerProvider.GetRedemptionCodeManager().GetRedemptionCode(campaign.RedemptionCodeId);
            return campaign;            
        }        

        /// <summary>
        /// Create a new campaign object and persist it into the database.
        /// </summary>
        /// <param name="campaign">The campaign object</param>
        public Campaign AddCampaign(Campaign campaign)
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
        public void UpdateCampaign(Campaign campaign)
        {
            // Persist the object into the database
            campaign.Save();
        }

        /// <summary>
        /// Delete a campaign object and persist changes into the database
        /// </summary>
        /// <param name="campaign"></param>
        public void DeleteCampaign(Campaign campaign)
        {
            // Remove the object into the database
            campaign.Delete();
        }
    }
}
