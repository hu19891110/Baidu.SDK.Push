using System;

namespace Baidu.SDK.Push.Utility
{
    internal static class UnixDateTimeHelper
    {
        /// <summary>
        ///   Convert a long into a DateTime
        /// </summary>
        public static DateTime FromUnixTime(this Int64 self)
        {
            var startTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            var time = startTime.AddSeconds(self).ToLocalTime();
            return time;
        }

        /// <summary>
        ///   Convert a DateTime into a long
        /// </summary>
        public static Int64 ToUnixTime(this DateTime self)
        {
            var startTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            var result = (long)(self.ToUniversalTime() - startTime).TotalSeconds;
            return result;
        }
    }
}
