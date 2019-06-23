using System.Collections.Generic;
using System.Linq;
using C3.Reporting.CMT.Business.Entities;
using C3.Reporting.CMT.Core.Caching;
using Mecca.CMT.DAL.CollectionClasses;
using Mecca.CMT.DAL.EntityClasses;
using Mecca.CMT.DAL.Linq;
using SD.LLBLGen.Pro.LinqSupportClasses;

namespace C3.Reporting.CMT.Business.Services.Managers
{
    public class ChannelCustomerManager
    {
        /// <summary>
        ///     Get the collection of all channelCustomers. The cache is enabled by default.
        /// </summary>
        /// <returns></returns>
        public ChannelCustomerSet GetChannelCustomers()
        {
            return GetChannelCustomers(false);
        }

        /// <summary>
        ///     Get the collection of all channelCustomers.
        /// </summary>
        /// <param name="noCache">Bypass the cache</param>
        /// <returns>A set of channelCustomers</returns>
        public ChannelCustomerSet GetChannelCustomers(bool noCache)
        {
            return GetChannelCustomers(noCache, false);
        }

        /// <summary>
        ///     Get the collection of all channelCustomers.
        /// </summary>
        /// <param name="noCache">Bypass the cache</param>
        /// <param name="refreshCache">Force refresh the cache</param>
        /// <returns>A set of channelCustomers</returns>
        public ChannelCustomerSet GetChannelCustomers(bool noCache, bool refreshCache)
        {
            // If no cache the load and return a entity set from the database
            if (noCache && !refreshCache)
            {
                return LoadChannelCustomerSet();
            }

            ChannelCustomerSet channelCustomerSet;

            string cacheKey = ChannelCustomerSet.StaticGetCacheKey();

            if (!CacheManagerProvider.GetCacheManagerInstance().Contains<ChannelCustomerSet>(cacheKey) || refreshCache)
            {
                // Load the entity set from the database
                channelCustomerSet = LoadChannelCustomerSet();

                if (channelCustomerSet != null)
                {
                    // Add the entity set to the cache by reading caching parameters from the configuration
                    CacheManagerProvider.GetCacheManagerInstance().Insert(cacheKey, channelCustomerSet,
                                                                     ConfigurationManager.GetCacheExpirationByType(
                                                                         channelCustomerSet.GetType()));
                }
            }
            else
            {
                channelCustomerSet = CacheManagerProvider.GetCacheManagerInstance().Get<ChannelCustomerSet>(cacheKey);
            }

            return channelCustomerSet;
        }

        /// <summary>
        ///     Load all channelCustomers from the database.
        /// </summary>
        /// <returns></returns>
        private ChannelCustomerSet LoadChannelCustomerSet()
        {
            var channelCustomerSet = new ChannelCustomerSet();

            // Get the collection from the ORM data layer
            var metaData = new LinqMetaData();

            IQueryable<ChannelCustomerEntity> channelCustomers = from c in metaData.ChannelCustomer select c;

            var channelCustomerCollection = ((ILLBLGenProQuery)channelCustomers).Execute<ChannelCustomerCollection>();

            // Fill the entity set from the data collection 
            if (channelCustomerCollection.Count > 0)
            {
                foreach (var channelCustomerEntity in channelCustomerCollection)
                {
                    var channelCustomer = new ChannelCustomer(channelCustomerEntity);
                    channelCustomerSet.Add(channelCustomer);
                }
            }

            // Return the entity set
            return channelCustomerSet;
        }

        /// <summary>
        ///     Get the current channelCustomer of a channelCustomer. The cache is not bypassed by default.
        /// </summary>
        public ChannelCustomer GetChannelCustomer(int channelCustomerId)
        {
            return GetChannelCustomer(channelCustomerId, false);
        }

        /// <summary>
        ///     Get the current channelCustomer of a channelCustomer. The cache is not bypassed by default.
        /// </summary>
        /// <param name="channelCustomerId">The channelCustomer identifier</param>
        /// <param name="noCache">No-Cache parameters</param>
        /// <returns></returns>
        public ChannelCustomer GetChannelCustomer(int channelCustomerId, bool noCache)
        {
            return GetChannelCustomer(channelCustomerId, noCache, false);
        }

        /// <summary>
        ///     Get the current channelCustomer of a channelCustomer. The cache is not bypassed by default.
        /// </summary>
        /// <param name="channelCustomerId">The channelCustomer identifier</param>
        /// <param name="noCache">Bypass the cache</param>
        /// <param name="refreshCache">Force refresh the cache</param>
        /// <returns>A channelCustomer</returns>
        public ChannelCustomer GetChannelCustomer(int channelCustomerId, bool noCache, bool refreshCache)
        {
            // If no cache the load and return a entity from the database
            if (noCache && !refreshCache)
            {
                return LoadChannelCustomer(channelCustomerId);
            }

            ChannelCustomer channelCustomer;

            string cacheKey = ChannelCustomer.GetCacheKeyById(channelCustomerId);

            if (!CacheManagerProvider.GetCacheManagerInstance().Contains<ChannelCustomer>(cacheKey) || refreshCache)
            {
                // Load the entity from the database
                channelCustomer = LoadChannelCustomer(channelCustomerId);

                if (channelCustomer != null)
                {
                    // Add the entity to the cache by reading caching parameters from the configuration
                    CacheManagerProvider.GetCacheManagerInstance().Insert(cacheKey, channelCustomer,
                                                                     ConfigurationManager.GetCacheExpirationByType(
                                                                         channelCustomer.GetType()));
                }
            }
            else
            {
                channelCustomer = CacheManagerProvider.GetCacheManagerInstance().Get<ChannelCustomer>(cacheKey);
            }

            return channelCustomer;
        }

        /// <summary>
        ///     Load a channelCustomer from the database given its Id.
        /// </summary>
        /// <returns></returns>
        private ChannelCustomer LoadChannelCustomer(int channelCustomerId)
        {
            var channelCustomer = new ChannelCustomer(new ChannelCustomerEntity(channelCustomerId));
            return channelCustomer;
        }


        /// <summary>
        ///     Get the currents of a channel. The cache is not bypassed by default.
        /// </summary>
        /// <param name="channelId">The channelCustomer identifier</param>
        public ChannelCustomerSet GetChannelCustomerByChannelId(int channelId)
        {
            return GetChannelCustomerByChannelId(channelId, false);
        }

        /// <summary>
        ///           Get the currents of a channel. The cache is not bypassed by default.
        /// </summary>
        /// <param name="channelId">The channelCustomer identifier</param>
        /// <param name="noCache">No-Cache parameters</param>
        /// <returns></returns>
        public ChannelCustomerSet GetChannelCustomerByChannelId(int channelId, bool noCache)
        {
            return GetChannelCustomerByChannelId(channelId, noCache, false);
        }

        /// <summary>
        ///          Get the currents of a channel. The cache is not bypassed by default.
        /// </summary>
        /// <param name="channelId">The channelCustomer identifier</param>
        /// <param name="noCache">Bypass the cache</param>
        /// <param name="refreshCache">Force refresh the cache</param>
        /// <returns>A channelCustomer</returns>
        public ChannelCustomerSet GetChannelCustomerByChannelId(int channelId, bool noCache, bool refreshCache)
        {
            // If no cache the load and return a entity from the database
            if (noCache && !refreshCache)
            {
                return LoadChannelCustomerByChannelId(channelId);
            }
            ChannelCustomerSet channelCustomerSet;

            var cacheKey = ChannelCustomerSet.StaticGetCacheKey();

            if (!CacheManagerProvider.GetCacheManagerInstance().Contains<ChannelCustomerSet>(cacheKey) || refreshCache)
            {
                // Load the entity set from the database
                channelCustomerSet = LoadChannelCustomerByChannelId(channelId);

                if (channelCustomerSet != null)
                {
                    // Add the entity set to the cache by reading caching parameters from the configuration
                    CacheManagerProvider.GetCacheManagerInstance().Insert(cacheKey, channelCustomerSet,
                        ConfigurationManager.GetCacheExpirationByType(
                            channelCustomerSet.GetType()));
                }
            }
            else
            {
                channelCustomerSet = CacheManagerProvider.GetCacheManagerInstance().Get<ChannelCustomerSet>(cacheKey);
            }

            return channelCustomerSet;
        }


        /// <summary>
        ///     Load a channelCustomer from the database given its Id.
        /// </summary>
        /// <param name="channelId">The channelCustomer identifier</param>
        /// <returns></returns>
        public ChannelCustomerSet LoadChannelCustomerByChannelId(int channelId)
        {
            var metaData = new LinqMetaData();
            var channelCustomer = metaData.ChannelCustomer.Where(e => e.ChannelId == channelId);
            var customerCollection = ((ILLBLGenProQuery)channelCustomer).Execute<ChannelCustomerCollection>();

            var channelCustomerSet = new ChannelCustomerSet();
            // Fill the entity set from the data collection
            if (customerCollection.Count > 0)
            {
                foreach (var customerEntity in customerCollection)
                {
                    var customer = new ChannelCustomer(customerEntity);

                    channelCustomerSet.Add(customer);
                }
            }
            // Return the entity set
            return channelCustomerSet;
        }

        /// <summary>
        /// Create a new channelCustomer object and persist it into the database.
        /// </summary>
        /// <param name="channelCustomer">The channelCustomer object</param>
        public ChannelCustomer AddChannelCustomer(ChannelCustomer channelCustomer)
        {
            // Persist the object into the database
            channelCustomer.Save();

            // Return the new object with the new identifier (AUTO)
            return channelCustomer;
        }

        /// <summary>
        /// Update a channelCustomer object and persist changes into the database
        /// </summary>
        /// <param name="channelCustomer"></param>
        public void UpdateChannelCustomer(ChannelCustomer channelCustomer)
        {
            // Persist the object into the database
            channelCustomer.Save();
        }

        /// <summary>
        /// Delete a channelCustomer object and persist changes into the database
        /// </summary>
        /// <param name="channelCustomer"></param>
        public void DeleteChannelCustomer(ChannelCustomer channelCustomer)
        {
            // Remove the object into the database
            channelCustomer.Delete();
        }
    }
}
