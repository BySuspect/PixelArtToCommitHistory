using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelArtToCommitHistory.Helpers
{
    public static class DateHelper
    {
        public static List<DateTime> GetDateRange(DateTime startDate, DateTime endDate)
        {
            List<DateTime> dateList = new List<DateTime>();
            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                dateList.Add(date);
            }

            return dateList;
        }

        public static DateTime[,] getDates(DateTime startDate, DateTime endDate)
        {
            var allDates = GetDateRange(startDate, endDate);

            DateTime[,] dates = new DateTime[51, 7];

            int counter = 0;
            for (int x = 0; x < 51; x++)
            {
                for (int y = 0; y < 7; y++)
                {
                    dates[x, y] = allDates[counter];
                    counter++;
                }
            }

            return dates;
        }

        public static string FormatCustomDateTime(DateTime dateTime)
        {
            string formattedDate =
                $"{GetDayOfWeekName(dateTime.DayOfWeek)} {GetMonthName(dateTime.Month)} {dateTime.Day:D2} {dateTime.Hour:D2}:{dateTime.Minute:D2} {dateTime.Year} {GetTimeZoneOffset(dateTime)}";

            return formattedDate;
        }

        private static string GetDayOfWeekName(DayOfWeek dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case DayOfWeek.Sunday:
                    return "Sun";
                case DayOfWeek.Monday:
                    return "Mon";
                case DayOfWeek.Tuesday:
                    return "Tue";
                case DayOfWeek.Wednesday:
                    return "Wed";
                case DayOfWeek.Thursday:
                    return "Thu";
                case DayOfWeek.Friday:
                    return "Fri";
                case DayOfWeek.Saturday:
                    return "Sat";
                default:
                    return "";
            }
        }

        private static string GetMonthName(int month)
        {
            return new DateTime(2024, month, 1).ToString("MMM");
        }

        private static string GetTimeZoneOffset(DateTime dateTime)
        {
            TimeSpan offset = TimeZoneInfo.Local.GetUtcOffset(dateTime);
            int hours = offset.Hours;
            int minutes = Math.Abs(offset.Minutes);
            string sign = offset.TotalMinutes >= 0 ? "+" : "-";
            return $"{sign}{hours:D2}{minutes:D2}";
        }
    }
}
