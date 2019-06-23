using C3.Reporting.CMT.Core.Common;
using C3.Reporting.CMT.Core.Managers.Exception;
using C3.Reporting.CMT.Core.Managers.Logging;

namespace C3.Reporting.CMT.Core.Managers
{
    /// <summary>
    /// This class is use to provide single instance of managers (caching, exception management, logging, etc.)
    /// </summary>
    public static class ManagerProvider
    {
        /// <summary>
        /// Singleton implementation of the log manager.
        /// </summary>
        /// <returns></returns>
        public static LogManager GetLogManagerInstance()
        {
            return Singleton<LogManager>.Instance;
        }

        /// <summary>
        /// Singleton implementation of the exception manager.
        /// </summary>
        /// <returns></returns>
        public static ExceptionManager GetExeptionManagerInstance()
        {
            return Singleton<ExceptionManager>.Instance;
        }               
    }
}
