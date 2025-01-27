using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace session06.Migrations
{
    /// <inheritdoc />
    public partial class Product_schema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.EnsureSchema(
                name: "app");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "products",
                newSchema: "app");

            migrationBuilder.AddPrimaryKey(
                name: "PK_products",
                schema: "app",
                table: "products",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_products",
                schema: "app",
                table: "products");

            migrationBuilder.RenameTable(
                name: "products",
                schema: "app",
                newName: "Products");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");
        }
    }
}
