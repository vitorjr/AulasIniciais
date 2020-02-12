using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Empresa.Extensions
{
    static class DateTimeExtensions
    {
        public static string ElapsedTime(this DateTime thisObject)
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObject);
            if(duration.TotalHours <= 24.0)
            {
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " Horas";
            }
            else
            {
                return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " Dias";
            }
        }
    }
}
