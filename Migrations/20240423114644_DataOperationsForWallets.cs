using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WpfAppFinanse.Migrations
{
    /// <inheritdoc />
    public partial class DataOperationsForWallets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("05c24331-37d1-4d51-b4f3-36d8a2f7ef65"), "UAH", "Гривна" },
                    { new Guid("1e3013b1-2f25-4495-a914-476c517556f0"), "USD", "Доллар США" },
                    { new Guid("39c862f3-2cf5-456e-a4b5-d4fba2d14fcd"), "EUR", "Евро" }
                });

            migrationBuilder.InsertData(
                table: "ExpenseTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("139b427e-50be-4b5d-bd53-24025a4d6aaa"), "Ремонт" },
                    { new Guid("32a93958-c40d-403b-bee9-394cd1258445"), "Продукты" },
                    { new Guid("5cfa2f0e-d3f9-420a-83a4-343b0e788897"), "Покупка одежды" },
                    { new Guid("64960659-8318-4af5-a810-915f1c08b2ae"), "Развлечения" },
                    { new Guid("85dd76e4-77e6-49bc-bd68-effecd7d65cc"), "Транспортные расходы" },
                    { new Guid("ce642da1-3549-488c-82e2-b2c2e6e83989"), "Хозяйственные расходы" },
                    { new Guid("d9fc3a34-311e-4673-9409-88c076af3c33"), "Коммунальные расходы" },
                    { new Guid("fee87ae8-9e7c-4b5f-8e65-357ce05098da"), "Косметологические услуги" }
                });

            migrationBuilder.InsertData(
                table: "IncomeTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("2d3e01bb-f614-4f49-8c52-120759a814c1"), "Зарплата" },
                    { new Guid("32335321-0571-4366-91a6-ca862c458476"), "Подарок" },
                    { new Guid("a7e24f5d-e78e-4fdd-8b99-27d67305bab6"), "Доход от сдачи в аренду" },
                    { new Guid("bd723229-67d0-4d27-b38f-19987304c0cb"), "Премия" }
                });

            migrationBuilder.InsertData(
                table: "Wallets",
                columns: new[] { "Id", "Balance", "CurrencyId", "Name" },
                values: new object[,]
                {
                    { new Guid("4fd672ea-3b20-477f-ba31-d07cd89c1eb2"), 500m, new Guid("39c862f3-2cf5-456e-a4b5-d4fba2d14fcd"), "Сбережения в евро" },
                    { new Guid("66b21f16-7564-48da-8c09-efd026202934"), 500m, new Guid("1e3013b1-2f25-4495-a914-476c517556f0"), "Сбережения в долларах" },
                    { new Guid("6aa47f55-9152-4960-9b2b-65f4a9903886"), 1000m, new Guid("05c24331-37d1-4d51-b4f3-36d8a2f7ef65"), "Основной кошелек" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ExpenseTypes",
                keyColumn: "Id",
                keyValue: new Guid("139b427e-50be-4b5d-bd53-24025a4d6aaa"));

            migrationBuilder.DeleteData(
                table: "ExpenseTypes",
                keyColumn: "Id",
                keyValue: new Guid("32a93958-c40d-403b-bee9-394cd1258445"));

            migrationBuilder.DeleteData(
                table: "ExpenseTypes",
                keyColumn: "Id",
                keyValue: new Guid("5cfa2f0e-d3f9-420a-83a4-343b0e788897"));

            migrationBuilder.DeleteData(
                table: "ExpenseTypes",
                keyColumn: "Id",
                keyValue: new Guid("64960659-8318-4af5-a810-915f1c08b2ae"));

            migrationBuilder.DeleteData(
                table: "ExpenseTypes",
                keyColumn: "Id",
                keyValue: new Guid("85dd76e4-77e6-49bc-bd68-effecd7d65cc"));

            migrationBuilder.DeleteData(
                table: "ExpenseTypes",
                keyColumn: "Id",
                keyValue: new Guid("ce642da1-3549-488c-82e2-b2c2e6e83989"));

            migrationBuilder.DeleteData(
                table: "ExpenseTypes",
                keyColumn: "Id",
                keyValue: new Guid("d9fc3a34-311e-4673-9409-88c076af3c33"));

            migrationBuilder.DeleteData(
                table: "ExpenseTypes",
                keyColumn: "Id",
                keyValue: new Guid("fee87ae8-9e7c-4b5f-8e65-357ce05098da"));

            migrationBuilder.DeleteData(
                table: "IncomeTypes",
                keyColumn: "Id",
                keyValue: new Guid("2d3e01bb-f614-4f49-8c52-120759a814c1"));

            migrationBuilder.DeleteData(
                table: "IncomeTypes",
                keyColumn: "Id",
                keyValue: new Guid("32335321-0571-4366-91a6-ca862c458476"));

            migrationBuilder.DeleteData(
                table: "IncomeTypes",
                keyColumn: "Id",
                keyValue: new Guid("a7e24f5d-e78e-4fdd-8b99-27d67305bab6"));

            migrationBuilder.DeleteData(
                table: "IncomeTypes",
                keyColumn: "Id",
                keyValue: new Guid("bd723229-67d0-4d27-b38f-19987304c0cb"));

            migrationBuilder.DeleteData(
                table: "Wallets",
                keyColumn: "Id",
                keyValue: new Guid("4fd672ea-3b20-477f-ba31-d07cd89c1eb2"));

            migrationBuilder.DeleteData(
                table: "Wallets",
                keyColumn: "Id",
                keyValue: new Guid("66b21f16-7564-48da-8c09-efd026202934"));

            migrationBuilder.DeleteData(
                table: "Wallets",
                keyColumn: "Id",
                keyValue: new Guid("6aa47f55-9152-4960-9b2b-65f4a9903886"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("05c24331-37d1-4d51-b4f3-36d8a2f7ef65"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("1e3013b1-2f25-4495-a914-476c517556f0"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("39c862f3-2cf5-456e-a4b5-d4fba2d14fcd"));

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
    }
}
