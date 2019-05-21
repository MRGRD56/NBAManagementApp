using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;

namespace NBAManagement.ViewModel
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        //public static NavigationService AppNavigationService { get; set; }




        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));


        public event PropertyChangedEventHandler StaticPropertyChanged;
        public void OnStaticPropertyChanged([CallerMemberName]string prop = "") =>
            PropertyChanged?.Invoke(null, new PropertyChangedEventArgs(prop));
    }
}
