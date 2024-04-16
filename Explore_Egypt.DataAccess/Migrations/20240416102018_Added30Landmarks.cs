using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Explore_Egypt.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Added30Landmarks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 30.144705031156899, 31.3403268229041 });

            migrationBuilder.InsertData(
                table: "Landmarks",
                columns: new[] { "Id", "CloseTime", "Description", "EgyptianStudentTicketPrice", "EgyptianTicketPrice", "ForeignStudentTicketPrice", "ForeignTicketPrice", "Latitude", "Longitude", "Name", "OpenTime" },
                values: new object[,]
                {
                    { 21, new TimeOnly(0, 0, 0), "Montazah Palace is a grand palace located in Alexandria, Egypt. It was built in the early 20th century and served as a summer residence for Egypt's royal family. The palace features stunning gardens, beachfront views, and elegant architectural design. It is surrounded by lush greenery and overlooks the Mediterranean Sea. Today, Montazah Palace is open to the public and serves as a popular tourist destination, offering visitors a chance to explore its opulent interiors and enjoy the picturesque surroundings.\r\n\r\n\r\n\r\n\r\n", 25.0m, 25.0m, 25.0m, 25.0m, 31.288778399841402, 30.015824382393902, "Montaza Palace", new TimeOnly(8, 0, 0) },
                    { 22, new TimeOnly(16, 0, 0), "Philae Temple is an ancient Egyptian temple complex located on an island in the Nile River, near Aswan, Egypt. It is dedicated to the goddess Isis and was originally located on Philae Island before being relocated to Agilkia Island due to the construction of the Aswan High Dam. The temple features stunning architectural elements, such as pylons, colonnades, and beautifully carved reliefs. It is renowned for its association with the cult of Isis and was an important pilgrimage site in ancient times. Philae Temple is a UNESCO World Heritage Site and a popular tourist attraction, offering visitors a glimpse into the religious practices and artistic achievements of ancient Egypt.\r\n\r\n\r\n\r\n\r\n", 20.0m, 40.0m, 230.0m, 450.0m, 24.012668110522998, 32.877539756904802, "Philae Temple", new TimeOnly(7, 0, 0) },
                    { 23, new TimeOnly(16, 0, 0), "The Hanging Church, also known as the Saint Virgin Mary's Coptic Orthodox Church, is a historic church located in Cairo, Egypt. It dates back to the 4th century and is one of the oldest churches in Egypt. The church is known for its unique architectural design and is built on top of the southern gatehouse of the Roman Babylon Fortress. It features beautiful artwork, intricate woodwork, and a suspended appearance. The Hanging Church is a significant religious and cultural landmark, attracting both locals and tourists interested in exploring Egypt's Coptic Christian heritage.\r\n\r\n\r\n\r\n\r\n", 0.0m, 0.0m, 0.0m, 0.0m, 30.005275993870399, 31.230183117340601, "Hanging Church", new TimeOnly(9, 0, 0) },
                    { 24, new TimeOnly(17, 0, 0), "The Ibn Tulun Mosque is a historic mosque located in Cairo, Egypt. It was built in the 9th century by the Abbasid governor Ahmed Ibn Tulun and is one of the oldest mosques in the city. The mosque showcases remarkable Islamic architecture, including a vast courtyard, a central sanctuary, and a tall minaret. It is known for its spiral staircase, which offers panoramic views of the surrounding area. The Ibn Tulun Mosque is a significant cultural and religious site, attracting visitors with its architectural beauty and historical importance.\r\n\r\n\r\n\r\n\r\n", 0.0m, 0.0m, 0.0m, 0.0m, 30.028721043927799, 31.249401444764501, "Ibn Tulun Mosque", new TimeOnly(9, 0, 0) },
                    { 25, new TimeOnly(9, 0, 0), "The Ibrahim Basha Statue is a prominent statue located in Egypt, specifically in the city of Cairo. The statue commemorates Ibrahim Pasha, an Ottoman governor who played a significant role in the modernization and development of Egypt during the 19th century. The statue depicts Ibrahim Pasha on horseback, portraying his leadership and military prowess. It stands as a symbol of his contributions to Egypt's political and social transformation. The statue is situated in a prominent public space, serving as a reminder of Ibrahim Pasha's legacy and the historical ties between Egypt and the Ottoman Empire. It attracts visitors who come to admire its artistic representation and learn about the historical figure it represents. The Ibrahim Basha Statue serves as a testament to the complex history and cultural heritage of Egypt.", 0.0m, 0.0m, 0.0m, 0.0m, 30.050775543229701, 31.247151015140499, "Statue of Ibrahim Pasha", new TimeOnly(9, 0, 0) },
                    { 26, new TimeOnly(17, 0, 0), "Karnak Temple is an expansive ancient Egyptian temple complex located in Luxor, Egypt. It is one of the largest religious sites in the world. The temple dates back to the Middle Kingdom and was continuously expanded by various pharaohs over the centuries. It features impressive structures, such as the Great Hypostyle Hall and the Avenue of Sphinxes. Karnak Temple is dedicated to the Theban triad of Amun, Mut, and Khonsu, and it offers visitors a remarkable glimpse into the grandeur and religious significance of ancient Egypt.", 20.0m, 40.0m, 230.0m, 450.0m, 25.718899913934699, 32.6572905586685, "Karnak", new TimeOnly(6, 0, 0) },
                    { 27, new TimeOnly(17, 0, 0), "Khnum Temple, located in Esna, Egypt, is an ancient Egyptian temple dedicated to the god Khnum. It was constructed during the Ptolemaic and Roman periods. The temple features well-preserved reliefs and carvings depicting scenes from ancient Egyptian mythology and religious rituals. Its hypostyle hall is notable for its intricately decorated columns. Khnum Temple is a significant archaeological site that offers insight into the religious practices and beliefs of ancient Egypt.", 10.0m, 20.0m, 40.0m, 80.0m, 25.293655331805802, 32.556101992752097, "Temple of Khnum", new TimeOnly(8, 0, 0) },
                    { 28, new TimeOnly(21, 0, 0), "Kom Ombo Temple is an ancient Egyptian temple situated in Kom Ombo, Egypt. It is a unique double temple dedicated to two gods: Sobek, the crocodile god, and Horus, the falcon-headed god. The temple showcases exquisite reliefs and carvings depicting mythological scenes and medical instruments. It has twin sanctuaries and a fascinating Nilometer used to measure the river's water level. Kom Ombo Temple offers visitors a captivating experience with its dual dedication and rich historical significance.", 20.0m, 40.0m, 180.0m, 360.0m, 24.452140085464201, 32.928431386456701, "Kom Ombo Temple", new TimeOnly(7, 0, 0) },
                    { 29, new TimeOnly(20, 0, 0), "Luxor Temple is an ancient Egyptian temple located in the city of Luxor, Egypt. It was built during the New Kingdom period and is dedicated to the god Amun. The temple features grand colonnades, impressive statues, and intricate reliefs depicting pharaohs and deities. It is renowned for its Avenue of Sphinxes, connecting it to the Karnak Temple. Luxor Temple is a significant archaeological site and a symbol of ancient Egyptian civilization, attracting visitors from around the world.", 20.0m, 40.0m, 200.0m, 400.0m, 25.699508013656299, 32.639052377855499, "Luxor Temple", new TimeOnly(6, 0, 0) },
                    { 30, new TimeOnly(17, 0, 0), "The Mohamed Ali Mosque, also known as the Alabaster Mosque, is a stunning mosque located in the Citadel of Cairo, Egypt. It was built in the 19th century by Muhammad Ali Pasha, the ruler of Egypt. The mosque showcases a striking Ottoman architectural style, with its prominent domes and minarets. Its interior features intricate decorations and beautiful stained glass windows. The Mohamed Ali Mosque offers panoramic views of Cairo and stands as a prominent landmark and religious site in the city.", 30.0m, 60.0m, 230.0m, 450.0m, 30.0287160707969, 31.259910248070401, "Mosque of Muhammad Ali", new TimeOnly(8, 0, 0) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.UpdateData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 25.744685288303302, 32.7515048302213 });
        }
    }
}
