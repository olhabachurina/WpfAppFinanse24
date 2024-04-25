using Aspose.Slides.SlideShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppFinanse.Models
{

    public class Transaction : INotifyPropertyChanged
    {
        private Guid _id;
        private DateTime _date;
        private decimal _amount;
        private string _description;
        private Guid _accountId;
        private TransactionType _type;
        private Guid _currencyId;
        private Wallet _wallet;

        public Guid Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        public Guid CurrencyId
        {
            get => _currencyId;
            set => SetProperty(ref _currencyId, value);
        }

        public DateTime Date
        {
            get => _date;
            set => SetProperty(ref _date, value);
        }

        public decimal Amount
        {
            get => _amount;
            set
            {
                if (value < 0 && Type != TransactionType.Expense)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Amount must be positive unless the transaction is an expense.");
                }
                SetProperty(ref _amount, value);
            }
        }

        public string Description
        {
            get => _description;
            set => SetProperty(ref _description, value);
        }

        public Guid AccountId
        {
            get => _accountId;
            set => SetProperty(ref _accountId, value);
        }

        public TransactionType Type
        {
            get => _type;
            set => SetProperty(ref _type, value);
        }

        public Wallet Wallet
        {
            get => _wallet;
            set => SetProperty(ref _wallet, value);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
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

    public enum TransactionType
    {
        Income,   // Доход
        Expense   // Расход
    }
}
