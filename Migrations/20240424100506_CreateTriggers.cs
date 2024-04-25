using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WpfAppFinanse.Migrations
{
    /// <inheritdoc />
    public partial class CreateTriggers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Currencies_CurrencyId",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_CurrencyId",
                table: "Transactions");

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
                    { new Guid("36cf5f73-3ac4-438d-9080-e308f734a25a"), "EUR", "Евро" },
                    { new Guid("ad1ff7a5-bdfb-45ef-9f27-b884bbdeaea5"), "USD", "Доллар США" },
                    { new Guid("b43345f5-1270-4390-a807-627abfa8f466"), "UAH", "Гривна" }
                });

            migrationBuilder.InsertData(
                table: "ExpenseTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("c81e728d-8d43-407d-94b8-80037f77c3f4"), "Транспортные расходы" },
                    { new Guid("f8cc14c2-7b92-4e7b-87b1-aee4d1c1aad1"), "Продукты" }
                });

            migrationBuilder.InsertData(
                table: "IncomeTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("c4ca4238-4b5c-11e8-91e6-348599dc9991"), "Премия" },
                    { new Guid("eccbc87e-4b5c-11e8-b3db-408d5c9ff8f6"), "Зарплата" }
                });

            migrationBuilder.InsertData(
                table: "Wallets",
                columns: new[] { "Id", "Balance", "CurrencyId", "Name" },
                values: new object[,]
                {
                    { new Guid("25f112be-4e1c-4f89-bbbc-1c4ce9ecdeaf"), 1000m, new Guid("b43345f5-1270-4390-a807-627abfa8f466"), "Основной кошелек" },
                    { new Guid("67b5b583-b8cf-4f12-9a0e-cb5728d28daf"), 500m, new Guid("ad1ff7a5-bdfb-45ef-9f27-b884bbdeaea5"), "Сбережения в долларах" },
                    { new Guid("bf15d536-7b4d-43a9-a1d1-ef64a6728e16"), 500m, new Guid("36cf5f73-3ac4-438d-9080-e308f734a25a"), "Сбережения в евро" }
                });
          
    
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ExpenseTypes",
                keyColumn: "Id",
                keyValue: new Guid("c81e728d-8d43-407d-94b8-80037f77c3f4"));

            migrationBuilder.DeleteData(
                table: "ExpenseTypes",
                keyColumn: "Id",
                keyValue: new Guid("f8cc14c2-7b92-4e7b-87b1-aee4d1c1aad1"));

            migrationBuilder.DeleteData(
                table: "IncomeTypes",
                keyColumn: "Id",
                keyValue: new Guid("c4ca4238-4b5c-11e8-91e6-348599dc9991"));

            migrationBuilder.DeleteData(
                table: "IncomeTypes",
                keyColumn: "Id",
                keyValue: new Guid("eccbc87e-4b5c-11e8-b3db-408d5c9ff8f6"));

            migrationBuilder.DeleteData(
                table: "Wallets",
                keyColumn: "Id",
                keyValue: new Guid("25f112be-4e1c-4f89-bbbc-1c4ce9ecdeaf"));

            migrationBuilder.DeleteData(
                table: "Wallets",
                keyColumn: "Id",
                keyValue: new Guid("67b5b583-b8cf-4f12-9a0e-cb5728d28daf"));

            migrationBuilder.DeleteData(
                table: "Wallets",
                keyColumn: "Id",
                keyValue: new Guid("bf15d536-7b4d-43a9-a1d1-ef64a6728e16"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("36cf5f73-3ac4-438d-9080-e308f734a25a"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("ad1ff7a5-bdfb-45ef-9f27-b884bbdeaea5"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("b43345f5-1270-4390-a807-627abfa8f466"));

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

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_CurrencyId",
                table: "Transactions",
                column: "CurrencyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Currencies_CurrencyId",
                table: "Transactions",
                column: "CurrencyId",
                principalTable: "Currencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
