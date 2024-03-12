using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Explore_Egypt.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdateLandmarkTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Close_time",
                table: "Landmarks");

            migrationBuilder.DropColumn(
                name: "Open_time",
                table: "Landmarks");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Landmarks");

            migrationBuilder.AddColumn<TimeOnly>(
                name: "CloseTime",
                table: "Landmarks",
                type: "time",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "EgyptianStudentTicketPrice",
                table: "Landmarks",
                type: "decimal(18,4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "EgyptianTicketPrice",
                table: "Landmarks",
                type: "decimal(18,4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ForeignStudentTicketPrice",
                table: "Landmarks",
                type: "decimal(18,4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ForeignTicketPrice",
                table: "Landmarks",
                type: "decimal(18,4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<TimeOnly>(
                name: "OpenTime",
                table: "Landmarks",
                type: "time",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CloseTime", "EgyptianStudentTicketPrice", "EgyptianTicketPrice", "ForeignStudentTicketPrice", "ForeignTicketPrice", "OpenTime" },
                values: new object[] { new TimeOnly(10, 20, 30), 10.2m, 10.2m, 10.2m, 10.2m, new TimeOnly(10, 20, 30) });

            migrationBuilder.UpdateData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CloseTime", "EgyptianStudentTicketPrice", "EgyptianTicketPrice", "ForeignStudentTicketPrice", "ForeignTicketPrice", "OpenTime" },
                values: new object[] { new TimeOnly(10, 20, 30), 10.2m, 10.2m, 10.2m, 10.2m, new TimeOnly(10, 20, 30) });

            migrationBuilder.UpdateData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CloseTime", "EgyptianStudentTicketPrice", "EgyptianTicketPrice", "ForeignStudentTicketPrice", "ForeignTicketPrice", "OpenTime" },
                values: new object[] { new TimeOnly(10, 20, 30), 10.2m, 10.2m, 10.2m, 10.2m, new TimeOnly(10, 20, 30) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CloseTime",
                table: "Landmarks");

            migrationBuilder.DropColumn(
                name: "EgyptianStudentTicketPrice",
                table: "Landmarks");

            migrationBuilder.DropColumn(
                name: "EgyptianTicketPrice",
                table: "Landmarks");

            migrationBuilder.DropColumn(
                name: "ForeignStudentTicketPrice",
                table: "Landmarks");

            migrationBuilder.DropColumn(
                name: "ForeignTicketPrice",
                table: "Landmarks");

            migrationBuilder.DropColumn(
                name: "OpenTime",
                table: "Landmarks");

            migrationBuilder.AddColumn<string>(
                name: "Close_time",
                table: "Landmarks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Open_time",
                table: "Landmarks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Price",
                table: "Landmarks",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.UpdateData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Close_time", "Open_time", "Price" },
                values: new object[] { "", "", 10f });

            migrationBuilder.UpdateData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Close_time", "Open_time", "Price" },
                values: new object[] { "", "", 10f });

            migrationBuilder.UpdateData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Close_time", "Open_time", "Price" },
                values: new object[] { "", "", 10f });
        }
    }
}
