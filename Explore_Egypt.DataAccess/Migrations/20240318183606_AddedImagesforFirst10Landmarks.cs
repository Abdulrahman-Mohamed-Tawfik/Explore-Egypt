using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Explore_Egypt.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedImagesforFirst10Landmarks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "LandmarkImages",
                columns: new[] { "Id", "LandmarkId", "Url" },
                values: new object[,]
                {
                    { 1, 1, "\\landmarkImages\\Abdeen_Palace\\1.jpg" },
                    { 2, 1, "\\landmarkImages\\Abdeen_Palace\\2.jpg" },
                    { 3, 2, "\\landmarkImages\\Abu_Simbel\\1.jpg" },
                    { 4, 2, "\\landmarkImages\\Abu_Simbel\\2.jpg" },
                    { 5, 3, "\\landmarkImages\\Alexandria_National_Museum\\1.jpg" },
                    { 6, 3, "\\landmarkImages\\Alexandria_National_Museum\\2.jpg" },
                    { 7, 4, "\\landmarkImages\\Amir_Taz_Palace\\1.jpg" },
                    { 8, 4, "\\landmarkImages\\Amir_Taz_Palace\\2.jpg" },
                    { 9, 5, "\\landmarkImages\\Amr_Ibn_Al-As\\1.jpg" },
                    { 10, 5, "\\landmarkImages\\Amr_Ibn_Al-As\\2.jpg" },
                    { 11, 6, "\\landmarkImages\\Aswan_Museum\\1.jpeg" },
                    { 12, 6, "\\landmarkImages\\Aswan_Museum\\2.jpeg" },
                    { 13, 7, "\\landmarkImages\\Bab-al-Futuh\\1.jpg" },
                    { 14, 7, "\\landmarkImages\\Bab-al-Futuh\\2.jpeg" },
                    { 15, 8, "\\landmarkImages\\Bab-Zuweila\\1.jpg" },
                    { 16, 8, "\\landmarkImages\\Bab-Zuweila\\2.jpg" },
                    { 17, 9, "\\landmarkImages\\Baron_Empain_Palace\\1.jpg" },
                    { 18, 10, "\\landmarkImages\\Cairo_Tower\\1.jpg" },
                    { 19, 10, "\\landmarkImages\\Cairo_Tower\\2.jpg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 19);
        }
    }
}
