using System;

namespace Extension
{
    // Our static typing compiles once the project starts
    public static class TimeExtension
    {
        // Australian Time Zone
        public static string ToAustralianTimeZone(this DateTime dateTime)
        {
            return dateTime.AddHours(8).ToLongTimeString();
        }

        // New York Time Zone
        public static string ToNewYorkTimeZone(this DateTime dateTime)
        {
            return dateTime.AddHours(-8).ToLongTimeString();
        }
    }
}
