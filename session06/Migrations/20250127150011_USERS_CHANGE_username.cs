using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace session06.Migrations
{
    /// <inheritdoc />
    public partial class USERS_CHANGE_username : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "User_name",
                table: "Users",
                newName: "Username");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Users",
                newName: "User_name");
        }
    }
}
