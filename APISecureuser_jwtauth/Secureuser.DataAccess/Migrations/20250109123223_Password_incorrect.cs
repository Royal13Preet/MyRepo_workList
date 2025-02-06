using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Secureuser.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Password_incorrect : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$usfAhMYx8EuP3eBfLa8LH.aCI/dic/n90/i4GBHydbUv549cbWeju");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "$2a$11$yJORHlEVzsMn07.W7126I.pR5HcGJ5ZbLllB5642aB2d0ncpjIuDW");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "Preet@123");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "khushi@123");
        }
    }
}
