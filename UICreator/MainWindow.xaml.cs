using SocketIOClient;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UICreator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : System.Windows.Window
    {
        WebSocketCheck check;
        public MainWindow()
        {
            InitializeComponent();
            check = new WebSocketCheck();
            DataContext = check;
        }
        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            ButtonCloseMenu.Visibility = Visibility.Visible;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;

        }

        private void StackPanel_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainFrame.Navigate(new Transaction());
        }

        private void StackPanel_MouseLeftButtonDown_History(object sender, MouseButtonEventArgs e)
        {
            MainFrame.Navigate(new History());
        }

        private void StackPanel_MouseLeftButtonDown_FLow(object sender, MouseButtonEventArgs e)
        {
            MainFrame.Navigate(new Flow());
        }

        private void StackPanel_MouseLeftButtonDown_Setings(object sender, MouseButtonEventArgs e)
        {
            MainFrame.Navigate(new Settings());
        }

        private void MainFrame_Navigated(object sender, NavigationEventArgs e)
        {
            // MainFrame.NavigationService.RemoveBackEntry();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            StackPanel_PreviewMouseLeftButtonDown(null, null);
            //MainFrame.Navigate(new Transaction());
        }
        

      



    }
}
