using System;
using System.Web;
using System.Web.Caching;

namespace C3.Reporting.CMT.Core.Caching.Providers.HttpRunTimeCaching
{
    public class HttpRunTimeCacheManager : ICacheManager
    {
        #region ICacheManager Members

        /// <summary>
        /// Add a new object into the cache
        /// </summary>
        /// <param name="key">The key of the object to add</param>
        /// <param name="value">The value of the object to add</param>
        public void Add(string key, object value)
        {
            HttpRuntime.Cache.Add(key, value, null, Cache.NoAbsoluteExpiration, Cache.NoSlidingExpiration, CacheItemPriority.Normal, null);
        }

        /// <summary>
        /// Add a new object into the cache
        /// </summary>
        /// <param name="key">The key of the object to add</param>
        /// <param name="value">The value of the object to add</param>
        /// <param name="cacheItemExpiration">The cache expirtation time</param>
        public void Add(string key, object value, TimeSpan cacheItemExpiration)
        {
            HttpRuntime.Cache.Add(key, value, null, Cache.NoAbsoluteExpiration, cacheItemExpiration, CacheItemPriority.Normal, null);
        }

        /// <summary>
        /// Check whether the key is contained by the cache
        /// </summary>
        /// <param name="key">The key to check</param>
        /// <returns>
        /// Returns true if the key is contained by the cache
        /// </returns>
        public bool Contains(string key)
        {
            return HttpRuntime.Cache.Get(key) != null;
        }

        /// <summary>
        /// Counts this instance.
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            return HttpRuntime.Cache.Count;
        }

        /// <summary>
        /// Insert a new object into the cache
        /// </summary>
        /// <param name="key">The key of the object to insert</param>
        /// <param name="value">The value of the object to insert</param>
        public void Insert(string key, object value)
        {
            HttpRuntime.Cache.Insert(key, value);
        }

        /// <summary>
        /// Insert a new object into the cache
        /// </summary>
        /// <param name="key">The key of the object to add</param>
        /// <param name="value">The value of the object to add</param>
        /// <param name="cacheItemExpiration">The cache expirtation time</param>
        public void Insert(string key, object value, TimeSpan cacheItemExpiration)
        {
            HttpRuntime.Cache.Insert(key, value, null, Cache.NoAbsoluteExpiration, cacheItemExpiration, CacheItemPriority.Normal, null);
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
            return (T)HttpRuntime.Cache.Get(key);
        }

        /// <summary>
        /// Removes the object that is referenced by the given key
        /// </summary>
        /// <param name="key">The given key</param>
        public void Remove(string key)
        {
            HttpRuntime.Cache.Remove(key);
        }

        /// <summary>
        /// Gets or sets the <see cref="System.Object"/> with the specified key.
        /// </summary>
        public object this[string key]
        {
            get
            {
                return HttpRuntime.Cache[key];
            }
            set
            {
                HttpRuntime.Cache[key] = value;
            }
        }

        #endregion
    }
}
