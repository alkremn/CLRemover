using System.Windows;
using System.Windows.Controls;

namespace CLRemover
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class SecondPage : Page
    {
        private Window window;
        public SecondPage(Window window)
        {
            InitializeComponent();
            this.window = window;
        }

        private void Url_Button_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://account.zyto.com/portal/accounts");
            if (window != null)
                window.Close();
        }
    }
}
