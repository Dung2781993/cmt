using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace C3.Reporting.CMT.Core.Common
{
    public static class Extensions
    {
        public static bool PublicInstancePropertiesEqual<T>(this T self, T to, params string[] ignore) where T : class
        {
            if (self != null && to != null)
            {
                var type = typeof(T);
                var ignoreList = new List<string>(ignore);
                var unequalProperties =
                    from pi in type.GetProperties(BindingFlags.Public | BindingFlags.Instance)
                    where !ignoreList.Contains(pi.Name)
                    let selfValue = type.GetProperty(pi.Name).GetValue(self, null)
                    let toValue = type.GetProperty(pi.Name).GetValue(to, null)
                    where selfValue != toValue && (selfValue == null || !selfValue.Equals(toValue))
                    select selfValue;
                return !unequalProperties.Any();
            }
            return self == to;
        }

        public static bool ContainsAll<T>(this IEnumerable<T> source, IEnumerable<T> values)
        {
            return values.All(source.Contains);
        }
        
        public static NameValueCollection ToNameValueCollection(this Dictionary<string, string> dictionary)
        {
            var collection = new NameValueCollection();
            foreach (KeyValuePair<string, string> kvp in dictionary)
            {
                collection.Add(kvp.Key, kvp.Value);
            }
            return collection;
        }

        public static object GetPropertyValue(this object component, string propertyName)
        {
            return TypeDescriptor.GetProperties(component)[propertyName].GetValue(component);
        }

        public static ICollection<T> AddRange<T>(this ICollection<T> source, IEnumerable<T> data)
        {
            foreach (T obj in data)
            {
                source.Add(obj);
            }

            return source;
        }

        public static IList AddRange(this IList source, IEnumerable data)
        {
            foreach (object obj in data)
            {
                source.Add(obj);
            }

            return source;
        }

        public static int IndexOf<T>(this IEnumerable<T> list, Predicate<T> condition)
        {            
            int index = -1;
            return list.Any(item => { index++; return condition(item); }) ? index : -1;
        }

        // Finds an item matching a predicate in the enumeration, much like List<T>.FindIndex()
        public static int FindIndex<T>(this IEnumerable<T> list, Predicate<T> finder)
        {
            int index = 0;
            foreach (var item in list)
            {
                if (finder(item))
                {
                    return index;
                }
  
                index++;
            }
    
            return -1;
        }

        /// <summary>
        /// Get the first day of the month for
        /// any full date submitted
        /// </summary>
        /// <param name="dtDate"></param>
        /// <returns></returns>
        public static DateTime GetFirstDayOfMonth(this DateTime dtDate)
        {
            // set return value to the first day of the month
            // for any date passed in to the method

            // create a datetime variable set to the passed in date
            DateTime dtFrom = dtDate;

            // remove all of the days in the month
            // except the first day and set the
            // variable to hold that date
            dtFrom = dtFrom.AddDays(-(dtFrom.Day - 1));

            // return the first day of the month
            return dtFrom;
        }

        /// <summary>
        /// Get the last day of the month for any
        /// full date
        /// </summary>
        /// <param name="dtDate"></param>
        /// <returns></returns>
        public static DateTime GetLastDayOfMonth(this DateTime dtDate)
        {
            // set return value to the last day of the month
            // for any date passed in to the method

            // create a datetime variable set to the passed in date
            DateTime dtTo = dtDate;

            // overshoot the date by a month
            dtTo = dtTo.AddMonths(1);

            // remove all of the days in the next month
            // to get bumped down to the last day of the
            // previous month
            dtTo = dtTo.AddDays(-(dtTo.Day));

            // return the last day of the month
            return dtTo;
        }


        /// <summary>
        /// Sorts an IList(T) in place.
        /// </summary>
        /// <typeparam name="T">The type of objects the list holds</typeparam>
        /// <param name="list">The list to be sorted</param>
        /// <param name="comparison">A delegate defining how to compare two items in the list</param>
        public static void Sort<T>(this IList<T> list, Comparison<T> comparison)
        {
            ArrayList.Adapter((IList) list).Sort(new ComparisonComparer<T>(comparison));
        }

        /// <summary>
        /// Convenience method on IEnumerable(T) to allow passing of a Comparison delegate
        /// to the OrderBy method.
        /// </summary>
        /// <typeparam name="T">The type of objects the list holds</typeparam>
        /// <param name="list">The list to be sorted</param>
        /// <param name="comparison">A delegate defining how to compare two items in the list</param>
        /// <returns>An IOrderedEnumerable(T)</returns>
        public static IEnumerable<T> OrderBy<T>(this IEnumerable<T> list, Comparison<T> comparison)
        {
            return list.OrderBy(t => t, new ComparisonComparer<T>(comparison));
        }
    }

    /// <summary>
    /// Wraps a generic Comparison(T) delegate in an IComparer to make it easy 
    /// to use a lambda expression for methods that take an IComparer or IComparer(T)
    /// </summary>
    /// <typeparam name="T">The type being compared</typeparam>
    public class ComparisonComparer<T> : IComparer<T>, IComparer
    {
        private readonly Comparison<T> _comparison;

        ///<summary>
        /// Wraps a generic Comparison(T) delegate so that we may easily use a lambda 
        /// expression with methods that accept an IComparer or IComparer(T).
        ///</summary>
        ///<param name="comparison">A delegate that compares two objects of type T</param>
        public ComparisonComparer(Comparison<T> comparison)
        {
            _comparison = comparison;
        }

        #region IComparer Members

        public int Compare(object o1, object o2)
        {
            return _comparison((T) o1, (T) o2);
        }

        #endregion

        #region IComparer<T> Members

        public int Compare(T x, T y)
        {
            return _comparison(x, y);
        }

        #endregion
    }
}