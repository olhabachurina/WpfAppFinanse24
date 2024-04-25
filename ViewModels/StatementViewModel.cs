using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfAppFinanse.Models;
using WpfAppFinanse.Commands;
using Serilog;
using WpfAppFinanse.Data;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Data.SqlClient;

namespace WpfAppFinanse.ViewModels
{
    public class StatementViewModel : ViewModelBase
    {

        public ObservableCollection<Wallet> Wallets { get; } = new ObservableCollection<Wallet>();
        public ObservableCollection<Currency> Currencies { get; } = new ObservableCollection<Currency>();
        public ObservableCollection<Transaction> Transactions { get; } = new ObservableCollection<Transaction>();
        private readonly FinanceDbContext _db;
        private bool _dataLoaded = false;
        public ICommand SearchCommand { get; private set; }
        private Wallet _selectedWallet;
        private DateTime? selectedDate;
        private bool isSnackbarActive;
        private string snackbarMessage;
        public DateTime? SelectedDate
        {
            get => selectedDate;
            set
            {
                selectedDate = value;
                OnPropertyChanged(nameof(SelectedDate));
                FilterTransactions();
            }
        }

        public Wallet SelectedWallet
        {
            get => _selectedWallet;
            set
            {
                if (_selectedWallet != value)
                {
                    _selectedWallet = value;
                    OnPropertyChanged(nameof(SelectedWallet));
                    FilterTransactions();

                    UpdateBalance(); 
                    CommandManager.InvalidateRequerySuggested();
                }
            }
        }

        private void UpdateBalance()
        {
            if (SelectedWallet == null)
            {
                Balance = 0;
            }
            else
            {
                var walletId = SelectedWallet.Id;
                var balanceQuery = "SELECT Balance FROM Wallets WHERE Id = @WalletId";
                var balance = _db.Wallets.FromSqlRaw(balanceQuery, new Microsoft.Data.Sqlite.SqliteParameter("@WalletId", walletId)).FirstOrDefault()?.Balance ?? 0;

                Balance = balance;
            }
        }

        private Currency _selectedCurrency;
        public Currency SelectedCurrency
        {
            get => _selectedCurrency;
            set
            {
                if (_selectedCurrency != value)
                {
                    _selectedCurrency = value;
                    OnPropertyChanged(nameof(SelectedCurrency));
                    FilterTransactions();
                }
            }
        }

        private decimal balance;
        public decimal Balance
        {
            get => balance;
            set
            {
                balance = value;
                OnPropertyChanged(nameof(Balance));
            }
        }
        public bool IsSnackbarActive
        {
            get => isSnackbarActive;
            set
            {
                if (isSnackbarActive != value)
                {
                    isSnackbarActive = value;
                    OnPropertyChanged(nameof(IsSnackbarActive));
                }
            }
        }

        public string SnackbarMessage
        {
            get => snackbarMessage;
            set
            {
                if (snackbarMessage != value)
                {
                    snackbarMessage = value;
                    OnPropertyChanged(nameof(SnackbarMessage));
                }
            }
        }
        

        public StatementViewModel()
        {
            _db = new FinanceDbContext();
            InitializeCommands();
            InitializeAsync();


        }
        private void InitializeCommands()
        {
            SearchCommand = new RelayCommand(_ => ExecuteSearch());
        }



        private void ExecuteSearch()
        {
            LoadTransactionsAsync(SelectedDate).ContinueWith(task =>
            {
                if (task.Exception != null)
                {
                    SnackbarMessage = "Ошибка при загрузке транзакций.";
                    IsSnackbarActive = true;
                    Log.Error(task.Exception, "Ошибка при загрузке транзакций в ExecuteSearch.");
                    return;
                }
                Transactions.Clear();
                foreach (var trans in task.Result)
                {
                    Transactions.Add(trans);
                }
                Balance = CalculateBalance(Transactions);
                SnackbarMessage = "Транзакции успешно загружены.";
                IsSnackbarActive = true;
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        private async Task<List<Transaction>> LoadTransactionsAsync(DateTime? date)
        {
            try
            {
                return await _db.Transactions
                                .Where(t => !date.HasValue || t.Date.Date == date.Value.Date)
                                .ToListAsync();
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Ошибка при загрузке транзакций.");
                return new List<Transaction>(); // В случае ошибки возвращаем пустой список
            }
        }

        private decimal CalculateBalance(IEnumerable<Transaction> transactions)
        {
            return transactions.Sum(t => t.Amount);
        }


        private void LoadInitialData(ICommand searchCommand)
        {
            Wallets.Add(new Wallet { Id = Guid.NewGuid(), Name = "Wallet 1" });
            Currencies.Add(new Currency { Id = Guid.NewGuid(), Name = "USD" });
            LoadTransactions();
            SearchCommand = new RelayCommand(_ => ExecuteSearch());
            LoadInitialData(SearchCommand);
        }

        private void LoadTransactions()
        {
            Transactions.Add(new Transaction { Id = Guid.NewGuid(), Date = DateTime.Now, Amount = 100, Description = "Income 1", AccountId = SelectedWallet?.Id ?? Guid.Empty, Type = TransactionType.Income });
            Transactions.Add(new Transaction { Id = Guid.NewGuid(), Date = DateTime.Now.AddDays(-1), Amount = -50, Description = "Expense 1", AccountId = SelectedWallet?.Id ?? Guid.Empty, Type = TransactionType.Expense });
            var walletId = SelectedWallet?.Id ?? Guid.Empty; // Проверяем на null заранее

            // Заменяем условный оператор null в выражении запроса на явную проверку переменной
            var transactionsFromDb = _db.Transactions
                                         .Where(t => t.AccountId == walletId)
                                         .ToList();

            Transactions.Clear();
            foreach (var transaction in transactionsFromDb)
            {
                Transactions.Add(transaction);
            }
        }

        private void FilterTransactions()
        {
            if (SelectedWallet != null)
            {
                var filteredTransactions = _db.Transactions
                                              .Where(t => t.AccountId == SelectedWallet.Id &&
                                                          (!SelectedDate.HasValue || t.Date.Date == SelectedDate.Value.Date))
                                              .ToList();
                Transactions.Clear();
                foreach (var transaction in filteredTransactions)
                {
                    Transactions.Add(transaction);
                }
                UpdateBalance(); // Обновляем баланс после фильтрации транзакций
            }
        }

        public async Task InitializeAsync()
        {
            if (_dataLoaded) return;
            Log.Information("Начало асинхронной инициализации данных...");
            try
            {
                await LoadWalletsAsync();
                await LoadCurrenciesAsync();
                _dataLoaded = true;
                Log.Information("Асинхронная инициализация данных успешно завершена.");
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Ошибка при асинхронной инициализации данных.");
                SnackbarMessage = "Ошибка при загрузке данных.";
                IsSnackbarActive = true;
            }
        }
    

        private async Task LoadWalletsAsync()
        {
            try
            {
                Wallets.Clear();
                var wallets = await _db.Wallets.Include(w => w.Transactions).ToListAsync();
                foreach (var wallet in wallets)
                {
                    Wallets.Add(wallet);
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Ошибка при загрузке кошельков.");
            }
        }

        private async Task LoadCurrenciesAsync()
        {
            Log.Information("Начало загрузки валют...");
            try
            {
                Currencies.Clear();
                var currencies = await _db.Currencies.ToListAsync();
                foreach (var currency in currencies)
                {
                    Currencies.Add(currency);
                }
                Log.Information($"Загрузка валют завершена. Загружено {Currencies.Count} валют.");
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Ошибка при загрузке валют.");
            }
            OnPropertyChanged(nameof(Currencies));
        }

    }
}