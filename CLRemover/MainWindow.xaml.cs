using System;
using System.IO;
using System.Windows;

namespace CLRemover
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

        private void Pro_Delete_Click(object sender, RoutedEventArgs e)
        {
            var appPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var path = appPath + "\\ZYTO5";
            if (Directory.Exists(path))
            {
                File.Delete(path + "\\CloudLicense");
                zytoProLabel.Visibility = Visibility.Visible;
                linkLabel.Visibility = Visibility.Visible;
            }
        }

        private void Compass_Delete_Click(object sender, RoutedEventArgs e)
        {
            var appPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var path = appPath + "\\ZYTOCompass2";
            if (Directory.Exists(path))
            {
                File.Delete(path + "\\CloudLicense");
                ZytoCompasLabel.Visibility = Visibility.Visible;
                linkLabel.Visibility = Visibility.Visible;
            }
        }

        private void Url_Button_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://account.zyto.com/portal/accounts");
        }
    }
}
