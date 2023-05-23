using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RideOn.Data.Migrations
{
    /// <inheritdoc />
    public partial class Reservation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "Reservation",
                newName: "ReturnTime");

            migrationBuilder.RenameColumn(
                name: "EndDate",
                table: "Reservation",
                newName: "ReturnDate");

            migrationBuilder.AddColumn<DateTime>(
                name: "PickUpDate",
                table: "Reservation",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "PickUpLocation",
                table: "Reservation",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "PickUpTime",
                table: "Reservation",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PickUpDate",
                table: "Reservation");

            migrationBuilder.DropColumn(
                name: "PickUpLocation",
                table: "Reservation");

            migrationBuilder.DropColumn(
                name: "PickUpTime",
                table: "Reservation");

            migrationBuilder.RenameColumn(
                name: "ReturnTime",
                table: "Reservation",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "ReturnDate",
                table: "Reservation",
                newName: "EndDate");
        }
    }
}
