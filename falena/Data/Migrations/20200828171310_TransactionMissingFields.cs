using Microsoft.EntityFrameworkCore.Migrations;

namespace falena.Data.Migrations
{
    public partial class TransactionMissingFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QurrentPrice",
                table: "TransactionDetails");

            migrationBuilder.AddColumn<double>(
                name: "DeliveryCost",
                table: "Transactions",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "DeliveryManId",
                table: "Transactions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "RealDeliveryCost",
                table: "Transactions",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "SellerId",
                table: "Transactions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "SubTotal",
                table: "Transactions",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "CurrentProductPrice",
                table: "TransactionDetails",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Incomes",
                table: "TransactionDetails",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "SellPrice",
                table: "TransactionDetails",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_DeliveryManId",
                table: "Transactions",
                column: "DeliveryManId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_SellerId",
                table: "Transactions",
                column: "SellerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Employees_DeliveryManId",
                table: "Transactions",
                column: "DeliveryManId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Employees_SellerId",
                table: "Transactions",
                column: "SellerId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Employees_DeliveryManId",
                table: "Transactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Employees_SellerId",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_DeliveryManId",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_SellerId",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "DeliveryCost",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "DeliveryManId",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "RealDeliveryCost",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "SellerId",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "SubTotal",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "CurrentProductPrice",
                table: "TransactionDetails");

            migrationBuilder.DropColumn(
                name: "Incomes",
                table: "TransactionDetails");

            migrationBuilder.DropColumn(
                name: "SellPrice",
                table: "TransactionDetails");

            migrationBuilder.AddColumn<double>(
                name: "QurrentPrice",
                table: "TransactionDetails",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
