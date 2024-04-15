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
			//modelBuilder.Entity<SearchHistory>().HasKey(ab => new { ab.UserId, ab.LandmarkID }); //make composite key

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
		, OpenTime = TimeOnly.Parse("09:00:00"), CloseTime = TimeOnly.Parse("00:00:00"), Latitude = 30.0459258601981, Longitude = 31.2242886061951, EgyptianTicketPrice = 70.0m, EgyptianStudentTicketPrice = 70.0m, ForeignTicketPrice = 250.0m, ForeignStudentTicketPrice = 250.0m }
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
				new LandmarkImage { Id = 19, LandmarkId = 10, Url = @"\landmarkImages\Cairo_Tower\2.jpg" }
				);

            //modelBuilder.Entity<Landmark>().HasNoKey();
        }
    }
}
