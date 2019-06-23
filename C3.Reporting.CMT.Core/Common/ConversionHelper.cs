using System;

namespace C3.Reporting.CMT.Core.Common
{
    public static class ConversionHelper
    {
        public const string LongDateTimeFormat = "dd MMMM yyyy hh:mm:ss";
        public const string LongDateFormat = "dd MMMM yyyy";
        public const string ShortDateFormat = "dd-MM-yyyy";
        public const string ShortDateTimeFormat = "dd-MM-yyyy hh:mm";

        public const string SqlMinTime = "00:00";
        public const string SqlMaxTime = "23:59";
        public static DateTime SqlMinDateTime = new DateTime(1990, 1, 1);
        public static DateTime SqlMaxDateTime = new DateTime(9000, 1, 1);

       /// <summary>
        /// Parse SQL DATE TIME
       /// </summary>
       /// <param name="value"></param>
       /// <returns></returns>
        public static DateTime ParseSqlDateTime(string value)
        {
            return ParseSqlDateTime(value, SqlMinDateTime);
        }

        /// <summary>
        /// Parse SQL DATE TIME
        /// </summary>
        /// <param name="value"></param>
        /// <param name="defaultDate"></param>
        /// <returns></returns>
        public static DateTime ParseSqlDateTime(string value, DateTime defaultDate)
        {
            DateTime dt = defaultDate;

            value = value.Trim();
            try
            {
                if (value != "")
                {
                    dt = DateTime.Parse(value);
                }
            }
            catch (Exception)
            {
            }

            return dt;
        }
    }
}
