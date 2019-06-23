using System;
using System.Reflection;
using C3.Reporting.CMT.Core.Caching;
using Mecca.CMT.DAL.EntityClasses;

namespace C3.Reporting.CMT.Business.Entities
{
    /// <summary>
    ///     Base class for entities.
    /// </summary>
    /// <typeparam name="T">This type</typeparam>
    /// <typeparam name="TJ">Entity type</typeparam>
    [Serializable]
    public class BaseDataEntity<T, TJ> : BaseEntity<T> where TJ : CommonEntityBase
    {
        private static PropertyInfo _propertyId;
        protected TJ _entity;

        public BaseDataEntity(TJ entity)
        {
            _entity = entity;
        }

        public BaseDataEntity()
        {
            _entity = Activator.CreateInstance<TJ>();
        }

        /// <summary>
        ///     Get the object identifier
        /// </summary>
        public override int GetObjectId
        {
            get
            {
                if (_propertyId == null)
                {
                    // Object identifier must be suffixed by <ClassName> + Id, ex. Hotel => HotelId
                    _propertyId = _entity.GetType().GetProperty(string.Format("{0}Id", GetType().Name));
                }

                return (int) _propertyId.GetValue(_entity, null);
            }
        }

        public TJ BaseEntity()
        {
            return _entity;
        }

        /// <summary>
        ///     Insert or update the entity in the database, recursive save is desabled.
        ///     The entity object instance is removed from the cache by default.
        /// </summary>
        public void Save()
        {
            Save(false);
        }
        
        /// <summary>
        ///     Remove entity from the cache.
        /// </summary>
        public void Refresh()
        {
            // Remove entity of the cache           
            string cacheKey = GetCacheKey();
            if (CacheManagerProvider.GetCacheManagerInstance().Contains<T>(cacheKey))
            {
                CacheManagerProvider.GetCacheManagerInstance().Remove(cacheKey, this);
            }
        }

        /// <summary>
    ///     Insert or update the entity in the database, recursive saving is disabled.
    ///     The entity object instance is removed from the cache by default.
    ///     WARNING: If the the cache check is bypassed for a performance goal, the entity is NOT refreshed in the cache.
        /// </summary>       
        /// <param name="bypassCacheCheck">Bypassed cache check.</param>
        public void Save(bool bypassCacheCheck)
        {           
            // Persist the entity in the database
            _entity.Save(false);

            if (!bypassCacheCheck)
            {
                // Remove entity from the cache
                Refresh();
            }
        }

        /// <summary>
        ///     Delete the entity in the database, restriction delete is disabled.
        ///     The entity object instance is removed from the cache by default.
        /// </summary>
        public void Delete()
        {
            // Remove the entity in the database
            Delete(false);
        }

        /// <summary>
        ///     Delete the entity in the database, restriction delete is disabled.
        ///     The entity object instance is removed from the cache by default.
        /// </summary>
        public void Delete(bool bypassCacheCheck)
        {
            if (!bypassCacheCheck)
            {
                // Remove entity from the cache
                Refresh();
            }
            
            _entity.Delete();            
        }
    }
}