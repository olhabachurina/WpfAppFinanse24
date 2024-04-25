using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WpfAppFinanse.Migrations
{
    /// <inheritdoc />
    public partial class AddWalletNavigationProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wallets_Currencies_CurrencyId",
                table: "Wallets");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Wallets_Currencies_CurrencyId",
                table: "Wallets",
                column: "CurrencyId",
                principalTable: "Currencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wallets_Currencies_CurrencyId",
                table: "Wallets");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Wallets_Currencies_CurrencyId",
                table: "Wallets",
                column: "CurrencyId",
                principalTable: "Currencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
