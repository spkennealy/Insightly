﻿using System;
using System.Globalization;
using System.Linq;
using Models.Insightly;

namespace Tools
{
    public static class DateHelpers
    {
        public static DateTime? ParseDate(string date)
        {
            if (string.IsNullOrWhiteSpace(date)) return null;
            return DateTime.TryParse(date, out DateTime result) ? (DateTime?)result : null;
        }

        public static DateTime? ParseCustomFieldDate(InsightlyCustomFieldObject obj, string field)
        {
            if (obj == null || string.IsNullOrWhiteSpace(field)) return null;
            return DateTime.TryParse(obj?.CUSTOMFIELDS?.Where(cf => cf?.FIELD_NAME == field)?.FirstOrDefault()?.FIELD_VALUE?.ToString(), out DateTime date) ? (DateTime?)date : null;
        }

        public static string ToMonthName(DateTime date)
        {
            return CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(date.Month);
        }

        public static DateTime ToLocalTime(DateTime date, string timeZoneId)
        {
            if (string.IsNullOrWhiteSpace(timeZoneId)) return date;
            var timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
            if (timeZoneInfo == null) return date;
            return TimeZoneInfo.ConvertTimeFromUtc(date, timeZoneInfo);
        }

        private static string ConvertDateTimeToDate(DateTime date)
        {
            return date.Date.ToString().Split(' ').First();
        }
    }
}
