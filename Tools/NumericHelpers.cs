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
    }
}