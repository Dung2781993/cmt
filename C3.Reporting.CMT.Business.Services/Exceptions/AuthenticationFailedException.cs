using System;
using C3.Reporting.CMT.Core.Exceptions;

namespace C3.Reporting.CMT.Business.Services.Exceptions
{
    public class AuthenticationFailedException : BaseApplicationException
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="innerException">The inner exception</param>
        public AuthenticationFailedException(Exception innerException)
            : base(innerException)
        {
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        public AuthenticationFailedException()
        {
        }
    }
}
