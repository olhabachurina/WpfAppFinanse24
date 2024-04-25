using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfAppFinanse.Commands;
using WpfAppFinanse.Data;
using WpfAppFinanse.Models;

namespace WpfAppFinanse.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private ObservableCollection<IncomeType> _incomeTypes;
        public ObservableCollection<IncomeType> IncomeTypes
        {
            get => _incomeTypes;
            set
            {
                if (_incomeTypes != value)
                {
                    _incomeTypes = value;
                    OnPropertyChanged(nameof(IncomeTypes));
                }
            }
        }
    }
}

