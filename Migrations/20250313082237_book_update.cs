using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookHaven.Migrations
{
    /// <inheritdoc />
    public partial class book_update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "isbn",
                table: "Books",
                newName: "isbn");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "isbn",
                table: "Books",
                newName: "i_s_b_n");
        }
    }
}
