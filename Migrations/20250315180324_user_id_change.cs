using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookHaven.Migrations
{
    /// <inheritdoc />
    public partial class user_id_change : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_user_id",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_user_id",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "user_id",
                table: "Orders");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_modified_by",
                table: "Orders",
                column: "modified_by");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_modified_by",
                table: "Orders",
                column: "modified_by",
                principalTable: "Users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_modified_by",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_modified_by",
                table: "Orders");

            migrationBuilder.AddColumn<int>(
                name: "user_id",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_user_id",
                table: "Orders",
                column: "user_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_user_id",
                table: "Orders",
                column: "user_id",
                principalTable: "Users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
