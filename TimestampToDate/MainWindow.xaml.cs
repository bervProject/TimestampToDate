using System;
using System.Windows;
using System.Windows.Controls;

namespace TimestampToDate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string timestampString = source.Text;
            string result = ConvertTimestampToDateTimeString(timestampString);
            destination.Text = result;
        }

        private static string ConvertTimestampToDateTimeString(string timestamp)
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
