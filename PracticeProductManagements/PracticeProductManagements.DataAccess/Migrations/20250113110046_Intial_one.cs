using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PracticeProductManagements.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Intial_one : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StockQuantity = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "TotalPrice", "UpdatedAt" },
                values: new object[] { new Guid("927b9d3d-d36e-4903-88e6-9babe5a013d9"), new DateTime(2025, 1, 13, 16, 30, 45, 860, DateTimeKind.Local).AddTicks(8629), "", "Pen", 67m, 588, 39396m, new DateTime(2025, 1, 13, 16, 30, 45, 860, DateTimeKind.Local).AddTicks(8869) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
