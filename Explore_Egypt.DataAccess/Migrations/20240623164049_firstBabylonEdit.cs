using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Explore_Egypt.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class firstBabylonEdit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "Url",
                value: "\\landmarkImages\\Babylon_Fortress\\1.jpg");

            migrationBuilder.UpdateData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "Url",
                value: "\\landmarkImages\\Babylon_Fortress\\2.jpg");

            migrationBuilder.UpdateData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Latitude", "Longitude", "Name" },
                values: new object[] { "Babylon Fortress is an Ancient Roman fortress on the eastern bank of the Nile Delta, located in the area known today as Old Cairo or Coptic Cairo. The fortress was built circa 300 AD by Emperor Diocletian in order to protect the entrance to an ancient canal, previously rebuilt by Trajan, that linked the Nile with the Red Sea.", 30.005701710553598, 31.229917245178701, "Babylon Fortress" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "Url",
                value: "\\landmarkImages\\Amir_Taz_Palace\\1.jpg");

            migrationBuilder.UpdateData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "Url",
                value: "\\landmarkImages\\Amir_Taz_Palace\\2.jpg");

            migrationBuilder.UpdateData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Latitude", "Longitude", "Name" },
                values: new object[] { "Amir Taz Palace, also known as Beit El-Sennari, is a historic palace located in the heart of Cairo, Egypt. It was constructed during the 19th century under the reign of Khedive Ismail Pasha. The palace exhibits an exquisite blend of Ottoman and Islamic architectural styles, featuring intricate carvings, beautiful stained glass windows, and ornate decorations. Today, the palace serves as a cultural center and a venue for various art exhibitions, concerts, and cultural events. It stands as a testament to Egypt's rich architectural heritage and offers visitors a glimpse into the opulent lifestyle of the past.", 30.0323587576957, 31.253664308366901, "Amir Taz Palace" });
        }
    }
}
