using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Explore_Egypt.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AssignAdminToAdminRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
			migrationBuilder.Sql("INSERT INTO security.UserRoles VALUES('7e56ce75-e7e1-48cc-ac42-89aad7b8ae30', (SELECT Id FROM security.Role WHERE Name = 'ADMIN'))");
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
        {
			migrationBuilder.Sql("DELETE FROM security.UserRoles WHERE UserId = '7e56ce75-e7e1-48cc-ac42-89aad7b8ae30'");
		}
	}
}
