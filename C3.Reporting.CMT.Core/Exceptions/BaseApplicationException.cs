using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace C3.Reporting.CMT.Core.Exceptions
{
    /// <summary>
    /// Base application exception
    /// </summary>
    public abstract class BaseApplicationException : ApplicationException
    {
        private readonly Dictionary<string, string> _parameters = new Dictionary<string, string>();
        private string _uniqueIdentifier = String.Empty;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="innerException">The inner exception</param>
        protected BaseApplicationException(Exception innerException)
            : base(null, innerException)
        {
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        protected BaseApplicationException()
        {
        }

        /// <summary>
        /// Retreive parameters data
        /// </summary>
        private string GetContextualParameterData
        {
            get
            {
                var sbResult = new StringBuilder();
                foreach (var kvp in _parameters)
                {
                    sbResult.Append(String.Format(" {0} : {1} ## ", kvp.Key, kvp.Value));
                }
                return sbResult.ToString();
            }
        }

        /// <summary>
        /// User message code for localization purpose
        /// </summary>
        protected virtual string UserMessageCode
        {
            get { return String.Format("exception.{0}", GetType().FullName); }
        }

        /// <summary>
        /// Generate an unique identifier for the exception
        /// </summary>
        public string UniqueIdentifier
        {
            get
            {
                if (_uniqueIdentifier.Length == 0)
                {
                    _uniqueIdentifier = Guid.NewGuid().ToString();
                }

                return _uniqueIdentifier;
            }
        }

        /// <summary>
        /// Override the stack trace
        /// </summary>
        public override string StackTrace
        {
            get
            {
                var sb = new StringBuilder();

                sb.AppendLine(String.Concat("Unique identifier: ", UniqueIdentifier));
                sb.AppendLine(String.Concat("Contextual data: ", GetContextualParameterData));
                sb.AppendLine(String.Concat("Stack trace: ", base.StackTrace));

                return sb.ToString();
            }
        }

        /// <summary>
        /// Add a contextual parameter to the exception
        /// </summary>
        /// <param name="paramKey">Nom du paramètre</param>
        /// <param name="paramValue">Valeur du paramètre</param>
        public void AddContextualParameter(string paramKey, string paramValue)
        {
            _parameters.Add(paramKey, paramValue);
        }

        /// <summary>
        /// Delete a contextual exception by its key
        /// </summary>
        /// <param name="paramKey">Nom du paramètre</param>
        public void RemoveContextualParameter(string paramKey)
        {
            _parameters.Remove(paramKey);
        }

        /// <summary>
        /// Retrieve the value of the paramter passing its key
        /// </summary>
        /// <param name="key">Key</param>
        /// <returns>Value</returns>
        public string GetContextualParameter(string key)
        {
            string result = String.Empty;
            string value;
            if (!_parameters.TryGetValue(key, out value))
            {
                result = value;
            }
            return result;
        }

        /// <summary>
        /// Retreive the list of all parameters
        /// </summary>
        /// <returns>Parameters Dictionary</returns>
        public Dictionary<string, string> GetContextualParameters()
        {
            return _parameters;
        }

        /// <summary>
        /// Override contextual object information
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            foreach (var kvp in _parameters)
            {
                info.AddValue(kvp.Key, kvp.Value);
            }

            base.GetObjectData(info, context);
        }
    }
}