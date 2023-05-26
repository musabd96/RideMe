using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RideMe.Data.Migrations
{
    /// <inheritdoc />
    public partial class Rentals : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Reservations_ReservationId",
                table: "Booking");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Booking_ReservationId",
                table: "Booking");

            migrationBuilder.AddColumn<int>(
                name: "RentalsId1",
                table: "Booking",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Rentals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PickupLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PickupDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PickupTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReturnTime = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rentals", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Booking_RentalsId1",
                table: "Booking",
                column: "RentalsId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Rentals_RentalsId1",
                table: "Booking",
                column: "RentalsId1",
                principalTable: "Rentals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Rentals_RentalsId1",
                table: "Booking");

            migrationBuilder.DropTable(
                name: "Rentals");

            migrationBuilder.DropIndex(
                name: "IX_Booking_RentalsId1",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "RentalsId1",
                table: "Booking");

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PickupDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PickupLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PickupTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReturnTime = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Booking_ReservationId",
                table: "Booking",
                column: "ReservationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Reservations_ReservationId",
                table: "Booking",
                column: "ReservationId",
                principalTable: "Reservations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
