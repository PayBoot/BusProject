using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DataLibrary.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TableBusStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    status = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableBusStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TableBusType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableBusType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TableEmpStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Status = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableEmpStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TableEmpType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableEmpType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TableLocation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Location = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableLocation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TableUser",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AuthoriseLevel = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Status = table.Column<string>(nullable: false),
                    UserType = table.Column<string>(nullable: false),
                    Username = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TableEmployee",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CurDistrict = table.Column<string>(nullable: true),
                    CurProvince = table.Column<string>(nullable: true),
                    CurVillege = table.Column<string>(nullable: true),
                    DOB = table.Column<string>(nullable: true),
                    EmpTypeId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: true),
                    StatusId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableEmployee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TableEmployee_TableEmpType_EmpTypeId",
                        column: x => x.EmpTypeId,
                        principalTable: "TableEmpType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TableEmployee_TableEmpStatus_StatusId",
                        column: x => x.StatusId,
                        principalTable: "TableEmpStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TableBus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LocationId = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    PlateNumber = table.Column<string>(nullable: false),
                    SeatCapacity = table.Column<double>(nullable: false),
                    StatusId = table.Column<int>(nullable: false),
                    TypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableBus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TableBus_TableLocation_LocationId",
                        column: x => x.LocationId,
                        principalTable: "TableLocation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TableBus_TableBusStatus_StatusId",
                        column: x => x.StatusId,
                        principalTable: "TableBusStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TableBus_TableBusType_TypeId",
                        column: x => x.TypeId,
                        principalTable: "TableBusType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TableRoute",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateOfRecord = table.Column<string>(nullable: false),
                    EndLocationId = table.Column<int>(nullable: true),
                    StartLocationId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableRoute", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TableRoute_TableLocation_EndLocationId",
                        column: x => x.EndLocationId,
                        principalTable: "TableLocation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TableRoute_TableLocation_StartLocationId",
                        column: x => x.StartLocationId,
                        principalTable: "TableLocation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TableUserLog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Login = table.Column<string>(nullable: true),
                    Logout = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableUserLog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TableUserLog_TableUser_UserId",
                        column: x => x.UserId,
                        principalTable: "TableUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TableSeat",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BusId = table.Column<int>(nullable: false),
                    SeatName = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableSeat", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TableSeat_TableBus_BusId",
                        column: x => x.BusId,
                        principalTable: "TableBus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TablePrice",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateOfRecord = table.Column<string>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    PriceType = table.Column<string>(nullable: false),
                    RouteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TablePrice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TablePrice_TableRoute_RouteId",
                        column: x => x.RouteId,
                        principalTable: "TableRoute",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TableTrip",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ArrivalTime = table.Column<string>(nullable: false),
                    BusId = table.Column<int>(nullable: false),
                    DateOfRecord = table.Column<string>(nullable: false),
                    DepartureTime = table.Column<string>(nullable: false),
                    RouteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableTrip", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TableTrip_TableBus_BusId",
                        column: x => x.BusId,
                        principalTable: "TableBus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TableTrip_TableRoute_RouteId",
                        column: x => x.RouteId,
                        principalTable: "TableRoute",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TableReservation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AmountSeat = table.Column<double>(nullable: false),
                    CancelationTime = table.Column<string>(nullable: true),
                    ReservationTime = table.Column<string>(nullable: false),
                    Status = table.Column<string>(nullable: false),
                    TripId = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: true),
                    priceId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableReservation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TableReservation_TableTrip_TripId",
                        column: x => x.TripId,
                        principalTable: "TableTrip",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TableReservation_TableUser_UserId",
                        column: x => x.UserId,
                        principalTable: "TableUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TableReservation_TablePrice_priceId",
                        column: x => x.priceId,
                        principalTable: "TablePrice",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TableTripAttendant",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateOfRecord = table.Column<string>(nullable: false),
                    StaffId = table.Column<int>(nullable: false),
                    TripId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableTripAttendant", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TableTripAttendant_TableEmployee_StaffId",
                        column: x => x.StaffId,
                        principalTable: "TableEmployee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TableTripAttendant_TableTrip_TripId",
                        column: x => x.TripId,
                        principalTable: "TableTrip",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TablePassenger",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReservationId = table.Column<int>(nullable: false),
                    SeatId = table.Column<int>(nullable: false),
                    TicketNumber = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TablePassenger", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TablePassenger_TableReservation_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "TableReservation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TablePassenger_TableSeat_SeatId",
                        column: x => x.SeatId,
                        principalTable: "TableSeat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TableBus_LocationId",
                table: "TableBus",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_TableBus_StatusId",
                table: "TableBus",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_TableBus_TypeId",
                table: "TableBus",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TableEmployee_EmpTypeId",
                table: "TableEmployee",
                column: "EmpTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TableEmployee_StatusId",
                table: "TableEmployee",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_TablePassenger_ReservationId",
                table: "TablePassenger",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_TablePassenger_SeatId",
                table: "TablePassenger",
                column: "SeatId");

            migrationBuilder.CreateIndex(
                name: "IX_TablePrice_RouteId",
                table: "TablePrice",
                column: "RouteId");

            migrationBuilder.CreateIndex(
                name: "IX_TableReservation_TripId",
                table: "TableReservation",
                column: "TripId");

            migrationBuilder.CreateIndex(
                name: "IX_TableReservation_UserId",
                table: "TableReservation",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TableReservation_priceId",
                table: "TableReservation",
                column: "priceId");

            migrationBuilder.CreateIndex(
                name: "IX_TableRoute_EndLocationId",
                table: "TableRoute",
                column: "EndLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_TableRoute_StartLocationId",
                table: "TableRoute",
                column: "StartLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_TableSeat_BusId",
                table: "TableSeat",
                column: "BusId");

            migrationBuilder.CreateIndex(
                name: "IX_TableTrip_BusId",
                table: "TableTrip",
                column: "BusId");

            migrationBuilder.CreateIndex(
                name: "IX_TableTrip_RouteId",
                table: "TableTrip",
                column: "RouteId");

            migrationBuilder.CreateIndex(
                name: "IX_TableTripAttendant_StaffId",
                table: "TableTripAttendant",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_TableTripAttendant_TripId",
                table: "TableTripAttendant",
                column: "TripId");

            migrationBuilder.CreateIndex(
                name: "IX_TableUserLog_UserId",
                table: "TableUserLog",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TablePassenger");

            migrationBuilder.DropTable(
                name: "TableTripAttendant");

            migrationBuilder.DropTable(
                name: "TableUserLog");

            migrationBuilder.DropTable(
                name: "TableReservation");

            migrationBuilder.DropTable(
                name: "TableSeat");

            migrationBuilder.DropTable(
                name: "TableEmployee");

            migrationBuilder.DropTable(
                name: "TableTrip");

            migrationBuilder.DropTable(
                name: "TableUser");

            migrationBuilder.DropTable(
                name: "TablePrice");

            migrationBuilder.DropTable(
                name: "TableEmpType");

            migrationBuilder.DropTable(
                name: "TableEmpStatus");

            migrationBuilder.DropTable(
                name: "TableBus");

            migrationBuilder.DropTable(
                name: "TableRoute");

            migrationBuilder.DropTable(
                name: "TableBusStatus");

            migrationBuilder.DropTable(
                name: "TableBusType");

            migrationBuilder.DropTable(
                name: "TableLocation");
        }
    }
}
