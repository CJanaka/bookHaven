using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookHaven.Migrations
{
    /// <inheritdoc />
    public partial class uid_order : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "unique_id",
                table: "Orders",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "unique_id",
                table: "Orders");
        }
    }
}
