using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RideMe.Data.Migrations
{
    /// <inheritdoc />
    public partial class RentalsInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookingId",
                table: "Rentals",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rentals_BookingId",
                table: "Rentals",
                column: "BookingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rentals_Booking_BookingId",
                table: "Rentals",
                column: "BookingId",
                principalTable: "Booking",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rentals_Booking_BookingId",
                table: "Rentals");

            migrationBuilder.DropIndex(
                name: "IX_Rentals_BookingId",
                table: "Rentals");

            migrationBuilder.DropColumn(
                name: "BookingId",
                table: "Rentals");
        }
    }
}
