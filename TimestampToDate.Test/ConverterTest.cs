using System.Globalization;
using TimestampToDate.Lib.Utils;
using Xunit;

namespace TimestampToDate.Test
{
    public class ConverterTest
    {
        public ConverterTest()
        {
            CultureInfo.CurrentCulture = new CultureInfo("id-ID");
        }

        [Fact]
        public void ExpectedConverted()
        {
            string timestamp = "1624801432170";
            string result = Converter.ConvertTimestampToDateTimeString(timestamp);
            string expectedDate = "27/06/2021 20.43.52 +07:00";
            string expectedDateUTC = "27/06/2021 13.43.52 +00:00";
            Assert.True(result == expectedDate || result == expectedDateUTC);
        }

        [Fact]
        public void ExpectedNotConverted()
        {
            string timestamp = string.Empty;
            string result = Converter.ConvertTimestampToDateTimeString(timestamp);
            string expectedDate = string.Empty;
            Assert.Equal(expectedDate, result);
        }
    }
}
