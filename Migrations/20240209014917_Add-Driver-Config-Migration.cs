using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TransportReservationSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddDriverConfigMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Maintenances_Drivers_DriverId",
                table: "Maintenances");

            migrationBuilder.AddForeignKey(
                name: "FK_Maintenances_Drivers_DriverId",
                table: "Maintenances",
                column: "DriverId",
                principalTable: "Drivers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Maintenances_Drivers_DriverId",
                table: "Maintenances");

            migrationBuilder.AddForeignKey(
                name: "FK_Maintenances_Drivers_DriverId",
                table: "Maintenances",
                column: "DriverId",
                principalTable: "Drivers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
