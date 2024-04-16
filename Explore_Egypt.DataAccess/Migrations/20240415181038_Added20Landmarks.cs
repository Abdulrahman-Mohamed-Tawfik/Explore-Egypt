using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Explore_Egypt.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Added20Landmarks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Landmarks",
                columns: new[] { "Id", "CloseTime", "Description", "EgyptianStudentTicketPrice", "EgyptianTicketPrice", "ForeignStudentTicketPrice", "ForeignTicketPrice", "Latitude", "Longitude", "Name", "OpenTime" },
                values: new object[,]
                {
                    { 11, new TimeOnly(17, 0, 0), "Egypt is home to several significant museums showcasing its civilization. The Egyptian Museum in Cairo displays a vast collection of ancient artifacts, including Tutankhamun's treasures. The Luxor Museum highlights artifacts from the ancient city of Thebes. The Nubian Museum in Aswan focuses on Nubian culture and history. The Alexandria National Museum exhibits diverse artifacts from different historical periods. These museums offer invaluable insights into Egypt's rich civilization and heritage.", 40.0m, 80.0m, 250.0m, 500.0m, 30.008417609418, 31.248249387380302, "National Museum of Egyptian Civilization", new TimeOnly(9, 0, 0) },
                    { 12, new TimeOnly(17, 0, 0), "The Colossi of Memnon are two massive stone statues located on the west bank of the Nile River in Luxor, Egypt. Dating back to the 14th century BCE, they depict Pharaoh Amenhotep III seated on his throne. Standing at around 18 meters (60 feet) tall, they are impressive examples of ancient Egyptian art and craftsmanship. The statues are known for producing a musical sound at sunrise due to natural phenomena, which was believed to be the voice of the mythical Memnon. Today, the Colossi of Memnon attract visitors as iconic remnants of ancient Egypt's grandeur.", 0.0m, 0.0m, 0.0m, 0.0m, 25.720594393258999, 32.610531971223701, "Colossi of Memnon", new TimeOnly(6, 0, 0) },
                    { 13, new TimeOnly(17, 0, 0), "The Coptic Museum is a renowned museum located in Cairo, Egypt. It is dedicated to preserving and showcasing the rich heritage of Egypt's Coptic Christian community. The museum houses a vast collection of artifacts, including religious manuscripts, icons, textiles, and ancient Coptic artwork. Visitors can explore the museum's exhibits, which provide insights into Coptic history, culture, and art. The museum is an important cultural and historical destination, offering a unique perspective on Egypt's diverse religious and artistic traditions.", 10.0m, 20.0m, 120.0m, 230.0m, 30.005778097385001, 31.230398849392401, "Coptic Museum", new TimeOnly(9, 0, 0) },
                    { 14, new TimeOnly(17, 0, 0), "Deir el-Medina is an ancient Egyptian village located on the west bank of the Nile near Luxor. It was inhabited by the skilled artisans and workers who constructed royal tombs in the nearby Valley of the Kings. The village is known for its well-preserved structures, including houses, workshops, and a temple dedicated to the goddess Hathor. It offers valuable insights into the daily life, religious practices, and artistic skills of the ancient Egyptians. Deir el-Medina is a significant archaeological site that sheds light on the intricacies of ancient Egyptian society.", 0.0m, 0.0m, 0.0m, 0.0m, 25.7289015527221, 32.602222602306902, "Deir el-Medina", new TimeOnly(6, 0, 0) },
                    { 15, new TimeOnly(17, 0, 0), "Denderah, located in Upper Egypt, is an ancient Egyptian temple complex dedicated to the goddess Hathor. The centerpiece is the Temple of Hathor, known for its well-preserved and elaborate reliefs and carvings. The temple features a striking hypostyle hall, a sacred lake, and a birthing house. Denderah is renowned for its astronomical ceiling depicting the zodiac signs. It is a significant archaeological site and a testament to the architectural and artistic achievements of ancient Egypt.", 10.0m, 20.0m, 120.0m, 240.0m, 26.1676120463747, 32.656609106246201, "Denderah", new TimeOnly(7, 0, 0) },
                    { 16, new TimeOnly(18, 0, 0), "Edfu Temple is an ancient Egyptian temple located on the west bank of the Nile in Edfu, Egypt. It is dedicated to the falcon-headed god Horus and is one of the best-preserved temples in Egypt. The temple was built during the Ptolemaic period and showcases remarkable architecture, including a towering entrance pylon and a well-preserved hypostyle hall. Its walls are adorned with intricate reliefs depicting mythological scenes and rituals. Edfu Temple is a significant religious site and a testament to the grandeur of ancient Egyptian temple construction.", 20.0m, 40.0m, 230.0m, 450.0m, 24.977948234046298, 32.873369294153498, "Edfu Temple", new TimeOnly(6, 0, 0) },
                    { 17, new TimeOnly(17, 0, 0), "The Egyptian Museum, located in Cairo, Egypt, is one of the world's most significant museums dedicated to ancient Egyptian artifacts. It houses an extensive collection of over 120,000 artifacts, including the treasures of Tutankhamun. The museum showcases statues, mummies, jewelry, and other artifacts spanning several dynasties. Visitors can explore the museum's exhibits, which provide insights into ancient Egyptian history, culture, and art. The Egyptian Museum is a must-visit destination for anyone interested in experiencing the magnificence of Egypt's ancient civilization.", 10.0m, 30.0m, 230.0m, 450.0m, 30.048323478375501, 31.233662840341701, "Egyptian Museum", new TimeOnly(9, 0, 0) },
                    { 18, new TimeOnly(9, 0, 0), "Al-Azhar Mosque is a historic mosque located in Cairo, Egypt, and is one of the oldest Islamic universities in the world. It was founded in the 10th century and is renowned for its religious and educational significance. The mosque showcases exquisite Islamic architecture, including a beautiful courtyard and minarets. It serves as a center for Islamic learning and hosts religious lectures and conferences. Al-Azhar Mosque is a significant religious and cultural landmark, attracting visitors from around the world.\r\n\r\n\r\n\r\n\r\n", 0.0m, 0.0m, 0.0m, 0.0m, 30.045704450605999, 31.2626775702408, "Al-Azhar Mosque", new TimeOnly(9, 0, 0) },
                    { 19, new TimeOnly(18, 0, 0), "The Temple of Gerf Hussein is an ancient Egyptian temple located in Upper Nubia, near the Sudanese border. It was relocated during the construction of the Aswan High Dam. The temple was dedicated to the Nubian deity Dedun and was built during the reign of Ramses II. It features well-preserved reliefs depicting Ramses II and various religious scenes. The Temple of Gerf Hussein offers a glimpse into the ancient Egyptian presence in Nubia and the cultural exchange between the two regions.\r\n\r\n\r\n\r\n\r\n", 0.0m, 0.0m, 0.0m, 0.0m, 23.960170000000002, 32.867649999999998, "Temple of Gerf Hussein", new TimeOnly(6, 0, 0) },
                    { 20, new TimeOnly(9, 0, 0), "The El-Hussein Mosque is a historic mosque located in Cairo, Egypt. It is named after Hussein ibn Ali, the grandson of Prophet Muhammad. The mosque is considered a sacred site and holds religious significance for the Shia Muslim community. It features a beautiful courtyard, minarets, and a dome. The mosque is known for its intricate architectural details and is a popular destination for worshippers and visitors seeking spiritual solace. The El-Hussein Mosque stands as a symbol of religious devotion and cultural heritage in Cairo.\r\n\r\n\r\n\r\n\r\n", 0.0m, 0.0m, 0.0m, 0.0m, 25.744685288303302, 32.7515048302213, "Al-Hussein Mosque", new TimeOnly(9, 0, 0) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 20);
        }
    }
}
