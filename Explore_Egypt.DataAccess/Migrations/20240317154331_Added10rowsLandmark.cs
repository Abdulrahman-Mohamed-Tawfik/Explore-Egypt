using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Explore_Egypt.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Added10rowsLandmark : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
			migrationBuilder.InsertData(
				table: "Landmarks",
				columns: new[] { "Id", "CloseTime", "Description", "EgyptianStudentTicketPrice", "EgyptianTicketPrice", "ForeignStudentTicketPrice", "ForeignTicketPrice", "Latitude", "Longitude", "Name", "OpenTime" },
				values: new object[,] {
                    { 1, new TimeOnly(15, 0, 0), "Abdeen Palace is a historic palace in Cairo, Egypt. Built in the late 19th century, it served as the main residence for Egypt's royal family until 1952. The palace features a blend of Turkish, Moorish, and European architectural styles. Today, it is a museum showcasing opulent interiors, royal artifacts, and beautifully landscaped gardens. Abdeen Palace is a popular tourist attraction, offering a glimpse into Egypt's rich history and royal heritage.", 10.0m, 20.0m, 50.0m, 100.0m, 30.041980595759298, 31.2467661930229, "Abdeen Palace", new TimeOnly(9, 0, 0) },
                    { 2, new TimeOnly(9, 0, 0), "Abu Simbel is an archaeological site in southern Egypt known for its rock-cut temples. The main attraction is the Great Temple of Ramses II, featuring colossal statues and intricate wall carvings. The smaller Temple of Hathor is dedicated to the goddess of love. The site was relocated in the 1960s to save it from flooding. Today, Abu Simbel is a UNESCO World Heritage site and a popular tourist destination", 10.0m, 30.0m, 300.0m, 600.0m, 29.9810966592981, 31.143216715340699, "Abu Simbel", new TimeOnly(9, 0, 0) },
                    { 3, new TimeOnly(16, 30, 0), "The Alexandria National Museum is a prominent museum located in Alexandria, Egypt. It was established in 2003 and is housed in a renovated Italian-style palace dating back to the early 20th century. The museum showcases a diverse collection of artifacts, spanning various historical periods and civilizations, including ancient Egyptian, Greek, Roman, and Islamic artifacts. Visitors can explore exhibits that highlight Alexandria's rich cultural heritage, including sculptures, jewelry, coins, and mummies. The museum also provides insight into the city's history, including its role as a center of trade and scholarship in the ancient world.", 5.0m, 20.0m, 90.0m, 180.0m, 31.200814890268202, 29.913219162632899, "Alexandria National Museum", new TimeOnly(9, 0, 0) },
				});

            

            migrationBuilder.InsertData(
                table: "Landmarks",
                columns: new[] { "Id", "CloseTime", "Description", "EgyptianStudentTicketPrice", "EgyptianTicketPrice", "ForeignStudentTicketPrice", "ForeignTicketPrice", "Latitude", "Longitude", "Name", "OpenTime" },
                values: new object[,]
                {
                    { 4, new TimeOnly(17, 0, 0), "Amir Taz Palace, also known as Beit El-Sennari, is a historic palace located in the heart of Cairo, Egypt. It was constructed during the 19th century under the reign of Khedive Ismail Pasha. The palace exhibits an exquisite blend of Ottoman and Islamic architectural styles, featuring intricate carvings, beautiful stained glass windows, and ornate decorations. Today, the palace serves as a cultural center and a venue for various art exhibitions, concerts, and cultural events. It stands as a testament to Egypt's rich architectural heritage and offers visitors a glimpse into the opulent lifestyle of the past.", 0.0m, 0.0m, 0.0m, 0.0m, 30.0323587576957, 31.253664308366901, "Amir Taz Palace", new TimeOnly(9, 0, 0) },
                    { 5, new TimeOnly(9, 0, 0), "Amr ibn al-As was a prominent Arab military commander and companion of Prophet Muhammad. He played a crucial role in the early Muslim conquests, including the conquest of Egypt in 641 CE. He founded the city of Fustat, which later became Cairo's capital. Amr ibn al-As introduced Islam to the region and governed Egypt for several years. His military and administrative achievements left a lasting impact on the expansion of Islam and the Arab world.", 0.0m, 0.0m, 0.0m, 0.0m, 30.010058193229, 31.2331094374956, "Amr Ibn Al-As", new TimeOnly(9, 0, 0) },
                    { 6, new TimeOnly(19, 0, 0), "Nestled in Aswan, Upper Egypt, the Nubian Museum stands as a testament to the rich history and captivating culture of Nubia. Built in response to the international campaign to save Nubian monuments from rising waters due to the Aswan Dam, the museum opened its doors in 1997", 10.0m, 30.0m, 150.0m, 300.0m, 24.085093977757701, 32.887073921252401, "Aswan Museum", new TimeOnly(9, 0, 0) },
                    { 7, new TimeOnly(9, 0, 0), "Bab al-Futuh is one of the ancient gates of the historic city of Cairo, Egypt. It was constructed during the 11th century and is known for its impressive architectural design. The gate is adorned with intricate carvings and decorative motifs. It served as a main entrance to the old city and is an important cultural and historical landmark. Visitors can admire the gate's grandeur and learn about Cairo's rich history and heritage.", 0.0m, 0.0m, 0.0m, 0.0m, 30.055467889869401, 31.263364602674301, "Bab al-Futuh", new TimeOnly(9, 0, 0) },
                    { 8, new TimeOnly(9, 0, 0), "Bab Zuweila is a historic gate located in the Old City of Cairo, Egypt. It was built in the 11th century and is one of the few remaining gates from the original city walls. The gate is renowned for its architectural beauty, featuring intricate carvings and decorative elements. It served as a significant entrance to the city and a defensive structure. Today, visitors can explore Bab Zuweila and enjoy panoramic views of Cairo from its elevated platforms.\r\n\r\n\r\n\r\n\r\n", 10.0m, 20.0m, 50.0m, 100.0m, 30.042721232524102, 31.257780701819801, "Bab Zuweila", new TimeOnly(9, 0, 0) },
                    { 9, new TimeOnly(16, 30, 0), "Baron Empain Palace, also known as the Heliopolis Palace, is a historic landmark located in Heliopolis, Cairo, Egypt. Built in the early 20th century by Belgian industrialist Baron Édouard Empain, it showcases a unique blend of architectural styles, including Hindu and Khmer influences. The palace's distinctive features include its pink hue and intricate detailing. It is considered a masterpiece of architecture and a symbol of Heliopolis. Today, the palace is open to visitors, offering a glimpse into its opulent interiors and the history of its construction.\r\n\r\n\r\n\r\n\r\n", 30.0m, 60.0m, 90.0m, 180.0m, 30.086699776612701, 31.330311897686499, "Baron Empain Palace", new TimeOnly(9, 0, 0) },
                    { 10, new TimeOnly(0, 0, 0), "The Cairo Tower is a prominent landmark and observation tower located in Cairo, Egypt. Standing at a height of 187 meters (614 feet), it offers panoramic views of the city's skyline and the Nile River. The tower was constructed in the 1960s and features a futuristic design inspired by lotus flowers and ancient Egyptian architecture. It is a popular tourist attraction and a symbol of modern Cairo. The tower also houses a revolving restaurant, offering a unique dining experience with stunning views.\r\n\r\n\r\n\r\n\r\n", 70.0m, 70.0m, 250.0m, 250.0m, 30.0459258601981, 31.224288606195099, "Cairo Tower", new TimeOnly(9, 0, 0) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CloseTime", "Description", "EgyptianStudentTicketPrice", "EgyptianTicketPrice", "ForeignStudentTicketPrice", "ForeignTicketPrice", "Latitude", "Longitude", "Name", "OpenTime" },
                values: new object[] { new TimeOnly(10, 20, 30), "", 10.2m, 10.2m, 10.2m, 10.2m, 1.0, 1.0, "Action", new TimeOnly(10, 20, 30) });

            migrationBuilder.UpdateData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CloseTime", "Description", "EgyptianStudentTicketPrice", "EgyptianTicketPrice", "ForeignStudentTicketPrice", "ForeignTicketPrice", "Latitude", "Longitude", "Name", "OpenTime" },
                values: new object[] { new TimeOnly(10, 20, 30), "", 10.2m, 10.2m, 10.2m, 10.2m, 1.0, 1.0, "Action", new TimeOnly(10, 20, 30) });

            migrationBuilder.UpdateData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CloseTime", "Description", "EgyptianStudentTicketPrice", "EgyptianTicketPrice", "ForeignStudentTicketPrice", "ForeignTicketPrice", "Latitude", "Longitude", "Name", "OpenTime" },
                values: new object[] { new TimeOnly(10, 20, 30), "", 10.2m, 10.2m, 10.2m, 10.2m, 1.0, 1.0, "Action", new TimeOnly(10, 20, 30) });
        }
    }
}
