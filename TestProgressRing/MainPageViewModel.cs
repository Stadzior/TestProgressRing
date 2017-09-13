using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TestProgressRing
{
    public class MainPageViewModel : ViewModelBase
    {
        private bool _isLoading;
        public bool IsLoading
        {
            get => _isLoading;
            set
            {
                _isLoading = value;
                Set(() => IsLoading, ref _isLoading, value);
            }
        }

        public ICommand ClickCommand { get; set; }

        public MainPageViewModel()
        {
            ClickCommand = new RelayCommand(() => 
            IsLoading = !IsLoading);
        }
    }
}
