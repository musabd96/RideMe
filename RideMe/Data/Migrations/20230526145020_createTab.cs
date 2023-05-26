using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RideMe.Data.Migrations
{
    /// <inheritdoc />
    public partial class createTab : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Reservations_ReservationsId",
                table: "Booking");

            migrationBuilder.RenameColumn(
                name: "ReservationsId",
                table: "Booking",
                newName: "ReservationId");

            migrationBuilder.RenameIndex(
                name: "IX_Booking_ReservationsId",
                table: "Booking",
                newName: "IX_Booking_ReservationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Reservations_ReservationId",
                table: "Booking",
                column: "ReservationId",
                principalTable: "Reservations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Reservations_ReservationId",
                table: "Booking");

            migrationBuilder.RenameColumn(
                name: "ReservationId",
                table: "Booking",
                newName: "ReservationsId");

            migrationBuilder.RenameIndex(
                name: "IX_Booking_ReservationId",
                table: "Booking",
                newName: "IX_Booking_ReservationsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Reservations_ReservationsId",
                table: "Booking",
                column: "ReservationsId",
                principalTable: "Reservations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
