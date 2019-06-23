using System;
using System.Configuration;

namespace C3.Reporting.CMT.Business.Entities
{
    /// <summary>
    ///     Base class for entities
    /// </summary>
    /// <typeparam name="T">Entity type</typeparam>
    [Serializable]
    public abstract class BaseEntity<T>
    {
        /// <summary>
        ///     Get the object identifier
        /// </summary>
        public abstract int GetObjectId { get; }

        /// <summary>
        ///     Get the cache key of an existing instance by its identifier.
        /// </summary>
        /// <returns>The cache key</returns>
        public string GetCacheKey()
        {
            return String.Concat(GetType().FullName, GetObjectId);
        }

        /// <summary>
        ///     Get the cache key of an existing instance by its identifier.
        /// </summary>
        /// <returns>The cache key</returns>
        public string GetCacheManagerName()
        {
            return ConfigurationManager.AppSettings[String.Concat(GetType().FullName, ":CacheManagerName")];
        }

        /// <summary>
        ///     Get a custom the cache key passing a string as suffix.
        /// </summary>
        /// <returns>The concatened cache key</returns>
        public static string GetCustomCacheKey(string suffix)
        {
            return String.Concat(typeof (T).FullName, suffix);
        }

        /// <summary>
        ///     Get the cache key without existing instance by its identifier
        /// </summary>
        /// <param name="id">The object identifier</param>
        /// <returns>The cache key</returns>
        public static string GetCacheKeyById(decimal id)
        {
            return String.Concat(typeof (T).FullName, id);
        }
    }
}