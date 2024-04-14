using Explore_Egypt.Models;
using Explore_Egypt.Models.ViewModels;
using Explore_Egypt.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Explore_Egypt.Controllers
{
	[Authorize(Roles = Constants.Admin)]
	public class UserController : Controller
	{
		private readonly UserManager<ApplicationUser> _userManager;
		private readonly IUserStore<ApplicationUser> _userStore;
		private readonly IUserEmailStore<ApplicationUser> _emailStore;
		private readonly RoleManager<IdentityRole> _roleManager;

		public UserController(UserManager<ApplicationUser> userManager, 
			RoleManager<IdentityRole> roleManager,
			IUserStore<ApplicationUser> userStore)
        {
			_userManager = userManager;
			_roleManager = roleManager;
			_userStore = userStore;
			_emailStore = (IUserEmailStore<ApplicationUser>)_userStore;

		}
        public async Task<IActionResult> Index()
		{
            return View();
		}

		public IActionResult Create()
		{
			var userViewModel = new UserViewModel
			{
				User = new ApplicationUser(),
                RolesList = _roleManager.Roles.ToList().Select(x => new SelectListItem
                {
                    Text = x.NormalizedName,
                    Value = x.Id
                })
            };
			return View(userViewModel);
		}

		[HttpPost]
		public async Task<IActionResult> Create(UserViewModel userViewModel)
		{
			if (userViewModel.User.Email != null && !userViewModel.User.Email.Contains('@') && userViewModel.User.Email.Length < 4)
			{
				ModelState.AddModelError(string.Empty, $"Email '{userViewModel.User.Email}' is not a valid e-mail address.");
			}
			if (userViewModel.User.Email != null && await _userManager.FindByEmailAsync(userViewModel.User.Email) != null)
			{
				ModelState.AddModelError(string.Empty, $"Email '{userViewModel.User.Email}' is already taken.");
			}
				

			if (ModelState.IsValid)
			{
				await _userStore.SetUserNameAsync(userViewModel.User, userViewModel.User.UserName, CancellationToken.None);
				await _emailStore.SetEmailAsync(userViewModel.User, userViewModel.User.Email, CancellationToken.None);
				var result = await _userManager.CreateAsync(userViewModel.User, userViewModel.Password);

				if (result.Succeeded)
				{
					var role = await _roleManager.FindByIdAsync(userViewModel.RoleId);
					await _userManager.AddToRoleAsync(userViewModel.User, await _roleManager.GetRoleNameAsync(role) ?? Constants.User);
					TempData["success"] = "User Added Successfully";
					return RedirectToAction("Index");
				}
				foreach (var error in result.Errors)
				{
					ModelState.AddModelError(string.Empty, error.Description);
					//return View(userViewModel);
					
				}

				
			}
			
			userViewModel.RolesList = _roleManager.Roles.ToList().Select(x => new SelectListItem
			{
				Text = x.NormalizedName,
				Value = x.Id
			});
			return View(userViewModel);
			
			
			
		}
	}
}
