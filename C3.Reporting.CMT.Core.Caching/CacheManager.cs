using System;
using System.Web;
using System.Web.Caching;

namespace C3.Reporting.CMT.Core.Caching
{
    public class CacheManager
    {
        /// <summary>
        /// Add a new object into the cache
        /// </summary>
        /// <param name="key">The key of the object to add</param>
        /// <param name="value">The value of the object to add</param>
        public void Add(string key, object value)
        {
            HttpRuntime.Cache.Add(key, value, null, Cache.NoAbsoluteExpiration, Cache.NoSlidingExpiration,
                                  CacheItemPriority.Normal, null);
        }

        /// <summary>
        /// Add a new object into the cache
        /// </summary>
        /// <param name="key">The key of the object to add</param>
        /// <param name="value">The value of the object to add</param>
        /// <param name="cacheItemExpiration">The cache expirtation time</param>
        public void Insert(string key, object value, TimeSpan cacheItemExpiration)
        {
            // Check if the TimeSpan is not equals to zero            
            if (cacheItemExpiration.Ticks > 0)
            {
                CacheManagerProvider.GetHttpRunTimeCacheManagerInstance().Insert(key, value, cacheItemExpiration);
            }
        }

        /// <summary>
        /// Add a new object into the cache. Only for HttpRuntime cache.
        /// </summary>
        /// <param name="key">The key of the object to add</param>
        /// <param name="value">The value of the object to add</param>
        /// <param name="cacheDependency">The cache dependency object</param>
        public void Insert(string key, object value, CacheDependency cacheDependency)
        {
            HttpRuntime.Cache.Insert(key, value, cacheDependency, Cache.NoAbsoluteExpiration, Cache.NoSlidingExpiration);
        }

        /// <summary>
        /// Add a new object into the cache using the SQL cache dependency. Only for HttpRuntime cache.
        /// </summary>
        /// <param name="key">The key of the object to add</param>
        /// <param name="value">The value of the object to add</param>
        /// <param name="databaseEntryName">The database entry name</param>
        /// /// <param name="tableName">The table name</param>
        public void Insert(string key, object value, string databaseEntryName, string tableName)
        {
            // Add the SqlCacheDependency objects for Products
            var objectTableDependency = new SqlCacheDependency(databaseEntryName, tableName);

            // Add the item to the data cache using productsTableDependency
            HttpRuntime.Cache.Insert(key, value, objectTableDependency, Cache.NoAbsoluteExpiration, Cache.NoSlidingExpiration);
        }

        /// <summary>
        /// Add a new object into the cache
        /// </summary>
        /// <param name="key">The key of the object to add</param>
        /// <param name="value">The value of the object to add</param>
        /// <param name="cacheItemExpiration">The cache expirtation time</param>
        public void Add(string key, object value, TimeSpan cacheItemExpiration)
        {
            // Check if the TimeSpan is not equals to zero            
            if (cacheItemExpiration.Ticks > 0)
            {
                string cacheManagerName =
                    System.Configuration.ConfigurationManager.AppSettings[String.Concat(value.GetType().FullName, ":CacheManagerName")];

                if (cacheManagerName == null)
                {
                    // If there is on setting for this object, the default CacheManager is applied (HttpRunTime.Cache)
                    CacheManagerProvider.GetHttpRunTimeCacheManagerInstance().Add(key, value, cacheItemExpiration);
                }
                else
                {
                    //if (cacheManagerName.Equals("AppFabric"))
                    //{
                    //    new AppFabricCacheManager().Add(key, value, cacheItemExpiration);
                    //}
                    //else
                    //{
                        CacheManagerProvider.GetHttpRunTimeCacheManagerInstance().Add(key, value, cacheItemExpiration);
                    //}
                }
            }
        }

        /// <summary>
        /// Check whether the key is contained by the cache
        /// </summary>
        /// <param name="key">The key to check</param>
        /// <returns>
        /// Returns true if the key is contained by the cache
        /// </returns>
        public bool Contains<T>(string key)
        {
            //string cacheManagerName = System.Configuration.ConfigurationManager.AppSettings[String.Concat(typeof(T).FullName, ":CacheManagerName")];
            //if (cacheManagerName.Equals("AppFabric")) return new AppFabricCacheManager().Contains(key);
            return CacheManagerProvider.GetHttpRunTimeCacheManagerInstance().Contains(key);
        }

        /// <summary>
        /// Get the object that its key is given
        /// </summary>
        /// <typeparam name="T">The object</typeparam>
        /// <param name="key">The given key to check</param>
        /// <returns>
        /// returns the object or null if it doesn't exists
        /// </returns>
        public T Get<T>(string key)
        {
            //string cacheManagerName = System.Configuration.ConfigurationManager.AppSettings[String.Concat(typeof(T).FullName, ":CacheManagerName")];
            return CacheManagerProvider.GetHttpRunTimeCacheManagerInstance().Get<T>(key);
        }

        /// <summary>
        /// Removes the specified key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        public void Remove(string key, object value)
        {
            string cacheManagerName = System.Configuration.ConfigurationManager.AppSettings[String.Concat(value.GetType().FullName, ":CacheManagerName")];
            //if (cacheManagerName.Equals("AppFabric"))
            //{
            //    new AppFabricCacheManager().Remove(key);
            //}
            //else
            //{
                CacheManagerProvider.GetHttpRunTimeCacheManagerInstance().Remove(key);
            //}
        }
    }
}