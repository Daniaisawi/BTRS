using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BTRS.Migrations
{
    public partial class a : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "admin",
                columns: table => new
                {
                    AdminID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_admin", x => x.AdminID);
                });

            migrationBuilder.CreateTable(
                name: "passenger",
                columns: table => new
                {
                    PassengerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Admin_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_passenger", x => x.PassengerId);
                    table.ForeignKey(
                        name: "FK_passenger_admin_Admin_Id",
                        column: x => x.Admin_Id,
                        principalTable: "admin",
                        principalColumn: "AdminID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Trips",
                columns: table => new
                {
                    TripID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Destination = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BusNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Admin_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trips", x => x.TripID);
                    table.ForeignKey(
                        name: "FK_Trips_admin_Admin_Id",
                        column: x => x.Admin_Id,
                        principalTable: "admin",
                        principalColumn: "AdminID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "booking",
                columns: table => new
                {
                    BookingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Passenger_Id = table.Column<int>(type: "int", nullable: false),
                    BusTrip_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_booking", x => x.BookingID);
                    table.ForeignKey(
                        name: "FK_booking_passenger_Passenger_Id",
                        column: x => x.Passenger_Id,
                        principalTable: "passenger",
                        principalColumn: "PassengerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_booking_Trips_BusTrip_Id",
                        column: x => x.BusTrip_Id,
                        principalTable: "Trips",
                        principalColumn: "TripID"
                        );
                });

            migrationBuilder.CreateTable(
                name: "buses",
                columns: table => new
                {
                    BusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CaptainName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfSeats = table.Column<int>(type: "int", nullable: false),
                    BusTrip_Id = table.Column<int>(type: "int", nullable: false),
                    Admin_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_buses", x => x.BusID);
                    table.ForeignKey(
                        name: "FK_buses_admin_Admin_Id",
                        column: x => x.Admin_Id,
                        principalTable: "admin",
                        principalColumn: "AdminID"
                       );
                    table.ForeignKey(
                        name: "FK_buses_Trips_BusTrip_Id",
                        column: x => x.BusTrip_Id,
                        principalTable: "Trips",
                        principalColumn: "TripID"
                       );
                });

            migrationBuilder.CreateIndex(
                name: "IX_booking_BusTrip_Id",
                table: "booking",
                column: "BusTrip_Id");

            migrationBuilder.CreateIndex(
                name: "IX_booking_Passenger_Id",
                table: "booking",
                column: "Passenger_Id");

            migrationBuilder.CreateIndex(
                name: "IX_buses_Admin_Id",
                table: "buses",
                column: "Admin_Id");

            migrationBuilder.CreateIndex(
                name: "IX_buses_BusTrip_Id",
                table: "buses",
                column: "BusTrip_Id");

            migrationBuilder.CreateIndex(
                name: "IX_passenger_Admin_Id",
                table: "passenger",
                column: "Admin_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Trips_Admin_Id",
                table: "Trips",
                column: "Admin_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "booking");

            migrationBuilder.DropTable(
                name: "buses");

            migrationBuilder.DropTable(
                name: "passenger");

            migrationBuilder.DropTable(
                name: "Trips");

            migrationBuilder.DropTable(
                name: "admin");
        }
    }
}
