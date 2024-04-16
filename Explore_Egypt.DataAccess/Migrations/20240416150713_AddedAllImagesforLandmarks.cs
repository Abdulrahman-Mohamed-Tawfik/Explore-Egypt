using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Explore_Egypt.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedAllImagesforLandmarks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "LandmarkImages",
                columns: new[] { "Id", "LandmarkId", "Url" },
                values: new object[,]
                {
                    { 27, 21, "\\landmarkImages\\Montaza_Palace\\1.jpg" },
                    { 31, 22, "\\landmarkImages\\Philae_Temple\\1.jpg" },
                    { 32, 23, "\\landmarkImages\\Hanging_Church\\1.jpg" },
                    { 33, 24, "\\landmarkImages\\Ibn_Tulun_Mosque\\1.jpg" },
                    { 34, 25, "\\landmarkImages\\Statue_of_Ibrahim_Pasha\\1.jpg" },
                    { 35, 26, "\\landmarkImages\\Karnak\\1.jpg" },
                    { 36, 27, "\\landmarkImages\\Temple_of_Khnum\\1.jpg" },
                    { 37, 28, "\\landmarkImages\\Kom_Ombo_Temple\\1.jpg" },
                    { 38, 29, "\\landmarkImages\\Luxor_Temple\\1.jpg" },
                    { 39, 30, "\\landmarkImages\\Mosque_of_Muhammad_Ali\\1.jpg" },
                    { 40, 31, "\\landmarkImages\\Mostafa_Kamel_Museum\\1.jpg" },
                    { 41, 32, "\\landmarkImages\\Museum_of_Islamic_Arts\\1.jpg" },
                    { 42, 33, "\\landmarkImages\\Egypt_s_Renaissance_Statue\\1.jpg" },
                    { 43, 34, "\\landmarkImages\\October_War_Panorama\\1.jpg" },
                    { 44, 35, "\\landmarkImages\\Egyptian_Pyramids\\1.jpg" },
                    { 45, 36, "\\landmarkImages\\Citadel_of_Qaitbay\\1.jpg" },
                    { 46, 37, "\\landmarkImages\\Qasr_El_Nil\\1.jpg" },
                    { 47, 38, "\\landmarkImages\\Royal_Jewelry_Museum\\1.jpg" },
                    { 48, 39, "\\landmarkImages\\Saint_Catherine\\1.jpg" },
                    { 49, 40, "\\landmarkImages\\Saqqara\\1.jpg" },
                    { 50, 41, "\\landmarkImages\\Sphinx\\1.jpg" },
                    { 51, 42, "\\landmarkImages\\Mosque-Madrasa_of_Sultan_Hassan\\1.jpg" },
                    { 52, 43, "\\landmarkImages\\Roman_Amphitheatre_in_Alexandria\\1.jpg" },
                    { 53, 44, "\\landmarkImages\\Temple_of_Derr\\1.jpg" },
                    { 54, 45, "\\landmarkImages\\Valley_of_the_Kings\\1.jpg" },
                    { 55, 46, "\\landmarkImages\\White_Desert\\1.jpg" },
                    { 56, 47, "\\landmarkImages\\Kalabsha_Temple\\1.jpg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 56);
        }
    }
}
