using C3.Reporting.CMT.Core.Caching.Common;
using C3.Reporting.CMT.Core.Caching.Providers.HttpRunTimeCaching;

namespace C3.Reporting.CMT.Core.Caching
{
    /// <summary>
    /// This class is use to provide single instance of managers (caching, exception management, logging, etc.)
    /// </summary>
    public static class CacheManagerProvider
    {
        
        /// <summary>
        /// Singleton implementation of the cache manager.
        /// </summary>
        /// <returns></returns>
        public static CacheManager GetCacheManagerInstance()
        {
            return Singleton<CacheManager>.Instance;
        }

        ///// <summary>
        ///// Singleton implementation of the AppFabric cache manager.
        ///// </summary>
        ///// <returns></returns>
        //public static AppFabricCacheManager GetAppFabricCacheManagerInstance()
        //{
        //    return Singleton<AppFabricCacheManager>.Instance;
        //}

        /// <summary>
        /// Singleton implementation of the HttpRunTime cache manager.
        /// </summary>
        /// <returns></returns>
        public static HttpRunTimeCacheManager GetHttpRunTimeCacheManagerInstance()
        {
            return Singleton<HttpRunTimeCacheManager>.Instance;
        }
    }
}
