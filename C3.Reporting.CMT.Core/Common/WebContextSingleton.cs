using System.Web;

namespace C3.Reporting.CMT.Core.Common
{
    public static class WebContextSingleton<T> where T : class, new()
    {
        #region Properties

        /// <summary>
        /// Obtient l'instance du singleton.
        /// </summary>
        /// <value>
        /// L'instance du singleton.
        /// </value>
        public static T Instance
        {
            get
            {
                if(HttpContext.Current == null)
                {
                    return new T();
                }

                if(HttpContext.Current.Items[typeof(T).Name] == null)
                {
                    HttpContext.Current.Items[typeof (T).Name] = new T();
                }

                return HttpContext.Current.Items[typeof(T).Name] as T;
            }
        }

        #endregion
    }
}
