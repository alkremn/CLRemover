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

namespace Fixer
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {

        private static readonly string VERSION = "v 1.4";

        private readonly Window window;
        public MainPage(Window window)
        {
            this.window = window;
            InitializeComponent();
        }
        
        private void Error64_Button_Click(object sender, RoutedEventArgs e)
        {
           NavigationService.Navigate(new Error64FirstPage(window));
              
        }

        private void Object_Reference_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ObjectFirstPage(window));
        }


        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            versionLabel.Text = VERSION;
        }
    }
}
