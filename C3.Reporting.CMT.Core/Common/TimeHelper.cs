using System;

namespace C3.Reporting.CMT.Core.Common
{
    public static class TimeHelper
    {
        public static TimeSpan GetDuration(string units, string numUnits)
        {
            TimeSpan timeSpanInterval;
            switch (units)
            {
                case "seconds":
                    timeSpanInterval = new TimeSpan(0, 0, 0, int.Parse(numUnits));
                    break;
                case "minutes":
                    timeSpanInterval = new TimeSpan(0, 0, int.Parse(numUnits), 0);
                    break;
                case "hours":
                    timeSpanInterval = new TimeSpan(0, int.Parse(numUnits), 0, 0);
                    break;
                case "days":
                    timeSpanInterval = new TimeSpan(int.Parse(numUnits), 0, 0, 0);
                    break;
                default:
                    throw new Exception("Invalid time units; use seconds, minutes, hours, or days");
            }
            return timeSpanInterval;
        }

        public static TimeSpan GetDurationByUnits(string durationUnits, string startIntervalFromNow)
        {
            TimeSpan timeSpanInterval;
            switch (durationUnits)
            {
                case "seconds":
                    timeSpanInterval = new TimeSpan(0, 0, int.Parse(startIntervalFromNow));
                    break;
                case "minutes":
                    timeSpanInterval = new TimeSpan(0, int.Parse(startIntervalFromNow), 0);
                    break;
                case "hours":
                    timeSpanInterval = new TimeSpan(int.Parse(startIntervalFromNow), 0, 0);
                    break;
                case "days":
                    timeSpanInterval = new TimeSpan(int.Parse(startIntervalFromNow), 0, 0, 0);
                    break;
                default:
                    timeSpanInterval = new TimeSpan(0, 0, 0, 0);
                    break;
            }
            return timeSpanInterval;
        }        
    }
}
