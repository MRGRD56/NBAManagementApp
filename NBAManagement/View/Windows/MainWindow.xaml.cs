using NBAManagement.ViewModel;
using System;
using System.Collections.Generic;
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

namespace NBAManagement
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BackNavigateButton_Click(object sender, RoutedEventArgs e)
        {
            if (MainFrame.NavigationService.CanGoBack) MainFrame.GoBack();
        }

        private void MainFrame_LoadCompleted(object sender, NavigationEventArgs e)
        {
            var title = (MainFrame.Content as Page).Title;
            Header.Visibility = title == "Main Screen" ? Visibility.Collapsed : Visibility.Visible;
            PageNameLabel.Content = title;
        }
    }
}
