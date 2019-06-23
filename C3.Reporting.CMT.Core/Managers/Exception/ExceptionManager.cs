namespace C3.Reporting.CMT.Core.Managers.Exception
{
    public class ExceptionManager : IExceptionManager
    {
        /// <summary>
        /// Handles the specified System.Exception.
        /// </summary>
        /// <param name="exception">The exception object</param>
        /// <param name="doNotRethrow">Do not rethrow the exception</param>
        public void HandleException(System.Exception exception, bool doNotRethrow)
        {
            ManagerProvider.GetLogManagerInstance().LogException(exception);
            if (!doNotRethrow)
            {
                throw exception;
            }
        }

        /// <summary>
        /// Handles the specified System.Exception object.
        /// </summary>
        /// <param name="exception">The exception object</param>
        public void HandleException(System.Exception exception)
        {
            ManagerProvider.GetLogManagerInstance().LogException(exception);
            throw exception;       
        }


        /// <summary>
        /// Handles the exception.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        public void HandleException(string message, System.Exception exception)
        {
            ManagerProvider.GetLogManagerInstance().LogException(message, exception);
            throw exception;
        }


        /// <summary>
        /// Handles the exception.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="doNotRethrow">if set to <c>true</c> [do not rethrow].</param>
        public void HandleException(string message, System.Exception exception, bool doNotRethrow)
        {
            ManagerProvider.GetLogManagerInstance().LogException(message, exception);
            if (!doNotRethrow)
            {
                throw exception;
            }
        }
    }
}
