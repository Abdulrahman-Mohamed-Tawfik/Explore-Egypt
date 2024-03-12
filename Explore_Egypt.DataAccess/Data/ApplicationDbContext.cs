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
                    new Landmark { Id = 1, Name = "Action", Description = "", OpenTime = TimeOnly.Parse("10:20:30"), CloseTime = TimeOnly.Parse("10:20:30"), Latitude = 1.0, Longitude = 1.0, EgyptianTicketPrice = 10.2m, EgyptianStudentTicketPrice = 10.2m, ForeignTicketPrice = 10.2m, ForeignStudentTicketPrice = 10.2m },
                    new Landmark { Id = 2, Name = "Action", Description = "", OpenTime = TimeOnly.Parse("10:20:30"), CloseTime = TimeOnly.Parse("10:20:30"), Latitude = 1.0, Longitude = 1.0, EgyptianTicketPrice = 10.2m, EgyptianStudentTicketPrice = 10.2m, ForeignTicketPrice = 10.2m, ForeignStudentTicketPrice = 10.2m },
                    new Landmark { Id = 3, Name = "Action", Description = "", OpenTime = TimeOnly.Parse("10:20:30"), CloseTime = TimeOnly.Parse("10:20:30"), Latitude = 1.0, Longitude = 1.0, EgyptianTicketPrice = 10.2m, EgyptianStudentTicketPrice = 10.2m, ForeignTicketPrice = 10.2m, ForeignStudentTicketPrice = 10.2m }
               );
            //modelBuilder.Entity<Landmark>().HasNoKey();
        }
    }
}
