using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Thursday_ProductManagement.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class bymissly_deleted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { 40, "HHH", 987m });
        }
    }
}
