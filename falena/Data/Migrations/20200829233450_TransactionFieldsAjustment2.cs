using Microsoft.EntityFrameworkCore.Migrations;

namespace falena.Data.Migrations
{
    public partial class TransactionFieldsAjustment2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Purchases",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Sales",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "CurrentStock",
                table: "Products",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrentStock",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "Purchases",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Sales",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
