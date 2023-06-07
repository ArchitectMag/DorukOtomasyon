using System;

namespace JobOrderStatusReport.Helpers
{
    public static class DateTimeHelper
    {
        public static int CalculateTotalMunite(TimeSpan timeSpan)
        {
            int totalMinutes = 0;
            totalMinutes += DayToMinutes(timeSpan.Days);
            totalMinutes += HourToMinutes(timeSpan.Hours);
            totalMinutes += timeSpan.Minutes;
            totalMinutes += timeSpan.Seconds / 60;
            return totalMinutes;
        }

        public static int HourToMinutes(int hours)
        {
            return hours * 60;
        }

        public static int DayToMinutes(int days)
        {
            return days * 24 * 60;
        }

    }
}