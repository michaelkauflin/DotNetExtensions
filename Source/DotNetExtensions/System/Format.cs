using System;
using System.Globalization;

namespace DotNetExtensions.System
{
    public static class Format
    {
        public static string Invariant(this string text, params object[] args)
        {
            return string.Format(CultureInfo.InvariantCulture, text, args);
        }

        public static string YearMonthDayFull(this DateTime dateTime)
        {
            return dateTime.ToString("yyyy-MM-dd_HH-mm-ss_fff", CultureInfo.InvariantCulture).TrimEnd('0').Trim('_');
        }
    }
}
