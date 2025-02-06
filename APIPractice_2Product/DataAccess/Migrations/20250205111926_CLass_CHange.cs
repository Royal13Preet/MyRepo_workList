using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class CLass_CHange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StockQuantity = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 5, 16, 49, 25, 783, DateTimeKind.Local).AddTicks(2842), "High-end laptop", "Laptop", 1200.50m, 10, new DateTime(2025, 2, 5, 16, 49, 25, 784, DateTimeKind.Local).AddTicks(4212) },
                    { 2, new DateTime(2025, 2, 5, 16, 49, 25, 784, DateTimeKind.Local).AddTicks(4506), "Latest model", "Smartphone", 800.99m, 25, new DateTime(2025, 2, 5, 16, 49, 25, 784, DateTimeKind.Local).AddTicks(4508) },
                    { 3, new DateTime(2025, 2, 5, 16, 49, 25, 784, DateTimeKind.Local).AddTicks(4510), "Noise-cancelling", "Headphones", 150.75m, 50, new DateTime(2025, 2, 5, 16, 49, 25, 784, DateTimeKind.Local).AddTicks(4511) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
