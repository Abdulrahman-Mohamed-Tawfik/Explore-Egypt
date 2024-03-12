using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Explore_Egypt.Models
{
	public class ApplicationUser: IdentityUser
	{
        [Required]
        [MaxLength(100)]
		[Display(Name = "First Name")]
        public string FirstName { get; set; }
		[Required]
		[MaxLength(100)]
		[Display(Name = "Last Name")]
		public string LastName { get; set; }
		[Required]
		[MaxLength(100)]
		public string Country { get; set; }
		public ICollection<Favour>? Favourites { get; set; }
		public ICollection<SearchHistory>? SearchHistories { get; set; }
    }
}
