using NLog;

namespace C3.Reporting.CMT.Core.Managers.Logging
{
    interface ILogManager
    {
        /// <summary>
        /// Traces the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        void Trace(string message);

        /// <summary>
        /// Debugs the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        void Debug(string message);


        /// <summary>
        /// Logs the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        void Log(string message);

        /// <summary>
        /// Logs the specified log level.
        /// </summary>
        /// <param name="logLevel">The log level.</param>
        /// <param name="message">The message.</param>
        void Log(LogLevel logLevel, string message);

        /// <summary>
        /// Logs the exception.
        /// </summary>
        /// <param name="exception">The exception.</param>
        void LogException(System.Exception exception);

        /// <summary>
        /// Logs the exception.
        /// </summary>
        /// <param name="logLevel">The log level.</param>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        void LogException(LogLevel logLevel, string message, System.Exception exception);
    }
}
