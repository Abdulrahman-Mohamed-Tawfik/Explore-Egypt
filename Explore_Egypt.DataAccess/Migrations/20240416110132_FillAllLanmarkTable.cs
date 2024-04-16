using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Explore_Egypt.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class FillAllLanmarkTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Landmarks",
                columns: new[] { "Id", "CloseTime", "Description", "EgyptianStudentTicketPrice", "EgyptianTicketPrice", "ForeignStudentTicketPrice", "ForeignTicketPrice", "Latitude", "Longitude", "Name", "OpenTime" },
                values: new object[,]
                {
                    { 31, new TimeOnly(17, 0, 0), "The Mostafa Kamel Museum is a museum in Cairo.It was officially opened in April 1956. Before that, it was a mausoleum containing the remains of the two leaders, Mustafa Kamel and Muhammad Farid. It also houses the remains of the intellectuals and activists, Abd al-Rahman al-Rafei and Fathi Radwan. The museum is built in the style of the Islamic mausoleum dome and includes two halls containing some of the belongings of the leader Mustafa Kamel represented in his books and letters in his handwriting, and some pictures of his friends and relatives, as well as some of his personal belongings of clothes, dining utensils, and his office room. The museum also includes oil paintings depicting the Denshway incident. On February 8, 2001, the museum reopened after being restored.", 5.0m, 10.0m, 50.0m, 100.0m, 30.029560986308599, 31.257227436188, "Mostafa Kamel Museum", new TimeOnly(9, 0, 0) },
                    { 32, new TimeOnly(17, 0, 0), "The Islamic Arts Museum in Egypt, located in Cairo, is a prominent museum dedicated to showcasing Islamic art and artifacts. It houses a vast collection of Islamic art pieces spanning various periods and regions. The museum exhibits intricate calligraphy, ceramics, textiles, metalwork, and more. Visitors can explore the museum's galleries, which provide a comprehensive view of the rich artistic heritage of the Islamic world. The Islamic Arts Museum in Egypt is a valuable cultural institution, preserving and promoting Islamic art and its significance.", 10.0m, 20.0m, 140.0m, 270.0m, 30.0447369750107, 31.252718977406701, "Museum of Islamic Arts", new TimeOnly(9, 0, 0) },
                    { 33, new TimeOnly(9, 0, 0), "Egypt's Renaissance Statue, also known as Nahdet Masr or The Awakening of Egypt, is a monumental sculpture located in Cairo, Egypt. It was unveiled in 2019 and stands at a height of 20 meters (66 feet). The statue symbolizes the modern renaissance and progress of Egypt. It depicts a man and a woman holding the Egyptian flag, representing unity and national pride. The statue has become an iconic symbol of Egypt's aspirations for development and advancement.", 0.0m, 0.0m, 0.0m, 0.0m, 30.0283395211917, 31.215928801836299, "Egypt's Renaissance Statue", new TimeOnly(9, 0, 0) },
                    { 34, new TimeOnly(21, 0, 0), "The October War Panorama is a historical exhibit located in Cairo, Egypt. It commemorates the events of the October War of 1973, also known as the Yom Kippur War. The panorama offers a panoramic view of the battlefield, featuring life-sized models, sound effects, and multimedia presentations. It provides visitors with an immersive experience, allowing them to relive the key moments and understand the significance of the war. The October War Panorama serves as a tribute to the valor and sacrifice of the Egyptian armed forces during the conflict.", 30.0m, 30.0m, 120.0m, 120.0m, 30.074287213695399, 31.3068091801549, "October War Panorama", new TimeOnly(9, 0, 0) },
                    { 35, new TimeOnly(17, 0, 0), "The Pyramids of Egypt are iconic ancient structures located on the outskirts of Cairo. They include the famous pyramids of Giza, such as the Great Pyramid of Khufu, Khafre Pyramid, and Menkaure Pyramid. Built as tombs for the pharaohs during the Old Kingdom period, they stand as a testament to the engineering and architectural prowess of ancient Egypt. The pyramids are surrounded by a vast necropolis and are accompanied by the Sphinx, a mythical creature with the head of a human and the body of a lion. The pyramids continue to captivate visitors from around the world, representing the enduring legacy of ancient Egyptian civilization.", 30.0m, 60.0m, 270.0m, 540.0m, 29.977352601113601, 31.1324969342758, "Egyptian Pyramids", new TimeOnly(7, 0, 0) },
                    { 36, new TimeOnly(20, 0, 0), "Qaitbay Castle, located in Alexandria, Egypt, is a historic fortress situated on the Mediterranean coastline. Built in the 15th century, it was commissioned by Sultan Al-Ashraf Qaitbay as a defensive stronghold against potential invaders. The castle boasts impressive architectural features, including sturdy walls, towers, and a central courtyard. It offers panoramic views of the sea and the city of Alexandria. Qaitbay Castle stands as a testament to Egypt's maritime history and is a popular tourist attraction, providing visitors with a glimpse into the region's rich architectural and military heritage.", 30.0m, 60.0m, 75.0m, 150.0m, 31.214023180978199, 29.885633678807501, "Citadel of Qaitbay", new TimeOnly(9, 0, 0) },
                    { 37, new TimeOnly(9, 0, 0), "Qasr El-Nil is a historic district located in Cairo, Egypt, along the banks of the Nile River. It is known for its significant role in Egyptian history and as a hub for cultural and political activities. The district is home to notable landmarks such as Tahrir Square and the Egyptian Museum. Qasr El-Nil is a vibrant area with bustling streets, shops, cafes, and restaurants. It serves as a gathering place for locals and visitors alike, offering a lively atmosphere and glimpses into the city's past and present.", 0.0m, 0.0m, 0.0m, 0.0m, 30.044057021392899, 31.231628662302601, "Qasr El Nile", new TimeOnly(9, 0, 0) },
                    { 38, new TimeOnly(17, 0, 0), "The Royal Jewelry Museum is a captivating museum located in Alexandria, Egypt. It showcases a stunning collection of exquisite jewelry and precious artifacts once owned by the royal family of Egypt. The museum is housed in a beautiful palace that was built in the early 20th century. Visitors can explore the opulent rooms filled with jewelry, crowns, tiaras, and other dazzling pieces. The museum offers a glimpse into the grandeur and luxury of Egypt's royal heritage, making it a must-visit destination for jewelry enthusiasts and history lovers.", 5.0m, 20.0m, 90.0m, 180.0m, 31.2406196888804, 29.9632878058699, "Royal Jewelry Museum", new TimeOnly(9, 0, 0) },
                    { 39, new TimeOnly(23, 30, 0), "St. Catherine's Monastery is a historic Christian monastery located at the foot of Mount Sinai in the Sinai Peninsula, Egypt. It is one of the oldest working monasteries in the world, dating back to the 6th century. The monastery is known for housing the Burning Bush, a significant biblical site. It features ancient religious manuscripts, icons, and a library with a vast collection of rare books. St. Catherine's Monastery attracts pilgrims and tourists, offering a glimpse into the rich religious and cultural heritage of the region.", 0.0m, 0.0m, 0.0m, 0.0m, 28.555995513522699, 33.976053366266299, "Saint Catherine", new TimeOnly(8, 45, 0) },
                    { 40, new TimeOnly(17, 0, 0), "The Saqqara Pyramid, also known as the Step Pyramid of Djoser, is an ancient Egyptian pyramid located in Saqqara, near Cairo, Egypt. It was built during the 27th century BCE and is considered one of the earliest colossal stone structures in Egypt. Designed by the architect Imhotep, the pyramid consists of six layers or steps, giving it a unique appearance. Saqqara Pyramid marks a significant transition in pyramid construction from simple mastabas to grand pyramids. It stands as a remarkable testament to the architectural achievements of ancient Egypt and attracts visitors interested in exploring its historical and archaeological significance.", 10.0m, 30.0m, 230.0m, 450.0m, 29.868495221505199, 31.216827353215301, "Saqqara", new TimeOnly(8, 0, 0) },
                    { 41, new TimeOnly(17, 0, 0), "The Great Sphinx is an iconic statue located in Giza, Egypt, near the pyramids. It is a colossal sculpture with the body of a lion and the head of a human, believed to represent the pharaoh Khafre. The Sphinx stands at approximately 73 meters long and 20 meters tall. It is shrouded in mystery and has captivated people for centuries with its enigmatic expression and symbolism. The Great Sphinx is a UNESCO World Heritage Site and remains a symbol of ancient Egypt's grandeur and architectural achievements.", 40.0m, 80.0m, 200.0m, 400.0m, 29.9752739473739, 31.137567265589599, "Sphinx", new TimeOnly(8, 0, 0) },
                    { 42, new TimeOnly(17, 0, 0), "The Sultan Hassan Mosque is a historic mosque located in Cairo, Egypt. It was built in the 14th century during the Mamluk period by Sultan Hassan. The mosque showcases impressive Mamluk architecture, featuring soaring minarets, grand domes, and intricate stone carvings. It includes a large prayer hall, a courtyard, and a mausoleum. The Sultan Hassan Mosque is known for its monumental size and elegant design, making it one of the most prominent mosques in Cairo. It stands as a testament to the rich architectural heritage of Islamic Egypt and is a significant cultural and religious site.", 0.0m, 0.0m, 90.0m, 180.0m, 30.032282865259202, 31.256173392802701, "Mosque-Madrasa of Sultan Hassan", new TimeOnly(9, 0, 0) },
                    { 43, new TimeOnly(17, 0, 0), "The Roman amphitheatre of Alexandria, also known as the Kom El Dikka amphitheatre, is an ancient Roman amphitheatre located in Alexandria, Egypt. It dates back to the 2nd century CE and was once part of a larger complex that included baths and a lecture hall. The amphitheatre could seat around 800 spectators and was used for various performances and events. Today, it stands as a remarkable archaeological site, with remnants of its seating, stage, and corridors still visible. The Roman amphitheatre of Alexandria offers a glimpse into the Roman influence on the city's history and cultural life.", 10.0m, 20.0m, 75.0m, 150.0m, 31.194653175457201, 29.904027937707699, "Roman Amphitheatre in Alexandria", new TimeOnly(9, 0, 0) },
                    { 44, new TimeOnly(16, 0, 0), "The Temple of Derr is an ancient Egyptian temple located in Lower Nubia, now submerged under Lake Nasser due to the construction of the Aswan High Dam. It was dedicated to the god Amun and was built during the reign of Ramses II. The temple featured stunning reliefs depicting Ramses II and scenes from his military campaigns. Prior to the dam's construction, the temple was dismantled and relocated to its current location on the island of New Kalabsha. The Temple of Derr represents the efforts to preserve and relocate ancient Egyptian monuments threatened by modern development.", 0.0m, 0.0m, 0.0m, 0.0m, 22.732407869652, 32.262263849806999, "Temple of Derr", new TimeOnly(7, 0, 0) },
                    { 45, new TimeOnly(17, 0, 0), "The Valley of the Kings is an archaeological site located near Luxor, Egypt. It served as the burial ground for pharaohs and powerful nobles during the New Kingdom period. The valley contains over 60 tombs, including the famous tomb of Tutankhamun. The tombs are adorned with intricate wall paintings and hieroglyphic inscriptions. The Valley of the Kings is a UNESCO World Heritage Site and offers visitors a unique opportunity to explore the royal tombs and gain insights into ancient Egyptian funerary practices and beliefs.", 30.0m, 60.0m, 300.0m, 600.0m, 25.740175346768901, 32.601410604736301, "Valley of the Kings", new TimeOnly(6, 0, 0) },
                    { 46, new TimeOnly(9, 0, 0), "The White Desert, also known as the Sahara el Beyda, is a mesmerizing natural wonder located in Egypt's Western Desert. It is characterized by surreal white rock formations shaped by erosion over millions of years. The landscape resembles a dream-like desert with unique formations resembling mushrooms, pillars, and other fascinating shapes. The White Desert is a popular destination for camping and stargazing, offering visitors a chance to witness the stark beauty of the desert under the moonlight. It is a remarkable testament to the incredible geological diversity found in Egypt's deserts.", 0.0m, 0.0m, 0.0m, 0.0m, 27.364055954160701, 28.1219488191139, "White Desert", new TimeOnly(9, 0, 0) },
                    { 47, new TimeOnly(16, 0, 0), "Kalabsha Temple, also known as the Temple of Mandulis, is an ancient Egyptian temple located near Aswan, Egypt. It was constructed during the Roman period and is dedicated to the Nubian sun god Mandulis. The temple features well-preserved reliefs and carvings depicting various deities and pharaohs. It showcases a traditional Egyptian architectural style with pylons, a hypostyle hall, and a sanctuary. Kalabsha Temple is a popular tourist attraction, offering visitors a chance to explore the history and religious practices of ancient Egypt in the southern region.", 5.0m, 10.0m, 75.0m, 150.0m, 23.960940940920398, 32.867408201691298, "Kalabsha Temple", new TimeOnly(7, 0, 0) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 47);
        }
    }
}
