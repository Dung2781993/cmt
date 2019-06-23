using System.Linq;
using C3.Reporting.CMT.Business.Entities;
using C3.Reporting.CMT.Core.Caching;
using Mecca.CMT.DAL.CollectionClasses;
using Mecca.CMT.DAL.EntityClasses;
using Mecca.CMT.DAL.Linq;
using SD.LLBLGen.Pro.LinqSupportClasses;

namespace C3.Reporting.CMT.Business.Services.Managers
{
    public class RedemptionCodeManager
    {
        /// <summary>
        ///     Get the collection of all redemptionCodes. The cache is enabled by default.
        /// </summary>
        /// <returns></returns>
        public RedemptionCodeSet GetRedemptionCodes()
        {
            return GetRedemptionCodes(false);
        }

        /// <summary>
        ///     Get the collection of all redemptionCodes.
        /// </summary>
        /// <param name="noCache">Bypass the cache</param>
        /// <returns>A set of redemptionCodes</returns>
        public RedemptionCodeSet GetRedemptionCodes(bool noCache)
        {
            return GetRedemptionCodes(noCache, false);
        }

        /// <summary>
        ///     Get the collection of all redemptionCodes.
        /// </summary>
        /// <param name="noCache">Bypass the cache</param>
        /// <param name="refreshCache">Force refresh the cache</param>
        /// <returns>A set of redemptionCodes</returns>
        public RedemptionCodeSet GetRedemptionCodes(bool noCache, bool refreshCache)
        {
            // If no cache the load and return a entity set from the database
            if (noCache && !refreshCache)
            {
                return LoadRedemptionCodeSet();
            }

            RedemptionCodeSet redemptionCodeSet;

            string cacheKey = RedemptionCodeSet.StaticGetCacheKey();

            if (!CacheManagerProvider.GetCacheManagerInstance().Contains<RedemptionCodeSet>(cacheKey) || refreshCache)
            {
                // Load the entity set from the database
                redemptionCodeSet = LoadRedemptionCodeSet();

                if (redemptionCodeSet != null)
                {
                    // Add the entity set to the cache by reading caching parameters from the configuration
                    CacheManagerProvider.GetCacheManagerInstance().Insert(cacheKey, redemptionCodeSet,
                                                                     ConfigurationManager.GetCacheExpirationByType(
                                                                         redemptionCodeSet.GetType()));
                }
            }
            else
            {
                redemptionCodeSet = CacheManagerProvider.GetCacheManagerInstance().Get<RedemptionCodeSet>(cacheKey);
            }

            return redemptionCodeSet;
        }

        /// <summary>
        ///     Load all redemptionCodes from the database.
        /// </summary>
        /// <returns></returns>
        private RedemptionCodeSet LoadRedemptionCodeSet()
        {
            var redemptionCodeSet = new RedemptionCodeSet();

            // Get the collection from the ORM data layer
            var metaData = new LinqMetaData();

            IQueryable<RedemptionCodeEntity> redemptionCodes = from c in metaData.RedemptionCode select c;

            var redemptionCodeCollection = ((ILLBLGenProQuery) redemptionCodes).Execute<RedemptionCodeCollection>();

            // Fill the entity set from the data collection 
            if (redemptionCodeCollection.Count > 0)
            {
                redemptionCodeSet.AddRange(redemptionCodeCollection.Select(entity => new RedemptionCode(entity)));
            }

            // Return the entity set
            return redemptionCodeSet;
        }

        /// <summary>
        ///     Get the current redemptionCode of a redemptionCode. The cache is not bypassed by default.
        /// </summary>
        public RedemptionCode GetRedemptionCode(int redemptionCodeId)
        {
            return GetRedemptionCode(redemptionCodeId, false);
        }

        /// <summary>
        ///     Get the current redemptionCode of a redemptionCode. The cache is not bypassed by default.
        /// </summary>
        /// <param name="redemptionCodeId">The redemptionCode identifier</param>
        /// <param name="noCache">No-Cache parameters</param>
        /// <returns></returns>
        public RedemptionCode GetRedemptionCode(int redemptionCodeId, bool noCache)
        {
            return GetRedemptionCode(redemptionCodeId, noCache, false);
        }

        /// <summary>
        ///     Get the current redemptionCode of a redemptionCode. The cache is not bypassed by default.
        /// </summary>
        /// <param name="redemptionCodeId">The redemptionCode identifier</param>
        /// <param name="noCache">Bypass the cache</param>
        /// <param name="refreshCache">Force refresh the cache</param>
        /// <returns>A redemptionCode</returns>
        public RedemptionCode GetRedemptionCode(int redemptionCodeId, bool noCache, bool refreshCache)
        {
            // If no cache the load and return a entity from the database
            if (noCache && !refreshCache)
            {
                return LoadRedemptionCode(redemptionCodeId);
            }

            RedemptionCode redemptionCode;

            string cacheKey = RedemptionCode.GetCacheKeyById(redemptionCodeId);

            if (!CacheManagerProvider.GetCacheManagerInstance().Contains<RedemptionCode>(cacheKey) || refreshCache)
            {
                // Load the entity from the database
                redemptionCode = LoadRedemptionCode(redemptionCodeId);

                if (redemptionCode != null)
                {
                    // Add the entity to the cache by reading caching parameters from the configuration
                    CacheManagerProvider.GetCacheManagerInstance().Insert(cacheKey, redemptionCode,
                                                                     ConfigurationManager.GetCacheExpirationByType(
                                                                         redemptionCode.GetType()));
                }
            }
            else
            {
                redemptionCode = CacheManagerProvider.GetCacheManagerInstance().Get<RedemptionCode>(cacheKey);
            }

            return redemptionCode;
        }

        /// <summary>
        ///     Load a redemptionCode from the database given its Id.
        /// </summary>
        /// <returns></returns>
        private RedemptionCode LoadRedemptionCode(int redemptionCodeId)
        {
            return new RedemptionCode(new RedemptionCodeEntity(redemptionCodeId));

            //var metaData = new LinqMetaData();

            //IQueryable<RedemptionCodeEntity> redemptionCodes = from c in metaData.RedemptionCode
            //                                      where c.RedemptionCodeId == redemptionCodeId
            //                                      select c;

            //var redemptionCodeCollection = ((ILLBLGenProQuery)redemptionCodes).Execute<RedemptionCodeCollection>();

            //if (redemptionCodeCollection.Count > 0)
            //{
            //    return new RedemptionCode(redemptionCodeCollection[0]);
            //}

            //return null;
        }

        //#region Custom methods

        ///// <summary>
        ///// Get redemptionCode by its name (eg. ).
        ///// </summary>
        ///// <param name="redemptionCodeName">The redemptionCode code</param>
        ///// <returns>The redemptionCode object</returns>
        //public RedemptionCode GetRedemptionCodeByName(string redemptionCodeName)
        //{
        //    RedemptionCode redemptionCode = null;
        //    try
        //    {
        //        // Get an instance of a redemptionCode by its redemptionCode code from the cached collection
        //        redemptionCode = (from c in GetRedemptionCodes()
        //                   where c.RedemptionCodeName.Equals(redemptionCodeName, StringComparison.InvariantCultureIgnoreCase)
        //                   select c).FirstOrDefault();
        //    }
        //    catch (Exception ex)
        //    {
        //        // Exception management
        //        CacheManagerProvider.GetExeptionManagerInstance().HandleException(new RedemptionCodeManagerException(ex));
        //    }
        //    return redemptionCode;
        //}

        //#endregion               
    }
}