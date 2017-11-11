using System;

namespace CodeGolf.Conversions
{
    public class DaysInMonth
    {
        public int MonthToDays(string month)
        {
            return DateTime.DaysInMonth(1, DateTime.Parse(1 + month).Month);
        }
    }
}