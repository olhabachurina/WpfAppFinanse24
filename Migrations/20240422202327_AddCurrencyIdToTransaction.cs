using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WpfAppFinanse.Migrations
{
    /// <inheritdoc />
    public partial class AddCurrencyIdToTransaction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ExpenseTypes",
                keyColumn: "Id",
                keyValue: new Guid("0beff422-426f-45cf-ba06-9bdada7f6a91"));

            migrationBuilder.DeleteData(
                table: "ExpenseTypes",
                keyColumn: "Id",
                keyValue: new Guid("19cc9bd3-3576-496b-bc5b-e8d9652926ec"));

            migrationBuilder.DeleteData(
                table: "ExpenseTypes",
                keyColumn: "Id",
                keyValue: new Guid("31f8e27e-ca9b-4c4b-af0b-48b2b6e9eda7"));

            migrationBuilder.DeleteData(
                table: "ExpenseTypes",
                keyColumn: "Id",
                keyValue: new Guid("4d0784bc-37bb-4f3d-9f38-57df2da7c888"));

            migrationBuilder.DeleteData(
                table: "ExpenseTypes",
                keyColumn: "Id",
                keyValue: new Guid("4f997e5c-9de7-47b0-a72d-64446285e2ad"));

            migrationBuilder.DeleteData(
                table: "ExpenseTypes",
                keyColumn: "Id",
                keyValue: new Guid("7442d1cc-b2ce-4c86-8c9e-655ee4a550a2"));

            migrationBuilder.DeleteData(
                table: "ExpenseTypes",
                keyColumn: "Id",
                keyValue: new Guid("b139217f-a712-4177-a19e-37377ceb33e3"));

            migrationBuilder.DeleteData(
                table: "ExpenseTypes",
                keyColumn: "Id",
                keyValue: new Guid("b7d2ff4c-a966-4617-bca2-938ac430faa4"));

            migrationBuilder.DeleteData(
                table: "IncomeTypes",
                keyColumn: "Id",
                keyValue: new Guid("028af747-9bdf-4521-979d-3986de9ed50f"));

            migrationBuilder.DeleteData(
                table: "IncomeTypes",
                keyColumn: "Id",
                keyValue: new Guid("042ee4a5-ca4f-4fc5-93ee-6b3403ad0c38"));

            migrationBuilder.DeleteData(
                table: "IncomeTypes",
                keyColumn: "Id",
                keyValue: new Guid("1326a56c-5963-4567-9acc-06793bb71872"));

            migrationBuilder.DeleteData(
                table: "IncomeTypes",
                keyColumn: "Id",
                keyValue: new Guid("25cec823-8927-4f99-a496-d184bd94e0f2"));

            migrationBuilder.DeleteData(
                table: "Wallets",
                keyColumn: "Id",
                keyValue: new Guid("41e1a037-3ea8-4136-a610-457da4c05d12"));

            migrationBuilder.DeleteData(
                table: "Wallets",
                keyColumn: "Id",
                keyValue: new Guid("50246cbb-85c8-45b4-a3a6-d965411cd10b"));

            migrationBuilder.DeleteData(
                table: "Wallets",
                keyColumn: "Id",
                keyValue: new Guid("aad39169-2ce7-4c21-b796-200c352cca6a"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("7c6e6cef-10db-43d4-9eb8-83aa300fb082"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("8fb4d4fc-1d6b-4456-a789-49dbe8eabe2e"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("a9640692-3f66-42f2-b36a-b9e479c29fe0"));

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("3d568bc6-d4d0-456e-ae93-aa2195e0665f"), "USD", "Доллар США" },
                    { new Guid("755516e5-007f-4293-8d11-942ce1f42e59"), "EUR", "Евро" },
                    { new Guid("f987b28e-2058-4771-a465-07e97607e0b2"), "UAH", "Гривна" }
                });

            migrationBuilder.InsertData(
                table: "ExpenseTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("07242924-a4df-4458-88e4-5ac394f8b6f9"), "Транспортные расходы" },
                    { new Guid("339bcad4-1d31-4361-8c93-1cea973cb369"), "Ремонт" },
                    { new Guid("3d3ee1fd-325f-4dd6-8f54-1ad040657cb9"), "Коммунальные расходы" },
                    { new Guid("3fad1306-b14f-4546-b065-feccdaef9397"), "Развлечения" },
                    { new Guid("48e77f09-3b5a-4e0c-bf43-bfbd23035e02"), "Косметологические услуги" },
                    { new Guid("855e502d-d827-4c52-9d95-5ba6ca9ecdd6"), "Хозяйственные расходы" },
                    { new Guid("a1647d93-0859-4632-9c9a-ca66e8ebcaf2"), "Покупка одежды" },
                    { new Guid("f9ab033e-1b5e-48fa-9874-2a3f6447ebeb"), "Продукты" }
                });

            migrationBuilder.InsertData(
                table: "IncomeTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0569aa6e-4b8f-46d9-ae11-0d328269ad51"), "Зарплата" },
                    { new Guid("6572f78a-ee06-4bfd-b4c6-3652943e4db7"), "Доход от сдачи в аренду" },
                    { new Guid("d77b2450-f6d3-43e5-8413-0ac9b412ce3c"), "Подарок" },
                    { new Guid("fdd4ef98-fc77-499b-9c7f-f6977933425c"), "Премия" }
                });

            migrationBuilder.InsertData(
                table: "Wallets",
                columns: new[] { "Id", "Balance", "CurrencyId", "Name" },
                values: new object[,]
                {
                    { new Guid("c98f7bfe-8180-41c7-8193-2945e3f00b8e"), 500m, new Guid("755516e5-007f-4293-8d11-942ce1f42e59"), "Сбережения в евро" },
                    { new Guid("ca4fe26e-7727-4abc-8f4c-67e273893bac"), 500m, new Guid("3d568bc6-d4d0-456e-ae93-aa2195e0665f"), "Сбережения в долларах" },
                    { new Guid("fbc6e229-ee4d-4248-bb45-20b53d3c6d7b"), 1000m, new Guid("f987b28e-2058-4771-a465-07e97607e0b2"), "Основной кошелек" }
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValue: new Guid("07242924-a4df-4458-88e4-5ac394f8b6f9"));

            migrationBuilder.DeleteData(
                table: "ExpenseTypes",
                keyColumn: "Id",
                keyValue: new Guid("339bcad4-1d31-4361-8c93-1cea973cb369"));

            migrationBuilder.DeleteData(
                table: "ExpenseTypes",
                keyColumn: "Id",
                keyValue: new Guid("3d3ee1fd-325f-4dd6-8f54-1ad040657cb9"));

            migrationBuilder.DeleteData(
                table: "ExpenseTypes",
                keyColumn: "Id",
                keyValue: new Guid("3fad1306-b14f-4546-b065-feccdaef9397"));

            migrationBuilder.DeleteData(
                table: "ExpenseTypes",
                keyColumn: "Id",
                keyValue: new Guid("48e77f09-3b5a-4e0c-bf43-bfbd23035e02"));

            migrationBuilder.DeleteData(
                table: "ExpenseTypes",
                keyColumn: "Id",
                keyValue: new Guid("855e502d-d827-4c52-9d95-5ba6ca9ecdd6"));

            migrationBuilder.DeleteData(
                table: "ExpenseTypes",
                keyColumn: "Id",
                keyValue: new Guid("a1647d93-0859-4632-9c9a-ca66e8ebcaf2"));

            migrationBuilder.DeleteData(
                table: "ExpenseTypes",
                keyColumn: "Id",
                keyValue: new Guid("f9ab033e-1b5e-48fa-9874-2a3f6447ebeb"));

            migrationBuilder.DeleteData(
                table: "IncomeTypes",
                keyColumn: "Id",
                keyValue: new Guid("0569aa6e-4b8f-46d9-ae11-0d328269ad51"));

            migrationBuilder.DeleteData(
                table: "IncomeTypes",
                keyColumn: "Id",
                keyValue: new Guid("6572f78a-ee06-4bfd-b4c6-3652943e4db7"));

            migrationBuilder.DeleteData(
                table: "IncomeTypes",
                keyColumn: "Id",
                keyValue: new Guid("d77b2450-f6d3-43e5-8413-0ac9b412ce3c"));

            migrationBuilder.DeleteData(
                table: "IncomeTypes",
                keyColumn: "Id",
                keyValue: new Guid("fdd4ef98-fc77-499b-9c7f-f6977933425c"));

            migrationBuilder.DeleteData(
                table: "Wallets",
                keyColumn: "Id",
                keyValue: new Guid("c98f7bfe-8180-41c7-8193-2945e3f00b8e"));

            migrationBuilder.DeleteData(
                table: "Wallets",
                keyColumn: "Id",
                keyValue: new Guid("ca4fe26e-7727-4abc-8f4c-67e273893bac"));

            migrationBuilder.DeleteData(
                table: "Wallets",
                keyColumn: "Id",
                keyValue: new Guid("fbc6e229-ee4d-4248-bb45-20b53d3c6d7b"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("3d568bc6-d4d0-456e-ae93-aa2195e0665f"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("755516e5-007f-4293-8d11-942ce1f42e59"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("f987b28e-2058-4771-a465-07e97607e0b2"));

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("7c6e6cef-10db-43d4-9eb8-83aa300fb082"), "EUR", "Евро" },
                    { new Guid("8fb4d4fc-1d6b-4456-a789-49dbe8eabe2e"), "UAH", "Гривна" },
                    { new Guid("a9640692-3f66-42f2-b36a-b9e479c29fe0"), "USD", "Доллар США" }
                });

            migrationBuilder.InsertData(
                table: "ExpenseTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0beff422-426f-45cf-ba06-9bdada7f6a91"), "Косметологические услуги" },
                    { new Guid("19cc9bd3-3576-496b-bc5b-e8d9652926ec"), "Ремонт" },
                    { new Guid("31f8e27e-ca9b-4c4b-af0b-48b2b6e9eda7"), "Хозяйственные расходы" },
                    { new Guid("4d0784bc-37bb-4f3d-9f38-57df2da7c888"), "Коммунальные расходы" },
                    { new Guid("4f997e5c-9de7-47b0-a72d-64446285e2ad"), "Транспортные расходы" },
                    { new Guid("7442d1cc-b2ce-4c86-8c9e-655ee4a550a2"), "Покупка одежды" },
                    { new Guid("b139217f-a712-4177-a19e-37377ceb33e3"), "Развлечения" },
                    { new Guid("b7d2ff4c-a966-4617-bca2-938ac430faa4"), "Продукты" }
                });

            migrationBuilder.InsertData(
                table: "IncomeTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("028af747-9bdf-4521-979d-3986de9ed50f"), "Подарок" },
                    { new Guid("042ee4a5-ca4f-4fc5-93ee-6b3403ad0c38"), "Доход от сдачи в аренду" },
                    { new Guid("1326a56c-5963-4567-9acc-06793bb71872"), "Премия" },
                    { new Guid("25cec823-8927-4f99-a496-d184bd94e0f2"), "Зарплата" }
                });

            migrationBuilder.InsertData(
                table: "Wallets",
                columns: new[] { "Id", "Balance", "CurrencyId", "Name" },
                values: new object[,]
                {
                    { new Guid("41e1a037-3ea8-4136-a610-457da4c05d12"), 500m, new Guid("7c6e6cef-10db-43d4-9eb8-83aa300fb082"), "Сбережения в евро" },
                    { new Guid("50246cbb-85c8-45b4-a3a6-d965411cd10b"), 1000m, new Guid("8fb4d4fc-1d6b-4456-a789-49dbe8eabe2e"), "Основной кошелек" },
                    { new Guid("aad39169-2ce7-4c21-b796-200c352cca6a"), 500m, new Guid("a9640692-3f66-42f2-b36a-b9e479c29fe0"), "Сбережения в долларах" }
                });
        }
    }
}
