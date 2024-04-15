using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explore_Egypt.Models
{
	public class SearchHistory
	{
		[Key]
		public int Id {  get; set; }
        public string? UserId { get; set; }
		public int? LandmarkID { get; set; }
		public DateTime? Date {  get; set; }

		public ApplicationUser? User { get; set; }
		public Landmark? Landmark { get; set; }



    }
}
