using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookHaven.Migrations
{
    /// <inheritdoc />
    public partial class newNamingConvention : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "userName",
                table: "Users",
                newName: "user_name");

            migrationBuilder.RenameColumn(
                name: "passwordHash",
                table: "Users",
                newName: "password_hash");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "user_name",
                table: "Users",
                newName: "userName");

            migrationBuilder.RenameColumn(
                name: "password_hash",
                table: "Users",
                newName: "passwordHash");
        }
    }
}
