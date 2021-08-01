using System.Windows;
using System.Windows.Controls;
using TimestampToDate.Lib.Utils;

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
            string result = Converter.ConvertTimestampToDateTimeString(timestampString);
            destination.Text = result;
        }
        
    }
}
