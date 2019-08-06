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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var fullPath = path + "\\ZYTO5\\CloudLicense";
            File.Delete(fullPath);
            //label.Visibility = Visibility.Visible;
        }
    }
}
