using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;

namespace Fixer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class ObjectSecondPage : Page
    {
        private readonly Window window;
        public ObjectSecondPage(Window window)
        {
            InitializeComponent();
            this.window = window;
        }
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            window.Close();
        }
    }
}
