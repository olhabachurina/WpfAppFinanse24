using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppFinanse.Models
{
    public class Wallet : INotifyPropertyChanged
    {
        private Guid _id;
        private string _name;
        private decimal _balance;
        private Currency _currency;
        private Guid _currencyId;
        private ObservableCollection<Transaction> _transactions = new ObservableCollection<Transaction>();

        public Guid Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        public ObservableCollection<Transaction> Transactions
        {
            get => _transactions;
            set => SetProperty(ref _transactions, value);
        }

        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        public decimal Balance
        {
            get => _balance;
            set
            {
                if (_balance != value)
                {
                    _balance = value;
                    OnPropertyChanged(nameof(Balance));
                }
            }
        }

        public Currency Currency
        {
            get => _currency;
            set => SetProperty(ref _currency, value);
        }

        public Guid CurrencyId
        {
            get => _currencyId;
            set => SetProperty(ref _currencyId, value);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}