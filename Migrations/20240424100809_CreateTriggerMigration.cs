using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WpfAppFinanse.Migrations
{
    /// <inheritdoc />
    public partial class CreateTriggerMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
        CREATE TRIGGER UpdateWalletBalanceOnUpdate
        AFTER UPDATE OF Amount ON Transactions
        FOR EACH ROW
        BEGIN
            UPDATE Wallets
            SET Balance = Balance - OLD.Amount + NEW.Amount
            WHERE Id = OLD.AccountId;
        END;

        CREATE TRIGGER UpdateWalletBalanceOnDelete
        AFTER DELETE ON Transactions
        FOR EACH ROW
        BEGIN
            UPDATE Wallets
            SET Balance = Balance - OLD.Amount
            WHERE Id = OLD.AccountId;
        END;
    ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
