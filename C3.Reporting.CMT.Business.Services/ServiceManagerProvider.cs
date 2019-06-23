using C3.Reporting.CMT.Business.Services.Managers;
using C3.Reporting.CMT.Core.Caching.Common;

namespace C3.Reporting.CMT.Business.Services
{
    public static class ServiceManagerProvider
    {
        public static CampaignManager GetCampaignManager()
        {
            return Singleton<CampaignManager>.Instance;
        }

        public static CampaignTypeManager GetCampaignTypeManager()
        {
            return Singleton<CampaignTypeManager>.Instance;
        }

        public static RedemptionCodeManager GetRedemptionCodeManager()
        {
            return Singleton<RedemptionCodeManager>.Instance;
        }

        public static ChannelManager GetChannelManager()
        {
            return Singleton<ChannelManager>.Instance;
        }

        public static CampaignOwnerManager GetCampaignOwnerManager()
        {
            return Singleton<CampaignOwnerManager>.Instance;
        }

        public static ChannelTypeManager GetChannelTypeManager()
        {
            return Singleton<ChannelTypeManager>.Instance;
        }

        public static ChannelOwnerManager GetChannelOwnerManager()
        {
            return Singleton<ChannelOwnerManager>.Instance;
        }

        public static ChannelCustomerManager GetChannelCustomerManager()
        {
            return Singleton<ChannelCustomerManager>.Instance;
        }

        public static CampaignItemManager GetCampaignItemManager()
        {
            return Singleton<CampaignItemManager>.Instance;
        }

        public static ProductItemManager GetProductItemManager()
        {
            return Singleton<ProductItemManager>.Instance;
        }

        public static ChannelItemManager GetChannelItemManager()
        {
            return Singleton<ChannelItemManager>.Instance;
        }

        public static StoreOptionManager GetStoreOptionManager()
        {
            return Singleton<StoreOptionManager>.Instance;
        }
        public static StoreManager GetStoreManager()
        {
            return Singleton<StoreManager>.Instance;
        }

        public static CampaignStoreManager GetCampaignStoreManager()
        {
            return Singleton<CampaignStoreManager>.Instance;
        }

        public static ChannelStoreManager GetChannelStoreManager()
        {
            return Singleton<ChannelStoreManager>.Instance;
        }
    }
}

