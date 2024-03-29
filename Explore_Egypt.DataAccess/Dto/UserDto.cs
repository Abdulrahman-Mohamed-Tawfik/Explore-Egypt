﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explore_Egypt.DataAccess.Dto
{
	public class UserDto
	{
		public string Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string? UserName { get; set; }
		public string Email { get; set; }
		public string Country { get; set; }
		public string Password { get; set; }
		public IEnumerable<string>? Roles { get; set; }
	}
}
