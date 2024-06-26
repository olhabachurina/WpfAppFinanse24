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
    [Migration("20240411162728_FixedInitialCreate")]
    partial class FixedInitialCreate
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
                            Id = new Guid("bfcd0e34-dcbc-45a6-bcee-e268b31169f4"),
                            Code = "UAH",
                            Name = "Гривна"
                        },
                        new
                        {
                            Id = new Guid("d006a907-7995-4ffb-91ed-2b067524686d"),
                            Code = "USD",
                            Name = "Доллар США"
                        },
                        new
                        {
                            Id = new Guid("810efbfd-2c40-4586-bc88-f0828ecdeb73"),
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
                            Id = new Guid("73a106f0-578d-42c7-9399-e19becf1b2b1"),
                            Name = "Продукты"
                        },
                        new
                        {
                            Id = new Guid("a608d8b1-4acb-4457-aea6-398a557b1d59"),
                            Name = "Транспортные расходы"
                        },
                        new
                        {
                            Id = new Guid("56e870d5-4d22-4dbc-861e-4fa43db1437d"),
                            Name = "Коммунальные расходы"
                        },
                        new
                        {
                            Id = new Guid("24290436-abfd-4d90-9eb3-80722dfc79ab"),
                            Name = "Покупка одежды"
                        },
                        new
                        {
                            Id = new Guid("90359ee4-9899-49a0-807b-56fe9dfca571"),
                            Name = "Развлечения"
                        },
                        new
                        {
                            Id = new Guid("80b4b116-51cd-47f6-b570-1a4472a8f69b"),
                            Name = "Ремонт"
                        },
                        new
                        {
                            Id = new Guid("8dc2f199-dbaa-45b0-bc82-e060e876b304"),
                            Name = "Хозяйственные расходы"
                        },
                        new
                        {
                            Id = new Guid("4d7ce7af-d928-496e-9ee8-4d730dae505d"),
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
                            Id = new Guid("26dfefe4-85da-43fd-bec5-3a50a07fc2ef"),
                            Name = "Зарплата"
                        },
                        new
                        {
                            Id = new Guid("2c657c8e-d2c4-49a5-99d6-2fc76244517f"),
                            Name = "Премия"
                        },
                        new
                        {
                            Id = new Guid("c1a72389-0af7-43b0-829a-8df89168b8d6"),
                            Name = "Доход от сдачи в аренду"
                        },
                        new
                        {
                            Id = new Guid("e71faff8-36c7-40c2-8658-4f35fe8db07c"),
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
                            Id = new Guid("ec4a5d82-07bb-4ae5-b1a0-a7df93133069"),
                            Balance = 1000m,
                            CurrencyId = new Guid("bfcd0e34-dcbc-45a6-bcee-e268b31169f4"),
                            Name = "Основной кошелек"
                        },
                        new
                        {
                            Id = new Guid("580b715c-c053-4de6-9d82-5ebd5c1f3d05"),
                            Balance = 500m,
                            CurrencyId = new Guid("d006a907-7995-4ffb-91ed-2b067524686d"),
                            Name = "Сбережения в долларах"
                        },
                        new
                        {
                            Id = new Guid("7f5a1cbd-2bb8-490d-89db-25b2d58a7b5d"),
                            Balance = 500m,
                            CurrencyId = new Guid("810efbfd-2c40-4586-bc88-f0828ecdeb73"),
                            Name = "Сбережения в евро"
                        });
                });

            modelBuilder.Entity("WpfAppFinanse.Models.Transaction", b =>
                {
                    b.HasOne("WpfAppFinanse.Models.Wallet", null)
                        .WithMany("Transactions")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WpfAppFinanse.Models.Wallet", b =>
                {
                    b.HasOne("WpfAppFinanse.Models.Currency", "Currency")
                        .WithMany()
                        .HasForeignKey("CurrencyId")
                        .OnDelete(DeleteBehavior.Cascade)
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
