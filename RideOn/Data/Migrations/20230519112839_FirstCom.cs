using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RideOn.Data.Migrations
{
    /// <inheritdoc />
    public partial class FirstCom : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Year",
                table: "Car",
                newName: "Seat");

            migrationBuilder.RenameColumn(
                name: "Color",
                table: "Car",
                newName: "Shift");

            migrationBuilder.AddColumn<int>(
                name: "Doors",
                table: "Car",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Doors",
                table: "Car");

            migrationBuilder.RenameColumn(
                name: "Shift",
                table: "Car",
                newName: "Color");

            migrationBuilder.RenameColumn(
                name: "Seat",
                table: "Car",
                newName: "Year");
        }
    }
}
