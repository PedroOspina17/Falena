using Microsoft.EntityFrameworkCore.Migrations;

namespace falena.Data.Migrations
{
    public partial class TransactionFieldsAjustment3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Employees_SellerId",
                table: "Transactions");

            migrationBuilder.AlterColumn<int>(
                name: "SellerId",
                table: "Transactions",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Employees_SellerId",
                table: "Transactions",
                column: "SellerId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Employees_SellerId",
                table: "Transactions");

            migrationBuilder.AlterColumn<int>(
                name: "SellerId",
                table: "Transactions",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Employees_SellerId",
                table: "Transactions",
                column: "SellerId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
