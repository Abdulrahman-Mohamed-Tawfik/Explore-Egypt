using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Explore_Egypt.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddAdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
			migrationBuilder.Sql("INSERT INTO [security].[User] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Country], [FirstName], [LastName]) VALUES (N'7e56ce75-e7e1-48cc-ac42-89aad7b8ae30', N'exploreegypt123', N'EXPLOREEGYPT123', N'exploreegypt123@gmail.com', N'EXPLOREEGYPT123@GMAIL.COM', 0, N'AQAAAAIAAYagAAAAEG2oNC3CWJLr1M6VPCb1huf/CPgAMyGRKJlVp4/BJ8yeEwqFHPi9U67Lebwo6c02Nw==', N'5XMXL5OUQYWBP6R553MTO5MA2WPB5MEO', N'e1fb7fd6-ed23-4ce0-ab6d-248310150eda', 0, NULL, 1, 0, N'Egypt', N'ِAbdelrahman', N'Mohamed')");

		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
        {
			migrationBuilder.Sql("DELETE FROM [security].[User] WHERE Id = '7e56ce75-e7e1-48cc-ac42-89aad7b8ae30'");
		}
	}
}
