using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace C3.Reporting.CMT.Business.Entities
{
    [Serializable]
    public class BaseEntityCollection<T> : IList<T>
    {
        public BaseEntityCollection()
        {
            _baseEntityList = new List<T>();
        }

        #region IList implementation

        private readonly List<T> _baseEntityList;

        public IEnumerator<T> GetEnumerator()
        {
            return _baseEntityList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(T item)
        {
            _baseEntityList.Add(item);
        }

        public void Clear()
        {
            _baseEntityList.Clear();
        }

        public bool Contains(T item)
        {
            return _baseEntityList.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            _baseEntityList.CopyTo(array, arrayIndex);
        }

        public bool Remove(T item)
        {
            return _baseEntityList.Remove(item);
        }

        public int Count
        {
            get { return _baseEntityList.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public int IndexOf(T item)
        {
            return _baseEntityList.IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            _baseEntityList.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            _baseEntityList.RemoveAt(index);
        }

        public T this[int index]
        {
            get { return _baseEntityList[index]; }
            set { _baseEntityList[index] = value; }
        }

        public void AddRange(IEnumerable<T> list)
        {
            _baseEntityList.AddRange(list);
        }

        public IEnumerable<T> GetRange(int index, int count)
        {
            return _baseEntityList.GetRange(index, count);
        }

        public void Sort(Comparer<T> comparison)
        {
            _baseEntityList.Sort(comparison);
        }

        #endregion

        /// <summary>
        ///     Get the Cache key of an existing instance
        /// </summary>
        /// <returns>Cache key</returns>
        public string GetCacheKey()
        {
            return string.Format("{0}", typeof (T).FullName);
        }

        /// <summary>
        ///     Get the Cache key of an existing instance
        /// </summary>
        /// <param name="name">collection name</param>
        /// <returns>Cache key</returns>
        public static string StaticGetCacheKey(string name)
        {
            return string.Format("{0}Set.{1}", typeof (T).FullName, name);
        }

        /// <summary>
        ///     Get the Cache key of an existing instance
        /// </summary>
        /// <returns>Cache key</returns>
        public static string StaticGetCacheKey()
        {
            return string.Format("{0}Set.All", typeof (T).FullName);
        }

        /// <summary>
        ///  Selector implementation
        /// </summary>
        /// <typeparam name="TJ"></typeparam>
        /// <param name="selector"></param>
        /// <returns></returns>
        public TJ Where<TJ>(Func<T, bool> selector) where TJ : BaseEntityCollection<T>
        {
            IEnumerable<T> list = _baseEntityList.Where(selector);
            var collection = Activator.CreateInstance<TJ>();
            collection.AddRange(list);

            return collection;
        }

        public TJ OfType<TResult, TJ>()
            where TJ : BaseEntityCollection<T>
            where TResult : T
        {
            IEnumerable<TResult> list = OfType<TResult>();
            var collection = Activator.CreateInstance<TJ>();

            foreach (TResult obj in list)
            {
                collection.Add(obj);
            }

            return collection;
        }

        internal IEnumerable<TResult> OfType<TResult>()
        {
            return _baseEntityList.OfType<TResult>();
        }        
    }
}