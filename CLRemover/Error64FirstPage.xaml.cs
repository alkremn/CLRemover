using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Fixer
{
    /// <summary>
    /// Interaction logic for FirstPage.xaml
    /// </summary>
    public partial class Error64FirstPage : Page
    {
        private static readonly string PRO = "Zyto Pro";
        private static readonly string COMPASS = "Compass";
        private readonly Window window;
        public Error64FirstPage(Window window)
        {
            InitializeComponent();
            this.window = window;
        }

        private void Pro_Delete_Click(object sender, RoutedEventArgs e)
        {
            var appPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var path = appPath + "\\ZYTO5";
            if (Directory.Exists(path))
            {
                File.Delete(path + "\\CloudLicense");
                NavigationService.Navigate(new Error64SecondPage(window));
            }
            else
            {
                systemName.Text = PRO;
                errorLabel.Visibility = Visibility.Visible;
            }
        }

        private void Compass_Delete_Click(object sender, RoutedEventArgs e)
        {
            var appPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var path = appPath + "\\ZYTOCompass2";
            if (Directory.Exists(path))
            {
                File.Delete(path + "\\CloudLicense");
                NavigationService.Navigate(new Error64SecondPage(window));
            }
            else
            {
                systemName.Text = COMPASS;
                errorLabel.Visibility = Visibility.Visible;
            }
        }

    }
}
