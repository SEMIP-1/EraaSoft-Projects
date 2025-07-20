using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace P02_SalesDatabase.Migrations
{
    /// <inheritdoc />
    public partial class ProductsAddColumnDescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stores_Sales_SaleId",
                table: "Stores");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Sales_TempId",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "TempId",
                table: "Sales");

            migrationBuilder.AlterColumn<string>(
                name: "Quantity",
                table: "Products",
                type: "nvarchar(250)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Stores_Sales_SaleId",
                table: "Stores",
                column: "SaleId",
                principalTable: "Sales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stores_Sales_SaleId",
                table: "Stores");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "TempId",
                table: "Sales",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Quantity",
                table: "Products",
                type: "nvarchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Sales_TempId",
                table: "Sales",
                column: "TempId");

            migrationBuilder.AddForeignKey(
                name: "FK_Stores_Sales_SaleId",
                table: "Stores",
                column: "SaleId",
                principalTable: "Sales",
                principalColumn: "TempId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
