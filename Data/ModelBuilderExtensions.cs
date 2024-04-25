using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppFinanse.Models;

namespace WpfAppFinanse.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var uahId = Guid.Parse("b43345f5-1270-4390-a807-627abfa8f466");
            var usdId = Guid.Parse("ad1ff7a5-bdfb-45ef-9f27-b884bbdeaea5");
            var eurId = Guid.Parse("36cf5f73-3ac4-438d-9080-e308f734a25a");

            modelBuilder.Entity<Currency>().HasData(
                new Currency { Id = uahId, Code = "UAH", Name = "Гривна" },
                new Currency { Id = usdId, Code = "USD", Name = "Доллар США" },
                new Currency { Id = eurId, Code = "EUR", Name = "Евро" }
            );

            modelBuilder.Entity<Wallet>().HasData(
                new Wallet { Id = Guid.Parse("25f112be-4e1c-4f89-bbbc-1c4ce9ecdeaf"), Name = "Основной кошелек", Balance = 1000, CurrencyId = uahId },
                new Wallet { Id = Guid.Parse("67b5b583-b8cf-4f12-9a0e-cb5728d28daf"), Name = "Сбережения в долларах", Balance = 500, CurrencyId = usdId },
                new Wallet { Id = Guid.Parse("bf15d536-7b4d-43a9-a1d1-ef64a6728e16"), Name = "Сбережения в евро", Balance = 500, CurrencyId = eurId }
            );

            modelBuilder.Entity<ExpenseType>().HasData(
                new ExpenseType { Id = Guid.Parse("f8cc14c2-7b92-4e7b-87b1-aee4d1c1aad1"), Name = "Продукты" },
                new ExpenseType { Id = Guid.Parse("c81e728d-8d43-407d-94b8-80037f77c3f4"), Name = "Транспортные расходы" }


           

       );
            modelBuilder.Entity<IncomeType>().HasData(
            new IncomeType { Id = Guid.Parse("eccbc87e-4b5c-11e8-b3db-408d5c9ff8f6"), Name = "Зарплата" },
            new IncomeType { Id = Guid.Parse("c4ca4238-4b5c-11e8-91e6-348599dc9991"), Name = "Премия" }
          

        );

        }
    }
}
