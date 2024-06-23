using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Explore_Egypt.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class RemovedAllOldLandmarks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 44);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Landmarks",
                columns: new[] { "Id", "CloseTime", "Description", "EgyptianStudentTicketPrice", "EgyptianTicketPrice", "ForeignStudentTicketPrice", "ForeignTicketPrice", "Latitude", "Longitude", "Name", "OpenTime" },
                values: new object[,]
                {
                    { 19, new TimeOnly(18, 0, 0), "The Temple of Gerf Hussein is an ancient Egyptian temple located in Upper Nubia, near the Sudanese border. It was relocated during the construction of the Aswan High Dam. The temple was dedicated to the Nubian deity Dedun and was built during the reign of Ramses II. It features well-preserved reliefs depicting Ramses II and various religious scenes. The Temple of Gerf Hussein offers a glimpse into the ancient Egyptian presence in Nubia and the cultural exchange between the two regions.\r\n\r\n\r\n\r\n\r\n", 0.0m, 0.0m, 0.0m, 0.0m, 23.960170000000002, 32.867649999999998, "Temple of Gerf Hussein", new TimeOnly(6, 0, 0) },
                    { 27, new TimeOnly(17, 0, 0), "Khnum Temple, located in Esna, Egypt, is an ancient Egyptian temple dedicated to the god Khnum. It was constructed during the Ptolemaic and Roman periods. The temple features well-preserved reliefs and carvings depicting scenes from ancient Egyptian mythology and religious rituals. Its hypostyle hall is notable for its intricately decorated columns. Khnum Temple is a significant archaeological site that offers insight into the religious practices and beliefs of ancient Egypt.", 10.0m, 20.0m, 40.0m, 80.0m, 25.293655331805802, 32.556101992752097, "Temple of Khnum", new TimeOnly(8, 0, 0) },
                    { 44, new TimeOnly(16, 0, 0), "The Temple of Derr is an ancient Egyptian temple located in Lower Nubia, now submerged under Lake Nasser due to the construction of the Aswan High Dam. It was dedicated to the god Amun and was built during the reign of Ramses II. The temple featured stunning reliefs depicting Ramses II and scenes from his military campaigns. Prior to the dam's construction, the temple was dismantled and relocated to its current location on the island of New Kalabsha. The Temple of Derr represents the efforts to preserve and relocate ancient Egyptian monuments threatened by modern development.", 0.0m, 0.0m, 0.0m, 0.0m, 22.732407869652, 32.262263849806999, "Temple of Derr", new TimeOnly(7, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "LandmarkImages",
                columns: new[] { "Id", "LandmarkId", "Url" },
                values: new object[,]
                {
                    { 29, 19, "\\landmarkImages\\Temple_of_Gerf_Hussein\\1.jpg" },
                    { 36, 27, "\\landmarkImages\\Temple_of_Khnum\\1.jpg" },
                    { 53, 44, "\\landmarkImages\\Temple_of_Derr\\1.jpg" }
                });
        }
    }
}
