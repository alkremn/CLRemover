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
            var path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var fullPath = path + "\\ZYTO5\\CloudLicense";
            File.Delete(fullPath);
            zytoProLabel.Visibility = Visibility.Visible;
            linkLabel.Visibility = Visibility.Visible;
        }

        private void Compass_Delete_Click(object sender, RoutedEventArgs e)
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var fullPath = path + "\\ZYTOCompass2\\CloudLicense";
            File.Delete(fullPath);
            ZytoCompasLabel.Visibility = Visibility.Visible;
            linkLabel.Visibility = Visibility.Visible;
        }

        private void Url_Button_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://zyto.auth0.com/login?state=g6Fo2SAwRG95aEh6Zm9nRnNyY1lTV20tbVVubldUZWFqbmkxRqN0aWTZIEc0XzRYQjBydi1VVVRKQjUyUUp2eVZLakIxSWIyUlRVo2NpZNkgd0xla1ZTV1FMaThvT0tySDVHMXFPTENNbFlHTUIxVDY&client=wLekVSWQLi8oOKrH5G1qOLCMlYGMB1T6&protocol=oauth2&response_type=code&redirect_uri=https%3A%2F%2Faccount.zyto.com%2Fsignin-auth0&scope=openid");
        }
    }
}
