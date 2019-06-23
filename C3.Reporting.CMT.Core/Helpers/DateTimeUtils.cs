using System;

namespace C3.Reporting.CMT.Core.Helpers
{
    public class DateTimeUtils
    {
        #region Date time tools

        /// <summary>
        /// Get day count betewwen two dates.
        /// </summary>
        /// <param name="beginDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        public static int GetDayCount(DateTime beginDate, DateTime endDate)
        {
            // Difference in days, hours, and minutes.
            TimeSpan tSpan = endDate - beginDate;
            
            // Difference in days.
            return tSpan.Days;            
        }

        /// <summary>
        /// Get the first day of the month for
        /// any full date submitted
        /// </summary>
        /// <param name="dtDate"></param>
        /// <returns></returns>
        public static DateTime GetFirstDayOfMonth(DateTime dtDate)
        {
            // set return value to the first day of the month
            // for any date passed in to the method

            // create a datetime variable set to the passed in date
            DateTime dtFrom = dtDate;

            // remove all of the days in the month
            // except the first day and set the
            // variable to hold that date
            dtFrom = dtFrom.AddDays(-(dtFrom.Day - 1));

            // return the first day of the month
            return dtFrom;
        }

        /// <summary>
        /// Get the first day of the month for a
        /// month passed by it's integer value
        /// </summary>
        /// <param name="iMonth"></param>
        /// <returns></returns>
        public static DateTime GetFirstDayOfMonth(int iMonth)
        {
            // set return value to the last day of the month
            // for any date passed in to the method

            // create a datetime variable set to the passed in date
            var dtFrom = new DateTime(DateTime.Now.Year, iMonth, 1);

            // remove all of the days in the month
            // except the first day and set the
            // variable to hold that date
            dtFrom = dtFrom.AddDays(-(dtFrom.Day - 1));

            // return the first day of the month
            return dtFrom;
        }

        /// <summary>
        /// Get the last day of the month for any
        /// full date
        /// </summary>
        /// <param name="dtDate"></param>
        /// <returns></returns>
        public static DateTime GetLastDayOfMonth(DateTime dtDate)
        {
            // set return value to the last day of the month
            // for any date passed in to the method

            // create a datetime variable set to the passed in date
            DateTime dtTo = dtDate;

            // overshoot the date by a month
            dtTo = dtTo.AddMonths(1);

            // remove all of the days in the next month
            // to get bumped down to the last day of the
            // previous month
            dtTo = dtTo.AddDays(-(dtTo.Day));

            // return the last day of the month
            return dtTo;
        }

        /// <summary>
        /// Get the last day of a month expressed by it's
        /// integer value
        /// </summary>
        /// <param name="iMonth"></param>
        /// <returns></returns>
        public static DateTime GetLastDayOfMonth(int iMonth)
        {
            // set return value to the last day of the month
            // for any date passed in to the method

            // create a datetime variable set to the passed in date
            var dtTo = new DateTime(DateTime.Now.Year, iMonth, 1);

            // overshoot the date by a month
            dtTo = dtTo.AddMonths(1);

            // remove all of the days in the next month
            // to get bumped down to the last day of the
            // previous month
            dtTo = dtTo.AddDays(-(dtTo.Day));

            // return the last day of the month
            return dtTo;
        }

        /// <summary>
        /// Get Start today
        /// </summary>
        /// <returns></returns>
        public static DateTime GetStartTodayDateTime()
        {
            DateTime n = DateTime.Now;
            return new DateTime(n.Year, n.Month, n.Day, 0, 0, 0);
        }
        
        /// <summary>
        /// Get End Today datetime
        /// </summary>
        /// <returns></returns>
        public static DateTime GetEndTodayDateTime()
        {            
            DateTime n = DateTime.Now;
            return new DateTime(n.Year, n.Month, n.Day, 23, 59, 59);         
        }
        
        #endregion
    }
}
