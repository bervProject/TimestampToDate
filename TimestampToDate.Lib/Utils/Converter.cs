using System;

namespace TimestampToDate.Lib.Utils
{
    public class Converter
    {
        public static string ConvertTimestampToDateTimeString(string timestamp)
        {
            bool parsable = long.TryParse(timestamp, out long timestampLong);
            if (!parsable)
            {
                return string.Empty;
            }
            try
            {
                DateTimeOffset dateTime = DateTimeOffset.FromUnixTimeMilliseconds(timestampLong);
                return dateTime.ToLocalTime()
                               .ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return string.Empty;
            }
        }
    }
}
