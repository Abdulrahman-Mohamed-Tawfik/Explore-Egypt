using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Explore_Egypt.Models.ViewModels
{
	public class UserViewModel
	{
		public ApplicationUser User { get; set; }
		public string Password { get; set; }
		[Display(Name = "Role")]
		public string RoleId { get; set; }

		[ValidateNever]
		public IEnumerable<SelectListItem> RolesList { get; set; }
	}
}
