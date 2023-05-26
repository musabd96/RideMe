using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RideMe.Data.Migrations
{
    /// <inheritdoc />
    public partial class RentalsId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Rentals_RentalsId1",
                table: "Booking");

            migrationBuilder.DropIndex(
                name: "IX_Booking_RentalsId1",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "RentalsId1",
                table: "Booking");

            migrationBuilder.RenameColumn(
                name: "ReservationId",
                table: "Booking",
                newName: "RentalsId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_RentalsId",
                table: "Booking",
                column: "RentalsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Rentals_RentalsId",
                table: "Booking",
                column: "RentalsId",
                principalTable: "Rentals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Rentals_RentalsId",
                table: "Booking");

            migrationBuilder.DropIndex(
                name: "IX_Booking_RentalsId",
                table: "Booking");

            migrationBuilder.RenameColumn(
                name: "RentalsId",
                table: "Booking",
                newName: "ReservationId");

            migrationBuilder.AddColumn<int>(
                name: "RentalsId1",
                table: "Booking",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
    }
}
