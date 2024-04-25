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
    [Migration("20240424100809_CreateTriggerMigration")]
    partial class CreateTriggerMigration
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
                            Id = new Guid("b43345f5-1270-4390-a807-627abfa8f466"),
                            Code = "UAH",
                            Name = "Гривна"
                        },
                        new
                        {
                            Id = new Guid("ad1ff7a5-bdfb-45ef-9f27-b884bbdeaea5"),
                            Code = "USD",
                            Name = "Доллар США"
                        },
                        new
                        {
                            Id = new Guid("36cf5f73-3ac4-438d-9080-e308f734a25a"),
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
                            Id = new Guid("f8cc14c2-7b92-4e7b-87b1-aee4d1c1aad1"),
                            Name = "Продукты"
                        },
                        new
                        {
                            Id = new Guid("c81e728d-8d43-407d-94b8-80037f77c3f4"),
                            Name = "Транспортные расходы"
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
                            Id = new Guid("eccbc87e-4b5c-11e8-b3db-408d5c9ff8f6"),
                            Name = "Зарплата"
                        },
                        new
                        {
                            Id = new Guid("c4ca4238-4b5c-11e8-91e6-348599dc9991"),
                            Name = "Премия"
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
                            Id = new Guid("25f112be-4e1c-4f89-bbbc-1c4ce9ecdeaf"),
                            Balance = 1000m,
                            CurrencyId = new Guid("b43345f5-1270-4390-a807-627abfa8f466"),
                            Name = "Основной кошелек"
                        },
                        new
                        {
                            Id = new Guid("67b5b583-b8cf-4f12-9a0e-cb5728d28daf"),
                            Balance = 500m,
                            CurrencyId = new Guid("ad1ff7a5-bdfb-45ef-9f27-b884bbdeaea5"),
                            Name = "Сбережения в долларах"
                        },
                        new
                        {
                            Id = new Guid("bf15d536-7b4d-43a9-a1d1-ef64a6728e16"),
                            Balance = 500m,
                            CurrencyId = new Guid("36cf5f73-3ac4-438d-9080-e308f734a25a"),
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