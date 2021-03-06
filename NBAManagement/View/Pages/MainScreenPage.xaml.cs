﻿using NBAManagement.ViewModel;
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

namespace NBAManagement.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainScreenPage.xaml
    /// </summary>
    public partial class MainScreenPage : Page
    {
        public MainScreenPage()
        {
            InitializeComponent();
            //this.NavigationService.Navigated += (object sender, NavigationEventArgs e) =>
            //    MessageBox.Show("Navigated");
            //MainWindowViewModel.AppNavigationService = NavigationService;
        }

        private void VisitorMenuPageNavigationButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new VisitorMenuPage());
        }
    }
}
