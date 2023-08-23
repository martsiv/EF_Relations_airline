using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Relations_airline.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenderName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Airplanes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxPassengers = table.Column<int>(type: "int", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Airplanes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Airplanes_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GenderId = table.Column<int>(type: "int", nullable: false),
                    AccountId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clients_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clients_Genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Genders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Flights",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartureDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArrivalDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeparturePlace = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArrivalPlace = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AirplaneId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flights", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Flights_Airplanes_AirplaneId",
                        column: x => x.AirplaneId,
                        principalTable: "Airplanes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClientFlight",
                columns: table => new
                {
                    ClientsId = table.Column<int>(type: "int", nullable: false),
                    FlightsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientFlight", x => new { x.ClientsId, x.FlightsId });
                    table.ForeignKey(
                        name: "FK_ClientFlight_Clients_ClientsId",
                        column: x => x.ClientsId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientFlight_Flights_FlightsId",
                        column: x => x.FlightsId,
                        principalTable: "Flights",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Login", "Password" },
                values: new object[,]
                {
                    { 1, "willsmith", "qwerty1" },
                    { 2, "abrahamg", "qwerty1" },
                    { 3, "sarahb", "qwerty1" },
                    { 4, "annared", "qwerty1" },
                    { 5, "riardenw", "qwerty1" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Ukraine" },
                    { 2, "USA" },
                    { 3, "United Kingdom" },
                    { 4, "German" },
                    { 5, "Italy" },
                    { 6, "Australia" }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "GenderName" },
                values: new object[,]
                {
                    { 1, "Male" },
                    { 2, "Female" }
                });

            migrationBuilder.InsertData(
                table: "Airplanes",
                columns: new[] { "Id", "CountryId", "MaxPassengers", "Model" },
                values: new object[,]
                {
                    { 1, 1, 300, "AN-15" },
                    { 2, 6, 8, "Super Jet 03" },
                    { 3, 3, 220, "Airbus CW-2" },
                    { 4, 2, 280, "Boeing 747" }
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "AccountId", "Email", "GenderId", "Name", "Surname" },
                values: new object[,]
                {
                    { 1, 1, "wills@gmail.com", 1, "Will", "Smith" },
                    { 2, 2, "abrahamg@gmail.com", 1, "Abraham", "Green" },
                    { 3, 3, "sarahb@gmail.com", 2, "Sarah", "Black" },
                    { 4, 4, "annared@gmail.com", 2, "Anna", "Red" },
                    { 5, 5, "riardenw@gmail.com", 1, "Riarden", "White" }
                });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "Id", "AirplaneId", "ArrivalDate", "ArrivalPlace", "DepartureDate", "DeparturePlace", "Number" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 11, 25, 17, 40, 0, 0, DateTimeKind.Unspecified), "Sidney", new DateTime(2023, 11, 26, 1, 0, 0, 0, DateTimeKind.Unspecified), "Dallas", "12N" },
                    { 2, 2, new DateTime(2023, 10, 14, 12, 30, 0, 0, DateTimeKind.Unspecified), "London", new DateTime(2023, 10, 14, 15, 0, 0, 0, DateTimeKind.Unspecified), "New York", "42D" },
                    { 3, 3, new DateTime(2023, 12, 16, 17, 40, 0, 0, DateTimeKind.Unspecified), "Paris", new DateTime(2023, 12, 16, 1, 0, 0, 0, DateTimeKind.Unspecified), "Los-Angeles", "24R" },
                    { 4, 1, new DateTime(2023, 9, 2, 17, 40, 0, 0, DateTimeKind.Unspecified), "Berlin", new DateTime(2023, 9, 2, 1, 0, 0, 0, DateTimeKind.Unspecified), "Mexico City", "25G" },
                    { 5, 4, new DateTime(2023, 10, 27, 17, 40, 0, 0, DateTimeKind.Unspecified), "Lisboa", new DateTime(2023, 10, 27, 1, 0, 0, 0, DateTimeKind.Unspecified), "New Deli", "63R" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Airplanes_CountryId",
                table: "Airplanes",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientFlight_FlightsId",
                table: "ClientFlight",
                column: "FlightsId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_AccountId",
                table: "Clients",
                column: "AccountId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Clients_GenderId",
                table: "Clients",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Flights_AirplaneId",
                table: "Flights",
                column: "AirplaneId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientFlight");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Flights");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "Airplanes");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
