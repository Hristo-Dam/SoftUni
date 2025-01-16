using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopDatabase.Migrations
{
    /// <inheritdoc />
    public partial class Updated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PurchaseId",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Products",
                newName: "Category");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Shops",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Purchases",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfPurchase",
                table: "Purchases",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsAlive",
                table: "Customers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_Purchases_CustomerId",
                table: "Purchases",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Purchases_Customers_CustomerId",
                table: "Purchases",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Purchases_Customers_CustomerId",
                table: "Purchases");

            migrationBuilder.DropIndex(
                name: "IX_Purchases_CustomerId",
                table: "Purchases");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Shops");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Purchases");

            migrationBuilder.DropColumn(
                name: "DateOfPurchase",
                table: "Purchases");

            migrationBuilder.DropColumn(
                name: "IsAlive",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "Category",
                table: "Products",
                newName: "Type");

            migrationBuilder.AddColumn<int>(
                name: "PurchaseId",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
