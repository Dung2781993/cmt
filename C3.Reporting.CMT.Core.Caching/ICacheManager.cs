using System;

namespace C3.Reporting.CMT.Core.Caching
{
    public interface ICacheManager
    {
        /// <summary>
        /// Add a new object into the cache
        /// </summary>
        /// <param name="key">The key of the object to add</param>
        /// <param name="value">The value of the object to add</param>
        void Add(string key, object value);

        /// <summary>
        /// Add a new object into the cache
        /// </summary>
        /// <param name="key">The key of the object to add</param>
        /// <param name="value">The value of the object to add</param>
        /// <param name="cacheItemExpiration">The cache expirtation time</param>
        void Add(string key, object value, TimeSpan cacheItemExpiration);

        /// <summary>
        /// Check whether the key is contained by the cache
        /// </summary>
        /// <param name="key">The key to check</param>
        /// <returns>Returns true if the key is contained by the cache</returns>
        bool Contains(string key);
                
        /// <summary>
        /// Get the object that its key is given
        /// </summary>
        /// <typeparam name="T">The object</typeparam>
        /// <param name="key">The given key to check</param>
        /// <returns>returns the object or null if it doesn't exists</returns>
        T Get<T>(string key);

        /// <summary>
        /// Removes the object that is referenced by the given key
        /// </summary>
        /// <param name="key">The given key</param>
        void Remove(string key);
    }
}

