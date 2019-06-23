namespace C3.Reporting.CMT.Core.Managers.Exception
{
    interface IExceptionManager
    {
        /// <summary>
        /// Handles the specified System.Exception.
        /// </summary>
        /// <param name="ex">The exception object</param>
        /// <param name="doNotRethrow">Do not rethrow the exception</param>
        void HandleException(System.Exception ex, bool doNotRethrow);

        /// <summary>
        /// Handles the specified System.Exception object.
        /// </summary>
        /// <param name="ex">The exception object</param>
        void HandleException(System.Exception ex);

        /// <summary>
        /// Handles the exception.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        void HandleException(string message, System.Exception exception);

        /// <summary>
        /// Handles the exception.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="doNotRethrow">if set to <c>true</c> [do not rethrow].</param>
        void HandleException(string message, System.Exception exception, bool doNotRethrow);
    }
}
