using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WpfAppFinanse.Migrations
{
    /// <inheritdoc />
    public partial class StructuralChangesToWallets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ExpenseTypes",
                keyColumn: "Id",
                keyValue: new Guid("18b851c6-965f-4e44-9cc6-121bc1b67fc5"));

            migrationBuilder.DeleteData(
                table: "ExpenseTypes",
                keyColumn: "Id",
                keyValue: new Guid("338e3528-e08b-44a1-adba-0b0219f4585e"));

            migrationBuilder.DeleteData(
                table: "ExpenseTypes",
                keyColumn: "Id",
                keyValue: new Guid("3d91795d-3765-4ea9-a2e4-0aba29d71290"));

            migrationBuilder.DeleteData(
                table: "ExpenseTypes",
                keyColumn: "Id",
                keyValue: new Guid("5130d631-21a1-47bb-8b33-e16f365c2903"));

            migrationBuilder.DeleteData(
                table: "ExpenseTypes",
                keyColumn: "Id",
                keyValue: new Guid("55355db4-2603-4152-8eb4-5947fc8d0ab8"));

            migrationBuilder.DeleteData(
                table: "ExpenseTypes",
                keyColumn: "Id",
                keyValue: new Guid("713d05dd-c506-4b45-afd3-08639c567457"));

            migrationBuilder.DeleteData(
                table: "ExpenseTypes",
                keyColumn: "Id",
                keyValue: new Guid("afec554d-376b-4f18-85ad-00a6037e6dbb"));

            migrationBuilder.DeleteData(
                table: "ExpenseTypes",
                keyColumn: "Id",
                keyValue: new Guid("c38a9160-d2dc-484c-98f9-67cd453db2c3"));

            migrationBuilder.DeleteData(
                table: "IncomeTypes",
                keyColumn: "Id",
                keyValue: new Guid("7a69b145-5a55-436b-9dc6-64ee2c86069b"));

            migrationBuilder.DeleteData(
                table: "IncomeTypes",
                keyColumn: "Id",
                keyValue: new Guid("c3d00078-f5ff-4e1d-8828-9edef21a0ac6"));

            migrationBuilder.DeleteData(
                table: "IncomeTypes",
                keyColumn: "Id",
                keyValue: new Guid("df97e169-f0d1-4d63-bf63-c6ce6c7e445f"));

            migrationBuilder.DeleteData(
                table: "IncomeTypes",
                keyColumn: "Id",
                keyValue: new Guid("fbf99a2d-fd3a-43a0-9c6a-6c0b8d18dbe4"));

            migrationBuilder.DeleteData(
                table: "Wallets",
                keyColumn: "Id",
                keyValue: new Guid("2e8d2651-1b1c-4239-8163-bbfba86d28d1"));

            migrationBuilder.DeleteData(
                table: "Wallets",
                keyColumn: "Id",
                keyValue: new Guid("9bf3da47-32ad-4165-af07-c7529ea07591"));

            migrationBuilder.DeleteData(
                table: "Wallets",
                keyColumn: "Id",
                keyValue: new Guid("fd1f9c32-0c9a-477f-95a3-ced11224ae3c"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("6c3149ca-0241-4bfc-ae2d-4e977c9e38ca"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("cba910d2-5583-4584-b5ff-9d86b42c96d6"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("d60b564c-2045-42e2-b04f-ef1197a38c2b"));

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("63b5776e-0a4d-4b63-b05b-71142d0c3f6f"), "UAH", "Гривна" },
                    { new Guid("a8f8d164-9c4a-4ccc-b01e-ac749362360e"), "USD", "Доллар США" },
                    { new Guid("fe676197-6a55-4f85-81f2-82e221d1dd7d"), "EUR", "Евро" }
                });

            migrationBuilder.InsertData(
                table: "ExpenseTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0f31c16f-bebb-4793-a9a3-34932c176ed8"), "Развлечения" },
                    { new Guid("239517eb-81d4-46ba-a820-27473a95bfff"), "Продукты" },
                    { new Guid("30185235-2f3c-4c42-89bc-2697f4433935"), "Покупка одежды" },
                    { new Guid("62d38b74-2a34-4098-8d2c-81642f69b951"), "Коммунальные расходы" },
                    { new Guid("8cea737f-4fac-428f-ae98-e8b2ea9057cf"), "Транспортные расходы" },
                    { new Guid("b04ae513-caf8-4016-8323-1df3aa73d762"), "Ремонт" },
                    { new Guid("cfe4d61e-b5cd-4ce4-9e9f-040bc5e7de30"), "Косметологические услуги" },
                    { new Guid("e56e33b0-8cc5-4cb9-8d36-155304cbbc37"), "Хозяйственные расходы" }
                });

            migrationBuilder.InsertData(
                table: "IncomeTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("30ae08be-17f3-488e-b22b-8b584c65eee9"), "Зарплата" },
                    { new Guid("40c18011-65ac-499b-9629-d83c2a29cf2c"), "Подарок" },
                    { new Guid("92a21ef3-b61b-45f3-bb95-4d5d0ddd7c73"), "Премия" },
                    { new Guid("df0309db-db47-4c30-865d-99a39130193a"), "Доход от сдачи в аренду" }
                });

            migrationBuilder.InsertData(
                table: "Wallets",
                columns: new[] { "Id", "Balance", "CurrencyId", "Name" },
                values: new object[,]
                {
                    { new Guid("2d29d2c2-7c0e-4df5-8252-e664ca9192bf"), 500m, new Guid("a8f8d164-9c4a-4ccc-b01e-ac749362360e"), "Сбережения в долларах" },
                    { new Guid("cc0dea41-8151-420d-bfbe-c316d2e59808"), 1000m, new Guid("63b5776e-0a4d-4b63-b05b-71142d0c3f6f"), "Основной кошелек" },
                    { new Guid("e8cda700-4b85-469b-878f-5bdc69f8d6f1"), 500m, new Guid("fe676197-6a55-4f85-81f2-82e221d1dd7d"), "Сбережения в евро" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ExpenseTypes",
                keyColumn: "Id",
                keyValue: new Guid("0f31c16f-bebb-4793-a9a3-34932c176ed8"));

            migrationBuilder.DeleteData(
                table: "ExpenseTypes",
                keyColumn: "Id",
                keyValue: new Guid("239517eb-81d4-46ba-a820-27473a95bfff"));

            migrationBuilder.DeleteData(
                table: "ExpenseTypes",
                keyColumn: "Id",
                keyValue: new Guid("30185235-2f3c-4c42-89bc-2697f4433935"));

            migrationBuilder.DeleteData(
                table: "ExpenseTypes",
                keyColumn: "Id",
                keyValue: new Guid("62d38b74-2a34-4098-8d2c-81642f69b951"));

            migrationBuilder.DeleteData(
                table: "ExpenseTypes",
                keyColumn: "Id",
                keyValue: new Guid("8cea737f-4fac-428f-ae98-e8b2ea9057cf"));

            migrationBuilder.DeleteData(
                table: "ExpenseTypes",
                keyColumn: "Id",
                keyValue: new Guid("b04ae513-caf8-4016-8323-1df3aa73d762"));

            migrationBuilder.DeleteData(
                table: "ExpenseTypes",
                keyColumn: "Id",
                keyValue: new Guid("cfe4d61e-b5cd-4ce4-9e9f-040bc5e7de30"));

            migrationBuilder.DeleteData(
                table: "ExpenseTypes",
                keyColumn: "Id",
                keyValue: new Guid("e56e33b0-8cc5-4cb9-8d36-155304cbbc37"));

            migrationBuilder.DeleteData(
                table: "IncomeTypes",
                keyColumn: "Id",
                keyValue: new Guid("30ae08be-17f3-488e-b22b-8b584c65eee9"));

            migrationBuilder.DeleteData(
                table: "IncomeTypes",
                keyColumn: "Id",
                keyValue: new Guid("40c18011-65ac-499b-9629-d83c2a29cf2c"));

            migrationBuilder.DeleteData(
                table: "IncomeTypes",
                keyColumn: "Id",
                keyValue: new Guid("92a21ef3-b61b-45f3-bb95-4d5d0ddd7c73"));

            migrationBuilder.DeleteData(
                table: "IncomeTypes",
                keyColumn: "Id",
                keyValue: new Guid("df0309db-db47-4c30-865d-99a39130193a"));

            migrationBuilder.DeleteData(
                table: "Wallets",
                keyColumn: "Id",
                keyValue: new Guid("2d29d2c2-7c0e-4df5-8252-e664ca9192bf"));

            migrationBuilder.DeleteData(
                table: "Wallets",
                keyColumn: "Id",
                keyValue: new Guid("cc0dea41-8151-420d-bfbe-c316d2e59808"));

            migrationBuilder.DeleteData(
                table: "Wallets",
                keyColumn: "Id",
                keyValue: new Guid("e8cda700-4b85-469b-878f-5bdc69f8d6f1"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("63b5776e-0a4d-4b63-b05b-71142d0c3f6f"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("a8f8d164-9c4a-4ccc-b01e-ac749362360e"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("fe676197-6a55-4f85-81f2-82e221d1dd7d"));

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("6c3149ca-0241-4bfc-ae2d-4e977c9e38ca"), "USD", "Доллар США" },
                    { new Guid("cba910d2-5583-4584-b5ff-9d86b42c96d6"), "EUR", "Евро" },
                    { new Guid("d60b564c-2045-42e2-b04f-ef1197a38c2b"), "UAH", "Гривна" }
                });

            migrationBuilder.InsertData(
                table: "ExpenseTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("18b851c6-965f-4e44-9cc6-121bc1b67fc5"), "Транспортные расходы" },
                    { new Guid("338e3528-e08b-44a1-adba-0b0219f4585e"), "Развлечения" },
                    { new Guid("3d91795d-3765-4ea9-a2e4-0aba29d71290"), "Продукты" },
                    { new Guid("5130d631-21a1-47bb-8b33-e16f365c2903"), "Коммунальные расходы" },
                    { new Guid("55355db4-2603-4152-8eb4-5947fc8d0ab8"), "Хозяйственные расходы" },
                    { new Guid("713d05dd-c506-4b45-afd3-08639c567457"), "Ремонт" },
                    { new Guid("afec554d-376b-4f18-85ad-00a6037e6dbb"), "Покупка одежды" },
                    { new Guid("c38a9160-d2dc-484c-98f9-67cd453db2c3"), "Косметологические услуги" }
                });

            migrationBuilder.InsertData(
                table: "IncomeTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("7a69b145-5a55-436b-9dc6-64ee2c86069b"), "Подарок" },
                    { new Guid("c3d00078-f5ff-4e1d-8828-9edef21a0ac6"), "Доход от сдачи в аренду" },
                    { new Guid("df97e169-f0d1-4d63-bf63-c6ce6c7e445f"), "Зарплата" },
                    { new Guid("fbf99a2d-fd3a-43a0-9c6a-6c0b8d18dbe4"), "Премия" }
                });

            migrationBuilder.InsertData(
                table: "Wallets",
                columns: new[] { "Id", "Balance", "CurrencyId", "Name" },
                values: new object[,]
                {
                    { new Guid("2e8d2651-1b1c-4239-8163-bbfba86d28d1"), 500m, new Guid("cba910d2-5583-4584-b5ff-9d86b42c96d6"), "Сбережения в евро" },
                    { new Guid("9bf3da47-32ad-4165-af07-c7529ea07591"), 1000m, new Guid("d60b564c-2045-42e2-b04f-ef1197a38c2b"), "Основной кошелек" },
                    { new Guid("fd1f9c32-0c9a-477f-95a3-ced11224ae3c"), 500m, new Guid("6c3149ca-0241-4bfc-ae2d-4e977c9e38ca"), "Сбережения в долларах" }
                });
        }
    }
}
