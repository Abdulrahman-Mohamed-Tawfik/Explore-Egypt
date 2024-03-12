using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explore_Egypt.Models
{
	public class Favour
	{
        public string? UserId { get; set; }
		public int? LandmarkID { get; set; }

		public ApplicationUser? User { get; set; }
		public Landmark? Landmark { get; set; }
    }
}
