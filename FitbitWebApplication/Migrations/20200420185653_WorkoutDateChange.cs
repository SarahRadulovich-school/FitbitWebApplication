using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FitbitWebApplication.Migrations
{
    public partial class WorkoutDateChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TimeEnded",
                table: "Workouts");

            migrationBuilder.DropColumn(
                name: "TimeStarted",
                table: "Workouts");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Workouts",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Workouts");

            migrationBuilder.AddColumn<DateTime>(
                name: "TimeEnded",
                table: "Workouts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "TimeStarted",
                table: "Workouts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
