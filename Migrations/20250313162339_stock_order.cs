using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookHaven.Migrations
{
    /// <inheritdoc />
    public partial class stock_order : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Orders_Users_modified_by",
            //    table: "Orders");

            //migrationBuilder.DropIndex(
            //    name: "IX_Orders_modified_by",
            //    table: "Orders");

            migrationBuilder.AddColumn<int>(
                name: "user_id",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "stock_order_id",
                table: "OrderDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "StockOrders",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    supplier_id = table.Column<int>(type: "int", nullable: false),
                    created_date_time = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    modified_date_time = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    status = table.Column<string>(type: "longtext", nullable: false),
                    unique_id = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockOrders", x => x.id);
                    table.ForeignKey(
                        name: "FK_StockOrders_Suppliers_supplier_id",
                        column: x => x.supplier_id,
                        principalTable: "Suppliers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_user_id",
                table: "Orders",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_stock_order_id",
                table: "OrderDetails",
                column: "stock_order_id");

            migrationBuilder.CreateIndex(
                name: "IX_StockOrders_supplier_id",
                table: "StockOrders",
                column: "supplier_id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_StockOrders_stock_order_id",
                table: "OrderDetails",
                column: "stock_order_id",
                principalTable: "StockOrders",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_user_id",
                table: "Orders",
                column: "user_id",
                principalTable: "Users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_StockOrders_stock_order_id",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_user_id",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "StockOrders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_user_id",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_stock_order_id",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "user_id",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "stock_order_id",
                table: "OrderDetails");

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
    }
}
