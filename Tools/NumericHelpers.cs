using Common.Models.Insightly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Tools
{
    public static class NumericHelpers
    {
        public static long? ParseToLong(this object value)
        {
            if (value == null) return null;
            var parsed = long.TryParse(value?.ToString(), out long parsedValue);
            return parsed ? (long?)parsedValue : null;
        }

        public static int? ParseToInt(this object value)
        {
            if (value == null) return null;
            var parsed = int.TryParse(value?.ToString(), out int parsedValue);
            return parsed ? (int?)parsedValue : null;
        }

        public static double? ParseToDouble(this object value)
        {
            if (value == null) return null;
            var parsed = double.TryParse(value?.ToString(), out double parsedValue);
            return parsed ? (double?)parsedValue : null;
        }

        public static decimal? ParseToDecimal(this object value)
        {
            if (value == null) return null;
            var parsed = decimal.TryParse(value?.ToString(), out decimal parsedValue);
            return parsed ? (decimal?)parsedValue : null;
        }
    }
}