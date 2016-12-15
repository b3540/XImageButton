using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace XImageButton
{
    class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Page View { get; set; }

        public ICommand ClickedCommand { get; }

        public MainPageViewModel()
        {
            ClickedCommand = new DelegateCommand((_) 
                => View.DisplayAlert("XImageButton", "Clicked", "OK"));
        }

    }
}
