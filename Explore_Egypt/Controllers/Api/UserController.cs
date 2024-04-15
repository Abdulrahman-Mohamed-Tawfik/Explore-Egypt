using Explore_Egypt.DataAccess.Dto;
using Explore_Egypt.Models;
using Explore_Egypt.Models.ViewModels;
using Explore_Egypt.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net.Mail;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Explore_Egypt.Controllers.Api
{
	[Route("api/[controller]")]
	[ApiController]
	public class UserController : ControllerBase
	{

		private readonly UserManager<ApplicationUser> _userManager;
		private readonly RoleManager<IdentityRole> _roleManager;
		private readonly SignInManager<ApplicationUser> _signInManager;


		public UserController(UserManager<ApplicationUser> userManager, 
			RoleManager<IdentityRole> roleManager,
			SignInManager<ApplicationUser> signInManager)
		{
			_userManager = userManager;
			_roleManager = roleManager;
			_signInManager = signInManager;
		}

		[HttpGet]
		[ProducesResponseType(StatusCodes.Status200OK)]
		public async Task<ActionResult<IEnumerable<UserDto>>> GetUsers()
		{
			var users = await _userManager.Users.Select(user => new UserDto
			{
				Id = user.Id,
				FirstName = user.FirstName,
				LastName = user.LastName,
				UserName = user.UserName,
				Email = user.Email,
				Country = user.Country,
				Password = "########",
				Roles = _userManager.GetRolesAsync(user).GetAwaiter().GetResult()
			}).ToListAsync();
			return Ok(new { data = users });
		}

		[HttpDelete]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<IActionResult> Delete(string? id)
		{
			if (id == null)
			{
				return BadRequest();
			}

			var user = await _userManager.FindByIdAsync(id);
			if (user == null)
			{
				return NotFound(new { success = false, message = "Error while deleting" });
			}

			if (user.UserName == "exploreegypt123")
			{
				return BadRequest(new { success = false, message = "Can't delete the main admin." });
			}

			var result = await _userManager.DeleteAsync(user);

			if (!result.Succeeded)
			{
				return StatusCode(StatusCodes.Status500InternalServerError);
			}

			return Ok(new { success = true, message = "Deleted successfully" });
		}

		[HttpPut("changetoadmin", Name = "ChangeUserRoleToAdmin")]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<IActionResult> ChangeUserRoleToAdmin(string? id)
		{
			if (id == null)
			{
				return BadRequest();
			}

			var user = await _userManager.FindByIdAsync(id);
			if (user == null)
			{
				return NotFound();
			}

			if (await _userManager.IsInRoleAsync(user, Constants.Admin))
			{
				ModelState.AddModelError("CustomError", "This user is already an Admin");
				return BadRequest(ModelState);
			}

			var removeResult = await _userManager.RemoveFromRoleAsync(user, Constants.User);
			var addResult = await _userManager.AddToRoleAsync(user, Constants.Admin);

			if (!removeResult.Succeeded || !addResult.Succeeded)
			{
				return StatusCode(StatusCodes.Status500InternalServerError);
			}

			return NoContent();
		}

		//https://localhost:44316/api/user/login
		[HttpPost("login", Name = "LoginWithEmailAndPassword")]
		[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(UserDto))]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<IActionResult> Login([FromBody] LoginRequestModel model)
		{
			if (model == null)
				return BadRequest();

			var user = await _userManager.FindByEmailAsync(model.Email);
			if (user == null)
				return NotFound();

			var result = await _userManager.CheckPasswordAsync(user, model.Password);

			if (result)
			{
				var userDto = new UserDto
				{
					Id = user.Id,
					Email = user.Email,
					UserName = user.UserName,
					FirstName = user.FirstName, 
					LastName = user.LastName,
					Country = user.Country,
					Password = "########",
					Roles = _userManager.GetRolesAsync(user).Result
				};
				return Ok(userDto);

			}
			else
			{
				return StatusCode(StatusCodes.Status500InternalServerError, new { success = false, message = "Invalid login attempt." });
			}

		}

		//https://localhost:44316/api/user/register
		[HttpPost("register", Name = "Register")]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<IActionResult> Register([FromBody] UserDto model)
		{
			if(model == null) 
				return BadRequest();

			if (model.Id != "0")
				return BadRequest(new { success = false, message = "Id must be 0" });

			if (await _userManager.FindByEmailAsync(model.Email) != null)
				return BadRequest(new { success = false, message = $"Email '{model.Email}' is already taken." });

			if (!model.Email.Contains('@') && model.Email.Length < 4)
				return BadRequest(new { success = false, message = $"Email '{model.Email}' is not a valid e-mail address." });


			var user = new ApplicationUser
			{
				FirstName = model.FirstName,
				LastName = model.LastName,
				Email = model.Email,
				UserName = model.UserName ?? new MailAddress(model.Email).User,
				Country = model.Country,
			};
			var result = await _userManager.CreateAsync(user, model.Password);
			if (result.Succeeded)
			{
				await _userManager.AddToRoleAsync(user, Constants.User);
				return NoContent();
			}
			else
			{
				string errorMsg = "";
				foreach (var error in result.Errors)
				{
					errorMsg += $"{error.Description} ";
				}
				return StatusCode(StatusCodes.Status500InternalServerError, new { success = false, message = errorMsg });
			}
		}

		//https://localhost:44316/api/user/logout
		[HttpGet("logout", Name = "Logout")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public async Task<IActionResult> Logout(string userEmail)
		{
			if (userEmail == null)
				return BadRequest();

			var user = await _userManager.FindByEmailAsync(userEmail);
			if (user == null)
				return NotFound();

			await _signInManager.SignOutAsync();
			return Ok();
		}

        //https://localhost:44316/api/user
        [HttpPut(Name = "UpdateUser")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateUser([FromBody] UserDto userDto)
        {
            if(userDto == null)
				return BadRequest();
			
			var user = await _userManager.FindByIdAsync(userDto.Id);
			if (user == null)
				return NotFound();

			user.FirstName = userDto.FirstName;
			user.LastName = userDto.LastName;
			user.Country = userDto.Country;
			user.UserName = userDto.UserName;

			await _userManager.UpdateAsync(user);

			return NoContent();
        }

    }
}