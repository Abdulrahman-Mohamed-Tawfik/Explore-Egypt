using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Explore_Egypt.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "security",
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "57d40a22-73af-41b0-a995-5031342b2a6b", "9f7d091f-dd72-46cf-9ff3-32d22201ae36", "admin", "ADMIN" },
                    { "fcc61e5c-bc67-4d42-84a0-a307364d4b65", "7389f98f-7d52-41b9-977d-2994d8e3fbbb", "user", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "57d40a22-73af-41b0-a995-5031342b2a6b");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "fcc61e5c-bc67-4d42-84a0-a307364d4b65");
        }
    }
}
