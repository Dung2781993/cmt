using NLog;

namespace C3.Reporting.CMT.Core.Managers.Logging
{
    /// <summary>
    /// Simple Log Manager.
    /// </summary>
    public class LogManager : ILogManager
    {
        private static readonly Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Traces the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Trace(string message)
        {
            Logger.Log(LogLevel.Trace, message);
        }

        /// <summary>
        /// Debugs the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Debug(string message)
        {
            Logger.Log(LogLevel.Debug, message);
        }

        /// <summary>
        /// Logs the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Log(string message) { Logger.Log(LogLevel.Info, message); }

        /// <summary>
        /// Logs the specified log level.
        /// </summary>
        /// <param name="logLevel">The log level.</param>
        /// <param name="message">The message.</param>
        public void Log(LogLevel logLevel, string message)
        {
            Logger.Log(logLevel, message);
        }

        /// <summary>
        /// Logs the exception.
        /// </summary>
        /// <param name="exception">The exception.</param>
        public void LogException(System.Exception exception)
        {
            Logger.LogException(LogLevel.Error, exception.Message, exception);
        }

        /// <summary>
        /// Logs the exception.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        public void LogException(string message, System.Exception exception)
        {
            Logger.LogException(LogLevel.Error, message, exception);
        }

        /// <summary>
        /// Logs the exception.
        /// </summary>
        /// <param name="logLevel">The log level.</param>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        public void LogException(LogLevel logLevel, string message, System.Exception exception)
        {
            Logger.LogException(LogLevel.Error, message, exception);
        }
    }
}
