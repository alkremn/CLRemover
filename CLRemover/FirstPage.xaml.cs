using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CLRemover
{
    /// <summary>
    /// Interaction logic for FirstPage.xaml
    /// </summary>
    public partial class FirstPage : Page
    {
        private static string PRO = "Zyto Pro";
        private static string COMPASS = "Compass";
        private Window window;
        public FirstPage(Window window)
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
                this.NavigationService.Navigate(new SecondPage(window));
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
                this.NavigationService.Navigate(new SecondPage(window));
            }
            else
            {
                systemName.Text = COMPASS;
                errorLabel.Visibility = Visibility.Visible;
            }
        }

    }
}
