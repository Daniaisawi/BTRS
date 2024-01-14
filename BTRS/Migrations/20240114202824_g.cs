using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BTRS.Migrations
{
    public partial class g : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_booking_passenger_Passenger_Id",
                table: "booking");

            migrationBuilder.DropForeignKey(
                name: "FK_booking_Trips_BusTrip_Id",
                table: "booking");

            migrationBuilder.DropForeignKey(
                name: "FK_buses_admin_Admin_Id",
                table: "buses");

            migrationBuilder.DropForeignKey(
                name: "FK_buses_Trips_BusTrip_Id",
                table: "buses");

            migrationBuilder.DropForeignKey(
                name: "FK_passenger_admin_Admin_Id",
                table: "passenger");

            migrationBuilder.RenameColumn(
                name: "Admin_Id",
                table: "passenger",
                newName: "Admin_ID");

            migrationBuilder.RenameIndex(
                name: "IX_passenger_Admin_Id",
                table: "passenger",
                newName: "IX_passenger_Admin_ID");

            migrationBuilder.RenameColumn(
                name: "BusTrip_Id",
                table: "buses",
                newName: "BusTrip_ID");

            migrationBuilder.RenameColumn(
                name: "Admin_Id",
                table: "buses",
                newName: "Admin_ID");

            migrationBuilder.RenameIndex(
                name: "IX_buses_BusTrip_Id",
                table: "buses",
                newName: "IX_buses_BusTrip_ID");

            migrationBuilder.RenameIndex(
                name: "IX_buses_Admin_Id",
                table: "buses",
                newName: "IX_buses_Admin_ID");

            migrationBuilder.RenameColumn(
                name: "Passenger_Id",
                table: "booking",
                newName: "Passenger_ID");

            migrationBuilder.RenameColumn(
                name: "BusTrip_Id",
                table: "booking",
                newName: "BusTrip_ID");

            migrationBuilder.RenameIndex(
                name: "IX_booking_Passenger_Id",
                table: "booking",
                newName: "IX_booking_Passenger_ID");

            migrationBuilder.RenameIndex(
                name: "IX_booking_BusTrip_Id",
                table: "booking",
                newName: "IX_booking_BusTrip_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_booking_passenger_Passenger_ID",
                table: "booking",
                column: "Passenger_ID",
                principalTable: "passenger",
                principalColumn: "PassengerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_booking_Trips_BusTrip_ID",
                table: "booking",
                column: "BusTrip_ID",
                principalTable: "Trips",
                principalColumn: "TripID"
                );

            migrationBuilder.AddForeignKey(
                name: "FK_buses_admin_Admin_ID",
                table: "buses",
                column: "Admin_ID",
                principalTable: "admin",
                principalColumn: "AdminID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_buses_Trips_BusTrip_ID",
                table: "buses",
                column: "BusTrip_ID",
                principalTable: "Trips",
                principalColumn: "TripID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_passenger_admin_Admin_ID",
                table: "passenger",
                column: "Admin_ID",
                principalTable: "admin",
                principalColumn: "AdminID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_booking_passenger_Passenger_ID",
                table: "booking");

            migrationBuilder.DropForeignKey(
                name: "FK_booking_Trips_BusTrip_ID",
                table: "booking");

            migrationBuilder.DropForeignKey(
                name: "FK_buses_admin_Admin_ID",
                table: "buses");

            migrationBuilder.DropForeignKey(
                name: "FK_buses_Trips_BusTrip_ID",
                table: "buses");

            migrationBuilder.DropForeignKey(
                name: "FK_passenger_admin_Admin_ID",
                table: "passenger");

            migrationBuilder.RenameColumn(
                name: "Admin_ID",
                table: "passenger",
                newName: "Admin_Id");

            migrationBuilder.RenameIndex(
                name: "IX_passenger_Admin_ID",
                table: "passenger",
                newName: "IX_passenger_Admin_Id");

            migrationBuilder.RenameColumn(
                name: "BusTrip_ID",
                table: "buses",
                newName: "BusTrip_Id");

            migrationBuilder.RenameColumn(
                name: "Admin_ID",
                table: "buses",
                newName: "Admin_Id");

            migrationBuilder.RenameIndex(
                name: "IX_buses_BusTrip_ID",
                table: "buses",
                newName: "IX_buses_BusTrip_Id");

            migrationBuilder.RenameIndex(
                name: "IX_buses_Admin_ID",
                table: "buses",
                newName: "IX_buses_Admin_Id");

            migrationBuilder.RenameColumn(
                name: "Passenger_ID",
                table: "booking",
                newName: "Passenger_Id");

            migrationBuilder.RenameColumn(
                name: "BusTrip_ID",
                table: "booking",
                newName: "BusTrip_Id");

            migrationBuilder.RenameIndex(
                name: "IX_booking_Passenger_ID",
                table: "booking",
                newName: "IX_booking_Passenger_Id");

            migrationBuilder.RenameIndex(
                name: "IX_booking_BusTrip_ID",
                table: "booking",
                newName: "IX_booking_BusTrip_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_booking_passenger_Passenger_Id",
                table: "booking",
                column: "Passenger_Id",
                principalTable: "passenger",
                principalColumn: "PassengerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_booking_Trips_BusTrip_Id",
                table: "booking",
                column: "BusTrip_Id",
                principalTable: "Trips",
                principalColumn: "TripID"
               );

            migrationBuilder.AddForeignKey(
                name: "FK_buses_admin_Admin_Id",
                table: "buses",
                column: "Admin_Id",
                principalTable: "admin",
                principalColumn: "AdminID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_buses_Trips_BusTrip_Id",
                table: "buses",
                column: "BusTrip_Id",
                principalTable: "Trips",
                principalColumn: "TripID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_passenger_admin_Admin_Id",
                table: "passenger",
                column: "Admin_Id",
                principalTable: "admin",
                principalColumn: "AdminID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
