using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Explore_Egypt.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ReplacedOldSitesWithNewOnes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "Url",
                value: "\\landmarkImages\\Qubbet_el-Hawa\\1.jpg");

            migrationBuilder.UpdateData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "Url",
                value: "\\landmarkImages\\Bagawat\\1.jpg");

            migrationBuilder.UpdateData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "Url",
                value: "\\landmarkImages\\Bent_Pyramid\\1.jpg");

            migrationBuilder.UpdateData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 40,
                column: "Url",
                value: "\\landmarkImages\\Fatimid_Cemetery_in_Aswan\\1.jpg");

            migrationBuilder.UpdateData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 41,
                column: "Url",
                value: "\\landmarkImages\\Mausoleum_of_Aga_Khan\\1.jpg");

            migrationBuilder.UpdateData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 42,
                column: "Url",
                value: "\\landmarkImages\\Bibliotheca_Alexandrina\\1.jpg");

            migrationBuilder.UpdateData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 43,
                column: "Url",
                value: "\\landmarkImages\\Ramesseum\\1.jpg");

            migrationBuilder.UpdateData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 47,
                column: "Url",
                value: "\\landmarkImages\\Saint_George_Church_in_Coptic_Cairo\\1.jpg");

            migrationBuilder.UpdateData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CloseTime", "Description", "EgyptianStudentTicketPrice", "EgyptianTicketPrice", "ForeignStudentTicketPrice", "ForeignTicketPrice", "Latitude", "Longitude", "Name", "OpenTime" },
                values: new object[] { new TimeOnly(16, 0, 0), "Qubbet el-Hawa or \"Dome of the Wind\" is a site on the western bank of the Nile, opposite Aswan, that serves as the resting place of ancient nobles and priests from the Old and Middle Kingdoms of ancient Egypt. The necropolis in use from the Fourth Dynasty of Egypt until the Roman Period. The site was inscribed on the UNESCO World Heritage List in 1979 along with other examples of Upper Egyptian architecture, as part of the \"Nubian Monuments from Abu Simbel to Philae\" (despite Qubbet el-Hawa being neither Nubian, nor between Abu Simbel and Philae)", 0.0m, 0.0m, 0.0m, 0.0m, 24.102081032122399, 32.889182540116302, "Qubbet_el-Hawa", new TimeOnly(7, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CloseTime", "Description", "EgyptianStudentTicketPrice", "EgyptianTicketPrice", "ForeignStudentTicketPrice", "ForeignTicketPrice", "Latitude", "Longitude", "Name" },
                values: new object[] { new TimeOnly(9, 0, 0), "The El Bagawat cemetery is reported to be pre-historic and is one of the oldest Christian cemeteries in Egypt. Before Christianity was introduced into Egypt, it was a burial ground used by the non-Christians and later by the Christians. The chapels here are said to belong to both the eras. Coptic frescoes of the 3rd to the 7th century are found on the walls. There are 263 funerary chapels, of which the Chapel of the Exodus (first half of the 4th century) and Chapel of Peace (5th or 6th century) have the best-preserved frescoes, although fresco fragments can also be seen in Chapels 25, 172, 173, 175, and 210", 0.0m, 0.0m, 0.0m, 0.0m, 25.485655339240498, 30.5544592918462, "Bagawat" });

            migrationBuilder.UpdateData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CloseTime", "Description", "EgyptianStudentTicketPrice", "EgyptianTicketPrice", "ForeignStudentTicketPrice", "ForeignTicketPrice", "Latitude", "Longitude", "Name" },
                values: new object[] { new TimeOnly(16, 0, 0), "The Bent Pyramid is an ancient Egyptian pyramid located at the royal necropolis of Dahshur, approximately 40 kilometres (25 mi) south of Cairo, built under the Old Kingdom Pharaoh Sneferu (c. 2600 BC). A unique example of early pyramid development in Egypt, this was the second pyramid built by Sneferu.\r\nThe Bent Pyramid rises from the desert at a 54-degree inclination, but the top section (above 47 metres [154 ft]) is built at the shallower angle of 43 degrees, lending the pyramid a visibly \"bent\" appearance.", 5.0m, 10.0m, 75.0m, 150.0m, 29.7908757309152, 31.209451307806098, "Bent Pyramid" });

            migrationBuilder.UpdateData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CloseTime", "Description", "EgyptianStudentTicketPrice", "EgyptianTicketPrice", "ForeignStudentTicketPrice", "ForeignTicketPrice", "Latitude", "Longitude", "Name" },
                values: new object[] { new TimeOnly(9, 0, 0), "The Fatimid tombs, which some know as the \"Al-Anani\" cemetery, due to the presence of the marine cemetery in the Al-Anani area, length is about 2000 meters, and its width reaches approximately 500 meters, with an area equivalent to 238 acres, and it is divided into two parts. In addition to the marine cemetery, there is also the cemetery Tribal, located on the Aswan Reservoir Road, specifically next to the Nubian Museum, and is also divided into three sections, separating the north from the middle by the reservoir road, and separating the middle from the south by a trench, the northern includes tombs in the form of a box, and the middle includes shrines surrounded by modest tombs, while it includes The south has 20 large mausoleums, smaller ones, and modest tombs.", 0.0m, 0.0m, 0.0m, 0.0m, 24.078191293969098, 32.891674143897802, "Fatimid Cemetery in Aswan" });

            migrationBuilder.UpdateData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Description", "EgyptianStudentTicketPrice", "EgyptianTicketPrice", "ForeignStudentTicketPrice", "ForeignTicketPrice", "Latitude", "Longitude", "Name", "OpenTime" },
                values: new object[] { "The Mausoleum of Aga Khan is the mausoleum of Aga Khan III, Sir Sultan Muhammed Shah, who died in 1957. The mausoleum is located at Aswan along the Nile of Egypt, since Egypt was formerly the centre of power of the Fatimids, an Ismaili Shia dynasty. The construction of the mausoleum began in 1956 and ended in 1960. The Aga Khan's wife, Begum Om Habibeh Aga Khan, commissioned the construction of the mausoleum, which initially accepted tourists inside; however, the interior was closed off to the public in 1997. A red rose is laid on the Aga Khan's tomb every day – a practice first started by Begum Om Habibeh Aga Khan", 0.0m, 0.0m, 0.0m, 0.0m, 24.088369971692501, 32.878967307252999, "Mausoleum of Aga Khan", new TimeOnly(6, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CloseTime", "Description", "EgyptianStudentTicketPrice", "EgyptianTicketPrice", "ForeignStudentTicketPrice", "ForeignTicketPrice", "Latitude", "Longitude", "Name", "OpenTime" },
                values: new object[] { new TimeOnly(19, 0, 0), "The Bibliotheca Alexandrina is a major library and cultural center on the shore of the Mediterranean Sea in Alexandria, Egypt. It is a commemoration of the Library of Alexandria, once one of the largest libraries worldwide, which was lost in antiquity. The idea of reviving the old library dates back to 1974 when a committee set up by Alexandria University selected a plot of land for its new library. Construction work began in 1995, and after some US$220 million had been spent, the complex was officially inaugurated on 16 October 2002. In 2009, the library received a donation of 500,000 books from the Bibliothèque nationale de France (BnF). The gift makes the Bibliotheca Alexandrina the sixth-largest Francophone library in the world.", 5.0m, 10.0m, 75.0m, 150.0m, 31.209137167143101, 29.909158696189699, "Bibliotheca Alexandrina", new TimeOnly(10, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CloseTime", "Description", "EgyptianStudentTicketPrice", "EgyptianTicketPrice", "ForeignStudentTicketPrice", "ForeignTicketPrice", "Latitude", "Longitude", "Name", "OpenTime" },
                values: new object[] { new TimeOnly(18, 0, 0), "The Ramesseum is the memorial temple (or mortuary temple) of Pharaoh Ramesses II (\"Ramesses the Great\", also spelled \"Ramses\" and \"Rameses\"). It is located in the Theban Necropolis in Upper Egypt, on the west of the River Nile, across from the modern city of Luxor. The name – or at least its French form Rhamesséion – was coined by Jean-François Champollion, who visited the ruins of the site in 1829 and first identified the hieroglyphs making up Ramesses's names and titles on the walls. It was originally called the House of millions of years of Usermaatra-setepenra that unites with Thebes-the-city in the domain of Amon. Usermaatra-setepenra was the prenomen of Ramesses II.", 10.0m, 20.0m, 90.0m, 180.0m, 25.728280050230801, 32.610383357213003, "Ramesseum", new TimeOnly(6, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Description", "EgyptianStudentTicketPrice", "EgyptianTicketPrice", "ForeignStudentTicketPrice", "ForeignTicketPrice", "Latitude", "Longitude", "Name" },
                values: new object[] { "The Church of St. George is a Greek Orthodox church within the Babylon Fortress in Coptic Cairo. It is part of the Holy Patriarchal Monastery of St George under the Greek Orthodox Patriarchate of Alexandria and all Africa. The church dates back to the 10th century (or earlier). The current structure was rebuilt following a 1904 fire, construction was finished in 1909. Since 2009, the monastery's hegumen has had the rank of bishop with title Bishop Babylonos (\"Bishop of Babylon\").", 0.0m, 0.0m, 0.0m, 0.0m, 30.0063419904093, 31.230120109709102, "Saint George Church in Coptic Cairo" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "Url",
                value: "\\landmarkImages\\National_Museum_of Egyptian_Civilization\\1.jpg");

            migrationBuilder.UpdateData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "Url",
                value: "\\landmarkImages\\Coptic_Museum\\1.jpg");

            migrationBuilder.UpdateData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "Url",
                value: "\\landmarkImages\\Denderah\\1.jpg");

            migrationBuilder.UpdateData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 40,
                column: "Url",
                value: "\\landmarkImages\\Mostafa_Kamel_Museum\\1.jpg");

            migrationBuilder.UpdateData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 41,
                column: "Url",
                value: "\\landmarkImages\\Museum_of_Islamic_Arts\\1.jpg");

            migrationBuilder.UpdateData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 42,
                column: "Url",
                value: "\\landmarkImages\\Egypt_s_Renaissance_Statue\\1.jpg");

            migrationBuilder.UpdateData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 43,
                column: "Url",
                value: "\\landmarkImages\\October_War_Panorama\\1.jpg");

            migrationBuilder.UpdateData(
                table: "LandmarkImages",
                keyColumn: "Id",
                keyValue: 47,
                column: "Url",
                value: "\\landmarkImages\\Royal_Jewelry_Museum\\1.jpg");

            migrationBuilder.UpdateData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CloseTime", "Description", "EgyptianStudentTicketPrice", "EgyptianTicketPrice", "ForeignStudentTicketPrice", "ForeignTicketPrice", "Latitude", "Longitude", "Name", "OpenTime" },
                values: new object[] { new TimeOnly(17, 0, 0), "Egypt is home to several significant museums showcasing its civilization. The Egyptian Museum in Cairo displays a vast collection of ancient artifacts, including Tutankhamun's treasures. The Luxor Museum highlights artifacts from the ancient city of Thebes. The Nubian Museum in Aswan focuses on Nubian culture and history. The Alexandria National Museum exhibits diverse artifacts from different historical periods. These museums offer invaluable insights into Egypt's rich civilization and heritage.", 40.0m, 80.0m, 250.0m, 500.0m, 30.008417609418, 31.248249387380302, "National Museum of Egyptian Civilization", new TimeOnly(9, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CloseTime", "Description", "EgyptianStudentTicketPrice", "EgyptianTicketPrice", "ForeignStudentTicketPrice", "ForeignTicketPrice", "Latitude", "Longitude", "Name" },
                values: new object[] { new TimeOnly(17, 0, 0), "The Coptic Museum is a renowned museum located in Cairo, Egypt. It is dedicated to preserving and showcasing the rich heritage of Egypt's Coptic Christian community. The museum houses a vast collection of artifacts, including religious manuscripts, icons, textiles, and ancient Coptic artwork. Visitors can explore the museum's exhibits, which provide insights into Coptic history, culture, and art. The museum is an important cultural and historical destination, offering a unique perspective on Egypt's diverse religious and artistic traditions.", 10.0m, 20.0m, 120.0m, 230.0m, 30.005778097385001, 31.230398849392401, "Coptic Museum" });

            migrationBuilder.UpdateData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CloseTime", "Description", "EgyptianStudentTicketPrice", "EgyptianTicketPrice", "ForeignStudentTicketPrice", "ForeignTicketPrice", "Latitude", "Longitude", "Name" },
                values: new object[] { new TimeOnly(17, 0, 0), "Denderah, located in Upper Egypt, is an ancient Egyptian temple complex dedicated to the goddess Hathor. The centerpiece is the Temple of Hathor, known for its well-preserved and elaborate reliefs and carvings. The temple features a striking hypostyle hall, a sacred lake, and a birthing house. Denderah is renowned for its astronomical ceiling depicting the zodiac signs. It is a significant archaeological site and a testament to the architectural and artistic achievements of ancient Egypt.", 10.0m, 20.0m, 120.0m, 240.0m, 26.1676120463747, 32.656609106246201, "Denderah" });

            migrationBuilder.UpdateData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CloseTime", "Description", "EgyptianStudentTicketPrice", "EgyptianTicketPrice", "ForeignStudentTicketPrice", "ForeignTicketPrice", "Latitude", "Longitude", "Name" },
                values: new object[] { new TimeOnly(17, 0, 0), "The Mostafa Kamel Museum is a museum in Cairo.It was officially opened in April 1956. Before that, it was a mausoleum containing the remains of the two leaders, Mustafa Kamel and Muhammad Farid. It also houses the remains of the intellectuals and activists, Abd al-Rahman al-Rafei and Fathi Radwan. The museum is built in the style of the Islamic mausoleum dome and includes two halls containing some of the belongings of the leader Mustafa Kamel represented in his books and letters in his handwriting, and some pictures of his friends and relatives, as well as some of his personal belongings of clothes, dining utensils, and his office room. The museum also includes oil paintings depicting the Denshway incident. On February 8, 2001, the museum reopened after being restored.", 5.0m, 10.0m, 50.0m, 100.0m, 30.029560986308599, 31.257227436188, "Mostafa Kamel Museum" });

            migrationBuilder.UpdateData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Description", "EgyptianStudentTicketPrice", "EgyptianTicketPrice", "ForeignStudentTicketPrice", "ForeignTicketPrice", "Latitude", "Longitude", "Name", "OpenTime" },
                values: new object[] { "The Islamic Arts Museum in Egypt, located in Cairo, is a prominent museum dedicated to showcasing Islamic art and artifacts. It houses a vast collection of Islamic art pieces spanning various periods and regions. The museum exhibits intricate calligraphy, ceramics, textiles, metalwork, and more. Visitors can explore the museum's galleries, which provide a comprehensive view of the rich artistic heritage of the Islamic world. The Islamic Arts Museum in Egypt is a valuable cultural institution, preserving and promoting Islamic art and its significance.", 10.0m, 20.0m, 140.0m, 270.0m, 30.0447369750107, 31.252718977406701, "Museum of Islamic Arts", new TimeOnly(9, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CloseTime", "Description", "EgyptianStudentTicketPrice", "EgyptianTicketPrice", "ForeignStudentTicketPrice", "ForeignTicketPrice", "Latitude", "Longitude", "Name", "OpenTime" },
                values: new object[] { new TimeOnly(9, 0, 0), "Egypt's Renaissance Statue, also known as Nahdet Masr or The Awakening of Egypt, is a monumental sculpture located in Cairo, Egypt. It was unveiled in 2019 and stands at a height of 20 meters (66 feet). The statue symbolizes the modern renaissance and progress of Egypt. It depicts a man and a woman holding the Egyptian flag, representing unity and national pride. The statue has become an iconic symbol of Egypt's aspirations for development and advancement.", 0.0m, 0.0m, 0.0m, 0.0m, 30.0283395211917, 31.215928801836299, "Egypt's Renaissance Statue", new TimeOnly(9, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CloseTime", "Description", "EgyptianStudentTicketPrice", "EgyptianTicketPrice", "ForeignStudentTicketPrice", "ForeignTicketPrice", "Latitude", "Longitude", "Name", "OpenTime" },
                values: new object[] { new TimeOnly(21, 0, 0), "The October War Panorama is a historical exhibit located in Cairo, Egypt. It commemorates the events of the October War of 1973, also known as the Yom Kippur War. The panorama offers a panoramic view of the battlefield, featuring life-sized models, sound effects, and multimedia presentations. It provides visitors with an immersive experience, allowing them to relive the key moments and understand the significance of the war. The October War Panorama serves as a tribute to the valor and sacrifice of the Egyptian armed forces during the conflict.", 30.0m, 30.0m, 120.0m, 120.0m, 30.074287213695399, 31.3068091801549, "October War Panorama", new TimeOnly(9, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Description", "EgyptianStudentTicketPrice", "EgyptianTicketPrice", "ForeignStudentTicketPrice", "ForeignTicketPrice", "Latitude", "Longitude", "Name" },
                values: new object[] { "The Royal Jewelry Museum is a captivating museum located in Alexandria, Egypt. It showcases a stunning collection of exquisite jewelry and precious artifacts once owned by the royal family of Egypt. The museum is housed in a beautiful palace that was built in the early 20th century. Visitors can explore the opulent rooms filled with jewelry, crowns, tiaras, and other dazzling pieces. The museum offers a glimpse into the grandeur and luxury of Egypt's royal heritage, making it a must-visit destination for jewelry enthusiasts and history lovers.", 5.0m, 20.0m, 90.0m, 180.0m, 31.2406196888804, 29.9632878058699, "Royal Jewelry Museum" });
        }
    }
}
