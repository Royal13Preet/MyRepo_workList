using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Secureuser.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class seed_data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "Role", "Username" },
                values: new object[] { 4, "$2a$11$.SQZiMQ55N46HRnb8H/TcOvYL9W6Ks.1X/xdV0fbed9JIecvwMj3S", "user", "abhi@gmail.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { 1, "$2a$11$usfAhMYx8EuP3eBfLa8LH.aCI/dic/n90/i4GBHydbUv549cbWeju", "admin", "Preet@gmail.com" },
                    { 2, "$2a$11$yJORHlEVzsMn07.W7126I.pR5HcGJ5ZbLllB5642aB2d0ncpjIuDW", "user", "khushi@gmail.com" }
                });
        }
    }
}
