﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WpfAppFinanse.Data;

#nullable disable

namespace WpfAppFinanse.Migrations
{
    [DbContext(typeof(FinanceDbContext))]
    [Migration("20240423114644_DataOperationsForWallets")]
    partial class DataOperationsForWallets
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("WpfAppFinanse.Models.Currency", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Currencies");

                    b.HasData(
                        new
                        {
                            Id = new Guid("05c24331-37d1-4d51-b4f3-36d8a2f7ef65"),
                            Code = "UAH",
                            Name = "Гривна"
                        },
                        new
                        {
                            Id = new Guid("1e3013b1-2f25-4495-a914-476c517556f0"),
                            Code = "USD",
                            Name = "Доллар США"
                        },
                        new
                        {
                            Id = new Guid("39c862f3-2cf5-456e-a4b5-d4fba2d14fcd"),
                            Code = "EUR",
                            Name = "Евро"
                        });
                });

            modelBuilder.Entity("WpfAppFinanse.Models.ExpenseType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ExpenseTypes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("32a93958-c40d-403b-bee9-394cd1258445"),
                            Name = "Продукты"
                        },
                        new
                        {
                            Id = new Guid("85dd76e4-77e6-49bc-bd68-effecd7d65cc"),
                            Name = "Транспортные расходы"
                        },
                        new
                        {
                            Id = new Guid("d9fc3a34-311e-4673-9409-88c076af3c33"),
                            Name = "Коммунальные расходы"
                        },
                        new
                        {
                            Id = new Guid("5cfa2f0e-d3f9-420a-83a4-343b0e788897"),
                            Name = "Покупка одежды"
                        },
                        new
                        {
                            Id = new Guid("64960659-8318-4af5-a810-915f1c08b2ae"),
                            Name = "Развлечения"
                        },
                        new
                        {
                            Id = new Guid("139b427e-50be-4b5d-bd53-24025a4d6aaa"),
                            Name = "Ремонт"
                        },
                        new
                        {
                            Id = new Guid("ce642da1-3549-488c-82e2-b2c2e6e83989"),
                            Name = "Хозяйственные расходы"
                        },
                        new
                        {
                            Id = new Guid("fee87ae8-9e7c-4b5f-8e65-357ce05098da"),
                            Name = "Косметологические услуги"
                        });
                });

            modelBuilder.Entity("WpfAppFinanse.Models.IncomeType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("IncomeTypes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2d3e01bb-f614-4f49-8c52-120759a814c1"),
                            Name = "Зарплата"
                        },
                        new
                        {
                            Id = new Guid("bd723229-67d0-4d27-b38f-19987304c0cb"),
                            Name = "Премия"
                        },
                        new
                        {
                            Id = new Guid("a7e24f5d-e78e-4fdd-8b99-27d67305bab6"),
                            Name = "Доход от сдачи в аренду"
                        },
                        new
                        {
                            Id = new Guid("32335321-0571-4366-91a6-ca862c458476"),
                            Name = "Подарок"
                        });
                });

            modelBuilder.Entity("WpfAppFinanse.Models.Transaction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("AccountId")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Amount")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CurrencyId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("CurrencyId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("WpfAppFinanse.Models.Wallet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Balance")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CurrencyId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CurrencyId");

                    b.ToTable("Wallets");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6aa47f55-9152-4960-9b2b-65f4a9903886"),
                            Balance = 1000m,
                            CurrencyId = new Guid("05c24331-37d1-4d51-b4f3-36d8a2f7ef65"),
                            Name = "Основной кошелек"
                        },
                        new
                        {
                            Id = new Guid("66b21f16-7564-48da-8c09-efd026202934"),
                            Balance = 500m,
                            CurrencyId = new Guid("1e3013b1-2f25-4495-a914-476c517556f0"),
                            Name = "Сбережения в долларах"
                        },
                        new
                        {
                            Id = new Guid("4fd672ea-3b20-477f-ba31-d07cd89c1eb2"),
                            Balance = 500m,
                            CurrencyId = new Guid("39c862f3-2cf5-456e-a4b5-d4fba2d14fcd"),
                            Name = "Сбережения в евро"
                        });
                });

            modelBuilder.Entity("WpfAppFinanse.Models.Transaction", b =>
                {
                    b.HasOne("WpfAppFinanse.Models.Wallet", "Wallet")
                        .WithMany("Transactions")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WpfAppFinanse.Models.Currency", null)
                        .WithMany()
                        .HasForeignKey("CurrencyId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Wallet");
                });

            modelBuilder.Entity("WpfAppFinanse.Models.Wallet", b =>
                {
                    b.HasOne("WpfAppFinanse.Models.Currency", "Currency")
                        .WithMany()
                        .HasForeignKey("CurrencyId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Currency");
                });

            modelBuilder.Entity("WpfAppFinanse.Models.Wallet", b =>
                {
                    b.Navigation("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}
