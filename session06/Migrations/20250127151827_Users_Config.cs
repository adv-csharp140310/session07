using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace session06.Migrations
{
    /// <inheritdoc />
    public partial class Users_Config : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.EnsureSchema(
                name: "auth");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "users_xyz",
                newSchema: "auth");

            migrationBuilder.RenameColumn(
                name: "Email",
                schema: "auth",
                table: "users_xyz",
                newName: "email_xyz");

            migrationBuilder.AlterColumn<string>(
                name: "email_xyz",
                schema: "auth",
                table: "users_xyz",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_users_xyz",
                schema: "auth",
                table: "users_xyz",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_users_xyz",
                schema: "auth",
                table: "users_xyz");

            migrationBuilder.RenameTable(
                name: "users_xyz",
                schema: "auth",
                newName: "Users");

            migrationBuilder.RenameColumn(
                name: "email_xyz",
                table: "Users",
                newName: "Email");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");
        }
    }
}
