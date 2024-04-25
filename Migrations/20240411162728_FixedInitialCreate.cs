using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WpfAppFinanse.Migrations
{
    /// <inheritdoc />
    public partial class FixedInitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Currencies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Code = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExpenseTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpenseTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IncomeTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncomeTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Wallets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Balance = table.Column<decimal>(type: "TEXT", nullable: false),
                    CurrencyId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wallets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Wallets_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Amount = table.Column<decimal>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    AccountId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Type = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transactions_Wallets_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Wallets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("810efbfd-2c40-4586-bc88-f0828ecdeb73"), "EUR", "Евро" },
                    { new Guid("bfcd0e34-dcbc-45a6-bcee-e268b31169f4"), "UAH", "Гривна" },
                    { new Guid("d006a907-7995-4ffb-91ed-2b067524686d"), "USD", "Доллар США" }
                });

            migrationBuilder.InsertData(
                table: "ExpenseTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("24290436-abfd-4d90-9eb3-80722dfc79ab"), "Покупка одежды" },
                    { new Guid("4d7ce7af-d928-496e-9ee8-4d730dae505d"), "Косметологические услуги" },
                    { new Guid("56e870d5-4d22-4dbc-861e-4fa43db1437d"), "Коммунальные расходы" },
                    { new Guid("73a106f0-578d-42c7-9399-e19becf1b2b1"), "Продукты" },
                    { new Guid("80b4b116-51cd-47f6-b570-1a4472a8f69b"), "Ремонт" },
                    { new Guid("8dc2f199-dbaa-45b0-bc82-e060e876b304"), "Хозяйственные расходы" },
                    { new Guid("90359ee4-9899-49a0-807b-56fe9dfca571"), "Развлечения" },
                    { new Guid("a608d8b1-4acb-4457-aea6-398a557b1d59"), "Транспортные расходы" }
                });

            migrationBuilder.InsertData(
                table: "IncomeTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("26dfefe4-85da-43fd-bec5-3a50a07fc2ef"), "Зарплата" },
                    { new Guid("2c657c8e-d2c4-49a5-99d6-2fc76244517f"), "Премия" },
                    { new Guid("c1a72389-0af7-43b0-829a-8df89168b8d6"), "Доход от сдачи в аренду" },
                    { new Guid("e71faff8-36c7-40c2-8658-4f35fe8db07c"), "Подарок" }
                });

            migrationBuilder.InsertData(
                table: "Wallets",
                columns: new[] { "Id", "Balance", "CurrencyId", "Name" },
                values: new object[,]
                {
                    { new Guid("580b715c-c053-4de6-9d82-5ebd5c1f3d05"), 500m, new Guid("d006a907-7995-4ffb-91ed-2b067524686d"), "Сбережения в долларах" },
                    { new Guid("7f5a1cbd-2bb8-490d-89db-25b2d58a7b5d"), 500m, new Guid("810efbfd-2c40-4586-bc88-f0828ecdeb73"), "Сбережения в евро" },
                    { new Guid("ec4a5d82-07bb-4ae5-b1a0-a7df93133069"), 1000m, new Guid("bfcd0e34-dcbc-45a6-bcee-e268b31169f4"), "Основной кошелек" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_AccountId",
                table: "Transactions",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Wallets_CurrencyId",
                table: "Wallets",
                column: "CurrencyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExpenseTypes");

            migrationBuilder.DropTable(
                name: "IncomeTypes");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Wallets");

            migrationBuilder.DropTable(
                name: "Currencies");
        }
    }
}
