using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Explore_Egypt.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedImages20Landmarks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "LandmarkImages",
                columns: new[] { "Id", "LandmarkId", "Url" },
                values: new object[,]
                {
                    { 20, 11, "\\landmarkImages\\National_Museum_of Egyptian_Civilization\\1.jpg" },
                    { 21, 12, "\\landmarkImages\\Colossi_of_Memnon\\1.jpg" },
                    { 22, 13, "\\landmarkImages\\Coptic_Museum\\1.jpg" },
                    { 23, 14, "\\landmarkImages\\Deir_el-Medina\\1.jpeg" },
                    { 24, 15, "\\landmarkImages\\Denderah\\1.jpg" },
                    { 25, 16, "\\landmarkImages\\Edfu_Temple\\1.jpg" },
                    { 26, 17, "\\landmarkImages\\Egyptian_Museum\\1.jpg" },
                    { 28, 18, "\\landmarkImages\\Al-Azhar_Mosque\\1.jpg" },
                    { 29, 19, "\\landmarkImages\\Temple_of_Gerf_Hussein\\1.jpg" },
                    { 30, 20, "\\landmarkImages\\Al-Hussein_Mosque\\2.jpg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 30);
        }
    }
}
