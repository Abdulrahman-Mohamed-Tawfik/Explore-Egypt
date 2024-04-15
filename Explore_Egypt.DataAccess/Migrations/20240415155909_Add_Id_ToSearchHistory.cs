using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Explore_Egypt.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Add_Id_ToSearchHistory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SearchHistory_Landmarks_LandmarkID",
                table: "SearchHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_SearchHistory_User_UserId",
                table: "SearchHistory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SearchHistory",
                table: "SearchHistory");

            migrationBuilder.AlterColumn<int>(
                name: "LandmarkID",
                table: "SearchHistory",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "SearchHistory",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "SearchHistory",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SearchHistory",
                table: "SearchHistory",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_SearchHistory_UserId",
                table: "SearchHistory",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_SearchHistory_Landmarks_LandmarkID",
                table: "SearchHistory",
                column: "LandmarkID",
                principalTable: "Landmarks",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SearchHistory_User_UserId",
                table: "SearchHistory",
                column: "UserId",
                principalSchema: "security",
                principalTable: "User",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SearchHistory_Landmarks_LandmarkID",
                table: "SearchHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_SearchHistory_User_UserId",
                table: "SearchHistory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SearchHistory",
                table: "SearchHistory");

            migrationBuilder.DropIndex(
                name: "IX_SearchHistory_UserId",
                table: "SearchHistory");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "SearchHistory");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "SearchHistory",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LandmarkID",
                table: "SearchHistory",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SearchHistory",
                table: "SearchHistory",
                columns: new[] { "UserId", "LandmarkID" });

            migrationBuilder.AddForeignKey(
                name: "FK_SearchHistory_Landmarks_LandmarkID",
                table: "SearchHistory",
                column: "LandmarkID",
                principalTable: "Landmarks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SearchHistory_User_UserId",
                table: "SearchHistory",
                column: "UserId",
                principalSchema: "security",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
