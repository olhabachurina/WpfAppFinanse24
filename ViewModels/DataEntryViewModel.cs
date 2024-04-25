using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfAppFinanse.Commands;
using WpfAppFinanse.Data;
using WpfAppFinanse.Models;
using GalaSoft.MvvmLight.Messaging;
using MaterialDesignThemes.Wpf;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Serilog;
using WpfAppFinanse.Service;
using WpfAppFinanse.Converters;
namespace WpfAppFinanse.ViewModels
{
    public class DataEntryViewModel : ViewModelBase
    {
        private readonly CurrencyDataService _currencyService;
        public ObservableCollection<Currency> Currencies { get; } = new ObservableCollection<Currency>();
        public ObservableCollection<IncomeType> IncomeTypes { get; set; } = new ObservableCollection<IncomeType>();
        public ObservableCollection<Wallet> Wallets { get; } = new ObservableCollection<Wallet>();
        public ObservableCollection<TransactionType> TransactionTypes { get; } = new ObservableCollection<TransactionType>();
        public ObservableCollection<ExpenseType> ExpenseTypes { get; } = new ObservableCollection<ExpenseType>();
        public ExpenseType SelectedExpenseType { get; set; }
        public ICommand AddIncomeCommand { get; private set; }
        public ICommand AddExpenseCommand { get; private set; }
        public ICommand CloseSnackbarCommand { get; private set; }


        private readonly FinanceDbContext _db;
        private bool _dataLoaded = false;
        public Currency SelectedCurrency { get; set; }
        public string ThemeText { get; set; }

        public TransactionType SelectedTransactionType { get; set; }
        public DateTime? ExpenseDate { get; set; }
        private IncomeType? _selectedIncomeType;
        private Wallet _selectedWallet;
        private DateTime? _incomeDate;
        private DateTime? _expenseDate;
        private decimal _incomeAmount;
        private decimal _expenseAmount;
        private bool _isSnackbarActive;
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

        private string _snackbarMessage;
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
       
        public DataEntryViewModel()
        {
            _db = new FinanceDbContext();
            InitializeCommands();
            InitializeAsync();
        }

        private void InitializeCommands()
        {
            CloseSnackbarCommand = new RelayCommand(_ => IsSnackbarActive = false);
            AddIncomeCommand = new RelayCommand(async parameter => await AddIncomeAsync(), parameter => CanAddIncome());
            AddExpenseCommand = new RelayCommand(async parameter => await AddExpenseAsync(), parameter => CanAddExpense());
        }
       
        public async Task InitializeAsync()
        {
            if (_dataLoaded) return;
            Log.Information("Начало асинхронной инициализации данных...");
            try
            {
                await LoadDataAsync();
                InitializeDefaults();
                _dataLoaded = true;
                Log.Information("Асинхронная инициализация данных успешно завершена.");
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Ошибка во время асинхронной инициализации данных.");
            }
            CommandManager.InvalidateRequerySuggested();
        }

        private void InitializeDefaults()
        {
            SelectedIncomeType = IncomeTypes.FirstOrDefault();
            IncomeAmount = 100;
            IncomeDate = DateTime.Today;

            SelectedExpenseType = ExpenseTypes.FirstOrDefault();
            ExpenseAmount = 100;
            ExpenseDate = DateTime.Today;
        }
        private async Task AddExpenseAsync()
        {
            if (!CanAddExpense())
            {
                SnackbarMessage = "Не все поля корректно заполнены для добавления расхода.";
                IsSnackbarActive = true;
                return;
            }

            var expenseTransaction = new Transaction
            {
                Id = Guid.NewGuid(),
                Date = ExpenseDate.Value,
                Type = TransactionType.Expense,
                Amount = -ExpenseAmount, 
                Description = "Расход",
                AccountId = SelectedWallet.Id,
                CurrencyId = SelectedCurrency.Id,
                
            };

            _db.Transactions.Add(expenseTransaction);
            SelectedWallet.Balance -= ExpenseAmount; 

            SnackbarMessage = "Расход успешно добавлен.";
            IsSnackbarActive = true;
        }
        private bool CanAddIncome()
        {
            
            bool canAdd = SelectedIncomeType != null && IncomeAmount > 0 && IncomeDate != null && SelectedWallet != null;

          
            Log.Information($"CanAddIncome called: {canAdd} - IncomeType: {SelectedIncomeType?.Id}, Amount: {IncomeAmount}, Date: {IncomeDate}, Wallet: {SelectedWallet?.Id}");

            return canAdd;

        }
        private bool CanAddExpense()
        {
           
            bool canAdd = SelectedExpenseType != null && ExpenseAmount > 0 && ExpenseDate != null && SelectedWallet != null;
            Log.Information($"CanAddExpense called: {canAdd} - ExpenseType: {SelectedExpenseType?.Id}, Amount: {ExpenseAmount}, Date: {ExpenseDate}, Wallet: {SelectedWallet?.Id}");
            return canAdd;
        }

        private async Task AddIncomeAsync()
        {
            if (!CanAddIncome())
            {
                SnackbarMessage = "Не все поля корректно заполнены для добавления дохода.";
                IsSnackbarActive = true;
                return;
            }


            var incomeTransaction = new Transaction
            {
                Id = Guid.NewGuid(),
                Date = IncomeDate.Value,
                Amount = IncomeAmount, 
                Description = "Доход",
                AccountId = SelectedWallet.Id,
                CurrencyId = SelectedCurrency.Id,
                Type = TransactionType.Income
            };

            _db.Transactions.Add(incomeTransaction);
            SelectedWallet.Balance += IncomeAmount; 
            try
            {
                await _db.SaveChangesAsync();

                SnackbarMessage = "Доход успешно добавлен.";
                IsSnackbarActive = true;
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Ошибка при сохранении дохода.");
                SnackbarMessage = "Произошла ошибка при сохранении данных.";
                IsSnackbarActive = true;
            }
        }
        public IncomeType SelectedIncomeType
        {
            get => _selectedIncomeType;
            set
            {
                if (_selectedIncomeType != value)
                {
                    _selectedIncomeType = value;
                    OnPropertyChanged(nameof(SelectedIncomeType));
                    CommandManager.InvalidateRequerySuggested(); 
                }
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
                    CommandManager.InvalidateRequerySuggested();
                }
            }
        }

        public DateTime? IncomeDate
        {
            get => _incomeDate;
            set
            {
                if (_incomeDate != value)
                {
                    _incomeDate = value;
                    OnPropertyChanged(nameof(IncomeDate));
                    CommandManager.InvalidateRequerySuggested();
                }
            }
        }

        public decimal IncomeAmount
        {
            get => _incomeAmount;
            set
            {
                if (_incomeAmount != value)
                {
                    _incomeAmount = value;
                    OnPropertyChanged(nameof(IncomeAmount));
                    CommandManager.InvalidateRequerySuggested();
                }
            }
        }

        public decimal ExpenseAmount
        {
            get => _expenseAmount;
            set
            {
                if (_expenseAmount != value)
                {
                    _expenseAmount = value;
                    OnPropertyChanged(nameof(ExpenseAmount));
                    CommandManager.InvalidateRequerySuggested();
                }
            }
        }


        private async Task LoadDataAsync()
        {
            Log.Information("Начало комплексной загрузки данных...");
            try
            {
              
                var currencyTask = _db.Currencies.ToListAsync();
                var walletTask = _db.Wallets.Include(w => w.Transactions).ToListAsync();
                var incomeTypeTask = _db.IncomeTypes.ToListAsync();
                var expenseTypeTask = _db.ExpenseTypes.ToListAsync();

                await Task.WhenAll(currencyTask, walletTask, incomeTypeTask, expenseTypeTask);

            
                Currencies.AddRange(currencyTask.Result);
                Wallets.AddRange(walletTask.Result);
                IncomeTypes.AddRange(incomeTypeTask.Result);
                ExpenseTypes.AddRange(expenseTypeTask.Result);
                TransactionTypes.AddRange(Enum.GetValues(typeof(TransactionType)).Cast<TransactionType>());

                Log.Information("Комплексная загрузка данных успешно завершена.");
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Ошибка при комплексной загрузке данных.");
                throw; 
            }
        }
        private async Task LoadExpenseTypes()
        {
            Log.Information("Начало загрузки типов расходов...");
            try
            {
                ExpenseTypes.Clear();
                var expenseTypes = await _db.ExpenseTypes.ToListAsync();
                foreach (var expenseType in expenseTypes)
                {
                    ExpenseTypes.Add(expenseType);
                }
                Log.Information($"Загрузка типов расходов завершена. Загружено {ExpenseTypes.Count} типов.");
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Ошибка при загрузке типов расходов.");
            }
            OnPropertyChanged(nameof(ExpenseTypes));
        }


        private void LoadTransactionTypes()
        {
            Log.Information("Начало загрузки типов транзакций...");
            try
            {
                TransactionTypes.Clear();
                foreach (var type in Enum.GetValues(typeof(TransactionType)))
                {
                    TransactionTypes.Add((TransactionType)type);
                }
                Log.Information($"Загрузка типов транзакций завершена. Загружено {TransactionTypes.Count} типов.");
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Ошибка при загрузке типов транзакций.");
            }
            OnPropertyChanged(nameof(TransactionTypes));
        }


        private async Task LoadIncomeTypes()
        {
            Log.Information("Загрузка типов доходов начата...");
            IncomeTypes.Clear();
            var incomeTypes = await _db.IncomeTypes.ToListAsync();
            foreach (var incomeType in incomeTypes)
            {
                IncomeTypes.Add(incomeType);
            }
            Log.Information($"Загрузка типов доходов завершена. Загружено {IncomeTypes.Count} типов.");
            OnPropertyChanged(nameof(IncomeTypes));
        }

        private async Task LoadWalletsAsync()
        {
            Log.Information("Начало загрузки кошельков...");
            try
            {
                Wallets.Clear();
                var wallets = await _db.Wallets.Include(w => w.Transactions).ToListAsync();
                foreach (var wallet in wallets)
                {
                    Wallets.Add(wallet);
                }
                Log.Information($"Загрузка кошельков завершена. Загружено {Wallets.Count} кошельков.");
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Ошибка при загрузке кошельков.");
            }
            OnPropertyChanged(nameof(Wallets));
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
        public async Task SaveChangesAsync()
        {
            try
            {
                await _db.SaveChangesAsync();
                Log.Information("Изменения успешно сохранены.");
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Ошибка при сохранении изменений.");
               
            }
        }
    }
}