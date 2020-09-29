using Microsoft.EntityFrameworkCore.Migrations;

namespace falena.Data.Migrations
{
    public partial class TransactionFieldsAjustment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Employees_DeliveryManId",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "CurrentStock",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "DeliveryManId",
                table: "Transactions",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Employees_DeliveryManId",
                table: "Transactions",
                column: "DeliveryManId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Employees_DeliveryManId",
                table: "Transactions");

            migrationBuilder.AlterColumn<int>(
                name: "DeliveryManId",
                table: "Transactions",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CurrentStock",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Employees_DeliveryManId",
                table: "Transactions",
                column: "DeliveryManId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
