using GalaSoft.MvvmLight.Command;
using MaterialDesignThemes.Wpf;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfAppFinanse.Converters;
using WpfAppFinanse.Data;
using WpfAppFinanse.Models;

namespace WpfAppFinanse.ViewModels
{
    public class CorrectionViewModel : ViewModelBase
    {
        private readonly FinanceDbContext _dbContext;
        private DateTime? _selectedDay;
        private DateTime? _periodStart;
        private DateTime? _periodEnd;
        private Transaction _selectedTransaction;
        private bool _isSnackbarActive;
        private string _snackbarMessage;

        public ObservableCollection<Transaction> Transactions { get; } = new ObservableCollection<Transaction>();
        public bool IsSnackbarActive
        {
            get => _isSnackbarActive;
            set => SetProperty(ref _isSnackbarActive, value);
        }
        public string SnackbarMessage
        {
            get => _snackbarMessage;
            set => SetProperty(ref _snackbarMessage, value);
        }
        public DateTime? SelectedDay
        {
            get => _selectedDay;
            set => SetProperty(ref _selectedDay, value);
        }
        public DateTime? PeriodStart
        {
            get => _periodStart;
            set
            {
                if (SetProperty(ref _periodStart, value))
                {
                    CommandManager.InvalidateRequerySuggested();
                }
            }
        }

        public DateTime? PeriodEnd
        {
            get => _periodEnd;
            set
            {
                if (SetProperty(ref _periodEnd, value))
                {
                    CommandManager.InvalidateRequerySuggested();
                }
            }
        }
        public Transaction SelectedTransaction
        {
            get => _selectedTransaction;
            set => SetProperty(ref _selectedTransaction, value);
        }

        public ICommand SearchCommand { get; private set; }
        public ICommand DeleteCommand { get; private set; }
        public ICommand DeleteAllCommand { get; private set; }

        public CorrectionViewModel(FinanceDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            InitializeCommands();
            InitializeAsync().ConfigureAwait(false);
        }

        private void InitializeCommands()
        {
            SearchCommand = new RelayCommand(async () => await ExecuteSearch(), CanExecuteSearch);
            DeleteCommand = new RelayCommand(ExecuteDelete, () => SelectedTransaction != null);
            DeleteAllCommand = new RelayCommand(ExecuteDeleteAll, () => Transactions.Any());
        }

        public async Task InitializeAsync()
        {
            try
            {
                await LoadInitialData();
            }
            catch (Exception ex)
            {
                SnackbarMessage = "Ошибка при инициализации: " + ex.Message;
                IsSnackbarActive = true;
            }
        }

        private async Task LoadInitialData()
        {
            Transactions.Clear();
            var transactions = await _dbContext.Transactions.ToListAsync();
            Transactions.AddRange(transactions);
        }

        private bool CanExecuteSearch() => PeriodStart.HasValue && PeriodEnd.HasValue && PeriodEnd >= PeriodStart;

        private async Task ExecuteSearch()
        {
            if (!CanExecuteSearch())
                return;

            Transactions.Clear();
            try
            {
                var transactions = await Task.Run(() => FetchTransactionsAsync());
                Transactions.AddRange(transactions);
            }
            catch (Exception ex)
            {
                SnackbarMessage = "Ошибка при загрузке: " + ex.Message;
                IsSnackbarActive = true;
            }
        }

        private void ExecuteDelete()
        {
            if (SelectedTransaction == null) return;
            _dbContext.Transactions.Remove(SelectedTransaction);
            _dbContext.SaveChanges();
            Transactions.Remove(SelectedTransaction);
        }

        private void ExecuteDeleteAll()
        {
            _dbContext.Transactions.RemoveRange(Transactions);
            _dbContext.SaveChanges();
            Transactions.Clear();
        }

        private async Task<List<Transaction>> FetchTransactionsAsync()
        {
            return await _dbContext.Transactions
                .Where(t => t.Date >= PeriodStart && t.Date <= PeriodEnd)
                .ToListAsync();
        }

    }
}