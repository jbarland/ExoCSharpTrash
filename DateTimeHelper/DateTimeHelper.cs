using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeHelper
{
    public static class DateTimeHelper
    {
        public static bool isWeekend(this DateTime d)
        {
            if (d.DayOfWeek == DayOfWeek.Sunday || d.DayOfWeek == DayOfWeek.Saturday) { return true; }
            else { return false; }
        }

        public static DateTime GetLastDayOfMonth(this DateTime d)
        {
            return new DateTime(d.Year, d.Month, DateTime.DaysInMonth(d.Year, d.Month));
        }

        public static bool IsInRange(this DateTime d, DateTime dStart, DateTime dEnd)
        {
            if ((d > dStart) && (d < dEnd))
            {
                return true;
            }
            else { return false; }
        }
    }
}
