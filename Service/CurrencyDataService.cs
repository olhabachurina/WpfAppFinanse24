using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppFinanse.Data;
using WpfAppFinanse.Models;

namespace WpfAppFinanse.Service
{
    public class CurrencyDataService
    {
        private readonly FinanceDbContext _db;
        private ObservableCollection<Currency> _currencies;
        public event Action CurrenciesUpdated;

        public CurrencyDataService(FinanceDbContext db)
        {
            _db = db;
        }

        public ObservableCollection<Currency> Currencies
        {
            get
            {
                if (_currencies == null)
                {
                    LoadCurrenciesAsync().ConfigureAwait(false);
                }
                return _currencies;
            }
        }

        private async Task LoadCurrenciesAsync()
        {
            _currencies = new ObservableCollection<Currency>(await _db.Currencies.ToListAsync());
            CurrenciesUpdated?.Invoke();
        }

        public void AddCurrency(Currency currency)
        {
            _db.Currencies.Add(currency);
            _db.SaveChanges();
            _currencies.Add(currency);
            CurrenciesUpdated?.Invoke();
        }
    }
}
