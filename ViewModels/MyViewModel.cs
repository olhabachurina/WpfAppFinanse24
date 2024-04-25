using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppFinanse.ViewModels
{
    public class MyViewModel : INotifyPropertyChanged
    {
        private bool _isSnackbarActive;
        private string _snackbarMessage;

        public bool IsSnackbarActive
        {
            get => _isSnackbarActive;
            set
            {
                if (_isSnackbarActive != value)
                {
                    _isSnackbarActive = value;
                    OnPropertyChanged(nameof(IsSnackbarActive));
                }
            }
        }

        public string SnackbarMessage
        {
            get => _snackbarMessage;
            set
            {
                if (_snackbarMessage != value)
                {
                    _snackbarMessage = value;
                    OnPropertyChanged(nameof(SnackbarMessage));
                }
            }
        }

      
        public void ShowSnackbar(string message)
        {
            SnackbarMessage = message;
            IsSnackbarActive = true;

            
            Task.Delay(3000).ContinueWith(t => IsSnackbarActive = false);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}