namespace C3.Reporting.CMT.Core.Caching.Common
{
    /// <summary>
    /// Fournit un point d'accès global pour accéder à une instance unique 
    /// d'une classe.
    /// </summary>
    /// <typeparam name="T">
    /// Le type de l'objet singleton.
    /// </typeparam>
    /// <example>
    /// L'exemple suivant illustre l'utilisation d'un singleton de type 
    /// <see cref="System.Collections.ArrayList"/>.
    /// <code lang="C#">
    /// class SampleSingleton
    /// {
    ///     public static void Main()
    ///     {
    ///         ArrayList al = Singleton&lt;ArrayList&gt;.Instance;
    ///         al.Add("data1");
    ///         al.Add("data2");
    /// 
    ///         PrintValues();
    ///     }
    /// 
    ///     public static void PrintValues()
    ///     {
    ///         foreach (string s in Singleton&lt;ArrayList&gt;.Instance)
    ///         {
    ///             Console.WriteLine(s);
    ///         }
    ///     }
    /// }
    /// </code>
    /// </example>
    public static class Singleton<T> where T : new()
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
            get { return SingletonInternal.instance; }
        }

        #endregion

        #region Nested Types

        /// <summary>
        /// L'objet singleton interne.
        /// </summary>
        private sealed class SingletonInternal
        {
            #region Fields

            /// <summary>
            /// L'instance du singleton.
            /// </summary>
            internal static readonly T instance = new T();

            #endregion

            #region Constructors

            #endregion
        }

        #endregion
    }
}