using Explore_Egypt.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Explore_Egypt.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Landmark> Landmarks { get; set; }
        public DbSet<LandmarkImage> LandmarkImages { get; set; }
        public DbSet<Favour> Favours { get; set; }
        public DbSet<SearchHistory> SearchHistory { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationUser>()
            .ToTable("User", schema: "security")
            .Ignore(x => x.PhoneNumber)
            .Ignore(x => x.PhoneNumberConfirmed);
            modelBuilder.Entity<IdentityRole>().ToTable("Role", schema: "security");
            modelBuilder.Entity<IdentityUserRole<string>>().ToTable("UserRoles", schema: "security");
            modelBuilder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims", schema: "security");
            modelBuilder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims", schema: "security");
            modelBuilder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins", schema: "security");
            modelBuilder.Entity<IdentityUserToken<string>>().ToTable("UserTokens", schema: "security");

            //Favour table
            modelBuilder.Entity<Favour>().HasKey(ab => new { ab.UserId, ab.LandmarkID }); //make composite key

            modelBuilder.Entity<Favour>()
                .HasOne(a => a.User)
                .WithMany(b => b.Favourites)
                .HasForeignKey(ab => ab.UserId);

            modelBuilder.Entity<Favour>()
                .HasOne(a => a.Landmark)
                .WithMany(b => b.Favourites)
                .HasForeignKey(ab => ab.LandmarkID);

			//Search History Table
			modelBuilder.Entity<SearchHistory>().HasKey(ab => new { ab.UserId, ab.LandmarkID }); //make composite key

			modelBuilder.Entity<SearchHistory>()
				.HasOne(a => a.User)
				.WithMany(b => b.SearchHistories)
				.HasForeignKey(ab => ab.UserId);

			modelBuilder.Entity<SearchHistory>()
				.HasOne(a => a.Landmark)
				.WithMany(b => b.SearchHistories)
				.HasForeignKey(ab => ab.LandmarkID);

			//Relations
			//modelBuilder.Entity<Landmark>().HasMany(x => x.Images)
			//    .WithOne(x => x.Landmark)
			//    .HasForeignKey(x => x.LandmarkId)
			//    .IsRequired(false);

			modelBuilder.Entity<Landmark>().HasData(
        new Landmark { Id = 1, Name = "Abdeen Palace", Description = "Abdeen Palace is a historic palace in Cairo, Egypt. Built in the late 19th century, it served as the main residence for Egypt's royal family until 1952. The palace features a blend of Turkish, Moorish, and European architectural styles. Today, it is a museum showcasing opulent interiors, royal artifacts, and beautifully landscaped gardens. Abdeen Palace is a popular tourist attraction, offering a glimpse into Egypt's rich history and royal heritage."
        , OpenTime = TimeOnly.Parse("09:00:00"), CloseTime = TimeOnly.Parse("15:00:00"), Latitude = 30.0419805957593, Longitude = 31.2467661930229, EgyptianTicketPrice = 20.0m, EgyptianStudentTicketPrice = 10.0m, ForeignTicketPrice = 100.0m, ForeignStudentTicketPrice = 50.0m },
        new Landmark { Id = 2, Name = "Abu Simbel", Description = "Abu Simbel is an archaeological site in southern Egypt known for its rock-cut temples. The main attraction is the Great Temple of Ramses II, featuring colossal statues and intricate wall carvings. The smaller Temple of Hathor is dedicated to the goddess of love. The site was relocated in the 1960s to save it from flooding. Today, Abu Simbel is a UNESCO World Heritage site and a popular tourist destination"
        , OpenTime = TimeOnly.Parse("09:00:00"), CloseTime = TimeOnly.Parse("09:00:00"), Latitude = 29.9810966592981, Longitude = 31.1432167153407, EgyptianTicketPrice = 30.0m, EgyptianStudentTicketPrice = 10.0m, ForeignTicketPrice = 600.0m, ForeignStudentTicketPrice = 300.0m },
        new Landmark { Id = 3, Name = "Alexandria National Museum", Description = "The Alexandria National Museum is a prominent museum located in Alexandria, Egypt. It was established in 2003 and is housed in a renovated Italian-style palace dating back to the early 20th century. The museum showcases a diverse collection of artifacts, spanning various historical periods and civilizations, including ancient Egyptian, Greek, Roman, and Islamic artifacts. Visitors can explore exhibits that highlight Alexandria's rich cultural heritage, including sculptures, jewelry, coins, and mummies. The museum also provides insight into the city's history, including its role as a center of trade and scholarship in the ancient world."
		, OpenTime = TimeOnly.Parse("09:00:00"), CloseTime = TimeOnly.Parse("16:30:00"), Latitude = 31.2008148902682, Longitude = 29.9132191626329, EgyptianTicketPrice = 20.0m, EgyptianStudentTicketPrice = 5.0m, ForeignTicketPrice = 180.0m, ForeignStudentTicketPrice = 90.0m },
        new Landmark { Id = 4, Name = "Amir Taz Palace", Description = "Amir Taz Palace, also known as Beit El-Sennari, is a historic palace located in the heart of Cairo, Egypt. It was constructed during the 19th century under the reign of Khedive Ismail Pasha. The palace exhibits an exquisite blend of Ottoman and Islamic architectural styles, featuring intricate carvings, beautiful stained glass windows, and ornate decorations. Today, the palace serves as a cultural center and a venue for various art exhibitions, concerts, and cultural events. It stands as a testament to Egypt's rich architectural heritage and offers visitors a glimpse into the opulent lifestyle of the past."
		, OpenTime = TimeOnly.Parse("09:00:00"), CloseTime = TimeOnly.Parse("17:00:00"), Latitude = 30.0323587576957, Longitude = 31.2536643083669, EgyptianTicketPrice = 0.0m, EgyptianStudentTicketPrice = 0.0m, ForeignTicketPrice = 0.0m, ForeignStudentTicketPrice = 0.0m },
        new Landmark { Id = 5, Name = "Amr Ibn Al-As", Description = "Amr ibn al-As was a prominent Arab military commander and companion of Prophet Muhammad. He played a crucial role in the early Muslim conquests, including the conquest of Egypt in 641 CE. He founded the city of Fustat, which later became Cairo's capital. Amr ibn al-As introduced Islam to the region and governed Egypt for several years. His military and administrative achievements left a lasting impact on the expansion of Islam and the Arab world."
		, OpenTime = TimeOnly.Parse("09:00:00"), CloseTime = TimeOnly.Parse("09:00:00"), Latitude = 30.010058193229, Longitude = 31.2331094374956, EgyptianTicketPrice = 0.0m, EgyptianStudentTicketPrice = 0.0m, ForeignTicketPrice = 0.0m, ForeignStudentTicketPrice = 0.0m },
        new Landmark { Id = 6, Name = "Aswan Museum", Description = "Nestled in Aswan, Upper Egypt, the Nubian Museum stands as a testament to the rich history and captivating culture of Nubia. Built in response to the international campaign to save Nubian monuments from rising waters due to the Aswan Dam, the museum opened its doors in 1997"
		, OpenTime = TimeOnly.Parse("09:00:00"), CloseTime = TimeOnly.Parse("19:00:00"), Latitude = 24.0850939777577, Longitude = 32.8870739212524, EgyptianTicketPrice = 30.0m, EgyptianStudentTicketPrice = 10.0m, ForeignTicketPrice = 300.0m, ForeignStudentTicketPrice = 150.0m },
        new Landmark { Id = 7, Name = "Bab al-Futuh", Description = "Bab al-Futuh is one of the ancient gates of the historic city of Cairo, Egypt. It was constructed during the 11th century and is known for its impressive architectural design. The gate is adorned with intricate carvings and decorative motifs. It served as a main entrance to the old city and is an important cultural and historical landmark. Visitors can admire the gate's grandeur and learn about Cairo's rich history and heritage."
		, OpenTime = TimeOnly.Parse("09:00:00"), CloseTime = TimeOnly.Parse("09:00:00"), Latitude = 30.0554678898694, Longitude = 31.2633646026743, EgyptianTicketPrice = 0.0m, EgyptianStudentTicketPrice = 0.0m, ForeignTicketPrice = 0.0m, ForeignStudentTicketPrice = 0.0m },
        new Landmark { Id = 8, Name = "Bab Zuweila", Description = "Bab Zuweila is a historic gate located in the Old City of Cairo, Egypt. It was built in the 11th century and is one of the few remaining gates from the original city walls. The gate is renowned for its architectural beauty, featuring intricate carvings and decorative elements. It served as a significant entrance to the city and a defensive structure. Today, visitors can explore Bab Zuweila and enjoy panoramic views of Cairo from its elevated platforms.\r\n\r\n\r\n\r\n\r\n"
		, OpenTime = TimeOnly.Parse("09:00:00"), CloseTime = TimeOnly.Parse("09:00:00"), Latitude = 30.0427212325241, Longitude = 31.2577807018198, EgyptianTicketPrice = 20.0m, EgyptianStudentTicketPrice = 10.0m, ForeignTicketPrice = 100.0m, ForeignStudentTicketPrice = 50.0m },
        new Landmark { Id = 9, Name = "Baron Empain Palace", Description = "Baron Empain Palace, also known as the Heliopolis Palace, is a historic landmark located in Heliopolis, Cairo, Egypt. Built in the early 20th century by Belgian industrialist Baron Édouard Empain, it showcases a unique blend of architectural styles, including Hindu and Khmer influences. The palace's distinctive features include its pink hue and intricate detailing. It is considered a masterpiece of architecture and a symbol of Heliopolis. Today, the palace is open to visitors, offering a glimpse into its opulent interiors and the history of its construction.\r\n\r\n\r\n\r\n\r\n"
		, OpenTime = TimeOnly.Parse("09:00:00"), CloseTime = TimeOnly.Parse("16:30:00"), Latitude = 30.0866997766127, Longitude = 31.3303118976865, EgyptianTicketPrice = 60.0m, EgyptianStudentTicketPrice = 30.0m, ForeignTicketPrice = 180.0m, ForeignStudentTicketPrice = 90.0m },
        new Landmark { Id = 10, Name = "Cairo Tower", Description = "The Cairo Tower is a prominent landmark and observation tower located in Cairo, Egypt. Standing at a height of 187 meters (614 feet), it offers panoramic views of the city's skyline and the Nile River. The tower was constructed in the 1960s and features a futuristic design inspired by lotus flowers and ancient Egyptian architecture. It is a popular tourist attraction and a symbol of modern Cairo. The tower also houses a revolving restaurant, offering a unique dining experience with stunning views.\r\n\r\n\r\n\r\n\r\n"
		, OpenTime = TimeOnly.Parse("09:00:00"), CloseTime = TimeOnly.Parse("00:00:00"), Latitude = 30.0459258601981, Longitude = 31.2242886061951, EgyptianTicketPrice = 70.0m, EgyptianStudentTicketPrice = 70.0m, ForeignTicketPrice = 250.0m, ForeignStudentTicketPrice = 250.0m },
        new Landmark { Id = 11, Name = "National Museum of Egyptian Civilization", Description = "Egypt is home to several significant museums showcasing its civilization. The Egyptian Museum in Cairo displays a vast collection of ancient artifacts, including Tutankhamun's treasures. The Luxor Museum highlights artifacts from the ancient city of Thebes. The Nubian Museum in Aswan focuses on Nubian culture and history. The Alexandria National Museum exhibits diverse artifacts from different historical periods. These museums offer invaluable insights into Egypt's rich civilization and heritage."
		, OpenTime = TimeOnly.Parse("09:00:00"), CloseTime = TimeOnly.Parse("17:00:00"), Latitude = 30.008417609418, Longitude = 31.2482493873803, EgyptianTicketPrice = 80.0m, EgyptianStudentTicketPrice = 40.0m, ForeignTicketPrice = 500.0m, ForeignStudentTicketPrice = 250.0m },
        new Landmark { Id = 12, Name = "Colossi of Memnon", Description = "The Colossi of Memnon are two massive stone statues located on the west bank of the Nile River in Luxor, Egypt. Dating back to the 14th century BCE, they depict Pharaoh Amenhotep III seated on his throne. Standing at around 18 meters (60 feet) tall, they are impressive examples of ancient Egyptian art and craftsmanship. The statues are known for producing a musical sound at sunrise due to natural phenomena, which was believed to be the voice of the mythical Memnon. Today, the Colossi of Memnon attract visitors as iconic remnants of ancient Egypt's grandeur."
		, OpenTime = TimeOnly.Parse("06:00:00"), CloseTime = TimeOnly.Parse("17:00:00"), Latitude = 25.720594393259, Longitude = 32.6105319712237, EgyptianTicketPrice = 0.0m, EgyptianStudentTicketPrice = 0.0m, ForeignTicketPrice = 0.0m, ForeignStudentTicketPrice = 0.0m },
        new Landmark { Id = 13, Name = "Coptic Museum", Description = "The Coptic Museum is a renowned museum located in Cairo, Egypt. It is dedicated to preserving and showcasing the rich heritage of Egypt's Coptic Christian community. The museum houses a vast collection of artifacts, including religious manuscripts, icons, textiles, and ancient Coptic artwork. Visitors can explore the museum's exhibits, which provide insights into Coptic history, culture, and art. The museum is an important cultural and historical destination, offering a unique perspective on Egypt's diverse religious and artistic traditions."
		, OpenTime = TimeOnly.Parse("09:00:00"), CloseTime = TimeOnly.Parse("17:00:00"), Latitude = 30.005778097385, Longitude = 31.2303988493924, EgyptianTicketPrice = 20.0m, EgyptianStudentTicketPrice = 10.0m, ForeignTicketPrice = 230.0m, ForeignStudentTicketPrice = 120.0m },
        new Landmark { Id = 14, Name = "Deir el-Medina", Description = "Deir el-Medina is an ancient Egyptian village located on the west bank of the Nile near Luxor. It was inhabited by the skilled artisans and workers who constructed royal tombs in the nearby Valley of the Kings. The village is known for its well-preserved structures, including houses, workshops, and a temple dedicated to the goddess Hathor. It offers valuable insights into the daily life, religious practices, and artistic skills of the ancient Egyptians. Deir el-Medina is a significant archaeological site that sheds light on the intricacies of ancient Egyptian society."
		, OpenTime = TimeOnly.Parse("06:00:00"), CloseTime = TimeOnly.Parse("17:00:00"), Latitude = 25.7289015527221, Longitude = 32.6022226023069, EgyptianTicketPrice = 0.0m, EgyptianStudentTicketPrice = 0.0m, ForeignTicketPrice = 0.0m, ForeignStudentTicketPrice = 0.0m },
        new Landmark { Id = 15, Name = "Denderah", Description = "Denderah, located in Upper Egypt, is an ancient Egyptian temple complex dedicated to the goddess Hathor. The centerpiece is the Temple of Hathor, known for its well-preserved and elaborate reliefs and carvings. The temple features a striking hypostyle hall, a sacred lake, and a birthing house. Denderah is renowned for its astronomical ceiling depicting the zodiac signs. It is a significant archaeological site and a testament to the architectural and artistic achievements of ancient Egypt."
		, OpenTime = TimeOnly.Parse("07:00:00"), CloseTime = TimeOnly.Parse("17:00:00"), Latitude = 26.1676120463747, Longitude = 32.6566091062462, EgyptianTicketPrice = 20.0m, EgyptianStudentTicketPrice = 10.0m, ForeignTicketPrice = 240.0m, ForeignStudentTicketPrice = 120.0m },
        new Landmark { Id = 16, Name = "Edfu Temple", Description = "Edfu Temple is an ancient Egyptian temple located on the west bank of the Nile in Edfu, Egypt. It is dedicated to the falcon-headed god Horus and is one of the best-preserved temples in Egypt. The temple was built during the Ptolemaic period and showcases remarkable architecture, including a towering entrance pylon and a well-preserved hypostyle hall. Its walls are adorned with intricate reliefs depicting mythological scenes and rituals. Edfu Temple is a significant religious site and a testament to the grandeur of ancient Egyptian temple construction."
		, OpenTime = TimeOnly.Parse("06:00:00"), CloseTime = TimeOnly.Parse("18:00:00"), Latitude = 24.9779482340463, Longitude = 32.8733692941535, EgyptianTicketPrice = 40.0m, EgyptianStudentTicketPrice = 20.0m, ForeignTicketPrice = 450.0m, ForeignStudentTicketPrice = 230.0m },
        new Landmark { Id = 17, Name = "Egyptian Museum", Description = "The Egyptian Museum, located in Cairo, Egypt, is one of the world's most significant museums dedicated to ancient Egyptian artifacts. It houses an extensive collection of over 120,000 artifacts, including the treasures of Tutankhamun. The museum showcases statues, mummies, jewelry, and other artifacts spanning several dynasties. Visitors can explore the museum's exhibits, which provide insights into ancient Egyptian history, culture, and art. The Egyptian Museum is a must-visit destination for anyone interested in experiencing the magnificence of Egypt's ancient civilization."
		, OpenTime = TimeOnly.Parse("09:00:00"), CloseTime = TimeOnly.Parse("17:00:00"), Latitude = 30.0483234783755, Longitude = 31.2336628403417, EgyptianTicketPrice = 30.0m, EgyptianStudentTicketPrice = 10.0m, ForeignTicketPrice = 450.0m, ForeignStudentTicketPrice = 230.0m },
        new Landmark { Id = 18, Name = "Al-Azhar Mosque", Description = "Al-Azhar Mosque is a historic mosque located in Cairo, Egypt, and is one of the oldest Islamic universities in the world. It was founded in the 10th century and is renowned for its religious and educational significance. The mosque showcases exquisite Islamic architecture, including a beautiful courtyard and minarets. It serves as a center for Islamic learning and hosts religious lectures and conferences. Al-Azhar Mosque is a significant religious and cultural landmark, attracting visitors from around the world.\r\n\r\n\r\n\r\n\r\n"
		, OpenTime = TimeOnly.Parse("09:00:00"), CloseTime = TimeOnly.Parse("9:00:00"), Latitude = 30.045704450606, Longitude = 31.2626775702408, EgyptianTicketPrice = 0.0m, EgyptianStudentTicketPrice = 0.0m, ForeignTicketPrice = 0.0m, ForeignStudentTicketPrice = 0.0m },
        new Landmark { Id = 19, Name = "Temple of Gerf Hussein", Description = "The Temple of Gerf Hussein is an ancient Egyptian temple located in Upper Nubia, near the Sudanese border. It was relocated during the construction of the Aswan High Dam. The temple was dedicated to the Nubian deity Dedun and was built during the reign of Ramses II. It features well-preserved reliefs depicting Ramses II and various religious scenes. The Temple of Gerf Hussein offers a glimpse into the ancient Egyptian presence in Nubia and the cultural exchange between the two regions.\r\n\r\n\r\n\r\n\r\n"
		, OpenTime = TimeOnly.Parse("06:00:00"), CloseTime = TimeOnly.Parse("18:00:00"), Latitude = 23.96017, Longitude = 32.86765, EgyptianTicketPrice = 0.0m, EgyptianStudentTicketPrice = 0.0m, ForeignTicketPrice = 0.0m, ForeignStudentTicketPrice = 0.0m },
        new Landmark { Id = 20, Name = "Al-Hussein Mosque", Description = "The El-Hussein Mosque is a historic mosque located in Cairo, Egypt. It is named after Hussein ibn Ali, the grandson of Prophet Muhammad. The mosque is considered a sacred site and holds religious significance for the Shia Muslim community. It features a beautiful courtyard, minarets, and a dome. The mosque is known for its intricate architectural details and is a popular destination for worshippers and visitors seeking spiritual solace. The El-Hussein Mosque stands as a symbol of religious devotion and cultural heritage in Cairo.\r\n\r\n\r\n\r\n\r\n"
		, OpenTime = TimeOnly.Parse("09:00:00"), CloseTime = TimeOnly.Parse("9:00:00"), Latitude = 25.7446852883033, Longitude = 32.7515048302213, EgyptianTicketPrice = 0.0m, EgyptianStudentTicketPrice = 0.0m, ForeignTicketPrice = 0.0m, ForeignStudentTicketPrice = 0.0m }
         );

            modelBuilder.Entity<LandmarkImage>().HasData(
                new LandmarkImage { Id = 1, LandmarkId = 1, Url = @"\landmarkImages\Abdeen_Palace\1.jpg" },
                new LandmarkImage { Id = 2, LandmarkId = 1, Url = @"\landmarkImages\Abdeen_Palace\2.jpg" },
				new LandmarkImage { Id = 3, LandmarkId = 2, Url = @"\landmarkImages\Abu_Simbel\1.jpg" },
				new LandmarkImage { Id = 4, LandmarkId = 2, Url = @"\landmarkImages\Abu_Simbel\2.jpg" },
				new LandmarkImage { Id = 5, LandmarkId = 3, Url = @"\landmarkImages\Alexandria_National_Museum\1.jpg" },
				new LandmarkImage { Id = 6, LandmarkId = 3, Url = @"\landmarkImages\Alexandria_National_Museum\2.jpg" },
				new LandmarkImage { Id = 7, LandmarkId = 4, Url = @"\landmarkImages\Amir_Taz_Palace\1.jpg" },
				new LandmarkImage { Id = 8, LandmarkId = 4, Url = @"\landmarkImages\Amir_Taz_Palace\2.jpg" },
				new LandmarkImage { Id = 9, LandmarkId = 5, Url = @"\landmarkImages\Amr_Ibn_Al-As\1.jpg" },
				new LandmarkImage { Id = 10, LandmarkId = 5, Url = @"\landmarkImages\Amr_Ibn_Al-As\2.jpg" },
				new LandmarkImage { Id = 11, LandmarkId = 6, Url = @"\landmarkImages\Aswan_Museum\1.jpeg" },
				new LandmarkImage { Id = 12, LandmarkId = 6, Url = @"\landmarkImages\Aswan_Museum\2.jpeg" },
				new LandmarkImage { Id = 13, LandmarkId = 7, Url = @"\landmarkImages\Bab-al-Futuh\1.jpg" },
				new LandmarkImage { Id = 14, LandmarkId = 7, Url = @"\landmarkImages\Bab-al-Futuh\2.jpeg" },
				new LandmarkImage { Id = 15, LandmarkId = 8, Url = @"\landmarkImages\Bab-Zuweila\1.jpg" },
				new LandmarkImage { Id = 16, LandmarkId = 8, Url = @"\landmarkImages\Bab-Zuweila\2.jpg" },
				new LandmarkImage { Id = 17, LandmarkId = 9, Url = @"\landmarkImages\Baron_Empain_Palace\1.jpg" },
				new LandmarkImage { Id = 18, LandmarkId = 10, Url = @"\landmarkImages\Cairo_Tower\1.jpg" },
				new LandmarkImage { Id = 19, LandmarkId = 10, Url = @"\landmarkImages\Cairo_Tower\2.jpg" },
                new LandmarkImage { Id = 20, LandmarkId = 11, Url = @"\landmarkImages\National_Museum_of Egyptian_Civilization\1.jpg" },
				new LandmarkImage { Id = 21, LandmarkId = 12, Url = @"\landmarkImages\Colossi_of_Memnon\1.jpg" },
				new LandmarkImage { Id = 22, LandmarkId = 13, Url = @"\landmarkImages\Coptic_Museum\1.jpg" },
				new LandmarkImage { Id = 23, LandmarkId = 14, Url = @"\landmarkImages\Deir_el-Medina\1.jpeg" },
				new LandmarkImage { Id = 24, LandmarkId = 15, Url = @"\landmarkImages\Denderah\1.jpg" },
				new LandmarkImage { Id = 25, LandmarkId = 16, Url = @"\landmarkImages\Edfu_Temple\1.jpg" },
				new LandmarkImage { Id = 26, LandmarkId = 17, Url = @"\landmarkImages\Egyptian_Museum\1.jpg" },
				new LandmarkImage { Id = 27, LandmarkId = 0, Url = @"\landmarkImages\Egyptian_Museum\1.jpg" }, // emptyyyyy
				new LandmarkImage { Id = 28, LandmarkId = 18, Url = @"\landmarkImages\Al-Azhar_Mosque\1.jpg" },
				new LandmarkImage { Id = 29, LandmarkId = 19, Url = @"\landmarkImages\Temple_of_Gerf_Hussein\1.jpg" },
				new LandmarkImage { Id = 30, LandmarkId = 20, Url = @"\landmarkImages\Al-Hussein_Mosque\2.jpg" }

				);

            //modelBuilder.Entity<Landmark>().HasNoKey();
        }
    }
}
