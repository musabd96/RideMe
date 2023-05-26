using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RideMe.Data.Migrations
{
    /// <inheritdoc />
    public partial class IEnumerableCar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookingId",
                table: "Car",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Car_BookingId",
                table: "Car",
                column: "BookingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Booking_BookingId",
                table: "Car",
                column: "BookingId",
                principalTable: "Booking",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Car_Booking_BookingId",
                table: "Car");

            migrationBuilder.DropIndex(
                name: "IX_Car_BookingId",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "BookingId",
                table: "Car");
        }
    }
}
