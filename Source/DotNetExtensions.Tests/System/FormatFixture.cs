using System;
using NUnit.Framework;

namespace DotNetExtensions.System
{
    [TestFixture]
    internal class FormatFixture
    {
        [TestCase("Test{0}", "Test", Result = "TestTest")]
        [TestCase("Test{0}{1}", "Test", "Test", Result = "TestTestTest")]
        public string FormatInvariantTest(string format, params object[] text)
        {
            return Format.Invariant(format, text);
        }

        [TestCase(2008, 4, 10, 6, 30, 0, 0, Result = "2008-04-10_06-30-00")]
        [TestCase(2010, 4, 1, 6, 3, 1, 0, Result = "2010-04-01_06-03-01")]
        [TestCase(2010, 4, 1, 6, 3, 1, 100, Result = "2010-04-01_06-03-01_1")]
        [TestCase(2010, 4, 1, 6, 3, 1, 10, Result = "2010-04-01_06-03-01_01")]
        public string YearMonthDayFullTest(int year, int month, int day, int hour, int minute, int second, int millisecond)
        {
            var dateTime = new DateTime(year, month, day, hour, minute, second, millisecond);
            return Format.YearMonthDayFull(dateTime);
        }
    }
}
