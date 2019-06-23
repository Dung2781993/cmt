using System;
using System.Collections.Specialized;

namespace C3.Reporting.CMT.Core.Caching
{
    /// <summary>
    /// Configuration manager.
    /// </summary>
    public static class ConfigurationManager
    {
        /// <summary>
        /// Returns the configuration value by its key.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetValue(string key)
        {
            return System.Configuration.ConfigurationManager.AppSettings[key];
        }


        /// <summary>
        /// Returns the configuration value by its configs.
        /// </summary>
        /// <param name="section"></param>
        /// <param name="configurationName"></param>
        /// <returns></returns>
        public static string GetConfigValueFromSection(string section, string configurationName)
        {

            NameValueCollection result = (NameValueCollection)System.Configuration.ConfigurationManager.GetSection(section);   
            return result[configurationName];
        }

        /// <summary>
        /// Get the cache expiration time from now from the configuration.
        /// </summary>
        /// <param name="type">The type of the object</param>
        /// <returns>A timespan that represents the time from now of the cache expiration</returns>
        public static TimeSpan GetCacheExpirationByType(Type type)
        {
            var cacheItemExpiration = new TimeSpan(0,0,0);

            if (!Equals(GetValue("CacheEnabled").ToLower(), "true"))
            {
                return cacheItemExpiration;
            }

            string typeDuration = GetValue(String.Concat(type.FullName, ":CacheDuration"));
            if (string.IsNullOrEmpty(typeDuration))
            {
                typeDuration = GetValue("DefaultCacheDuration");
            }

            int duration;
            if (Int32.TryParse(typeDuration, out duration))
            {
                cacheItemExpiration = new TimeSpan(0, 0, duration);
            }
            return cacheItemExpiration;
        }
    }
}