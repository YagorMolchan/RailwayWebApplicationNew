using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RailwayNew1.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Durations",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        Name = table.Column<string>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Durations", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Passengers",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        Surename = table.Column<string>(nullable: true),
            //        Name = table.Column<string>(nullable: true),
            //        Patronymic = table.Column<string>(nullable: true),
            //        TypeOfDocument = table.Column<string>(nullable: true),
            //        NumberOfDocument = table.Column<string>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Passengers", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Routes",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        Start = table.Column<string>(nullable: true),
            //        Finish = table.Column<string>(nullable: true),
            //        Country = table.Column<string>(nullable: true),
            //        Category = table.Column<string>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Routes", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Users",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        Surename = table.Column<string>(nullable: true),
            //        Name = table.Column<string>(nullable: true),
            //        Email = table.Column<string>(nullable: true),
            //        Phone = table.Column<string>(nullable: true),
            //        Username = table.Column<string>(nullable: true),
            //        Password = table.Column<string>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Users", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Wagons",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        Type = table.Column<string>(nullable: true),
            //        SeatCount = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Wagons", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Stations",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        Name = table.Column<string>(nullable: true),
            //        Type = table.Column<string>(nullable: true),
            //        Country = table.Column<string>(nullable: true),
            //        DurationId = table.Column<int>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Stations", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Stations_Durations_DurationId",
            //            column: x => x.DurationId,
            //            principalTable: "Durations",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Trips",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        Date = table.Column<DateTime>(nullable: false),
            //        RouteId = table.Column<int>(nullable: false),
            //        CompartmentCount = table.Column<int>(nullable: true),
            //        EconomClassCount = table.Column<int>(nullable: true),
            //        SeatCount = table.Column<int>(nullable: true),
            //        SleepingCount = table.Column<int>(nullable: true),
            //        LuxuryCount = table.Column<int>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Trips", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Trips_Routes_RouteId",
            //            column: x => x.RouteId,
            //            principalTable: "Routes",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Orders",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        UserId = table.Column<int>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Orders", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Orders_Users_UserId",
            //            column: x => x.UserId,
            //            principalTable: "Users",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "WagonRoute",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        RouteId = table.Column<int>(nullable: true),
            //        WagonId = table.Column<int>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_WagonRoute", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_WagonRoute_Routes_RouteId",
            //            column: x => x.RouteId,
            //            principalTable: "Routes",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_WagonRoute_Wagons_WagonId",
            //            column: x => x.WagonId,
            //            principalTable: "Wagons",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "RouteStation",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        RouteId = table.Column<int>(nullable: true),
            //        StationId = table.Column<int>(nullable: true),
            //        Arrival = table.Column<TimeSpan>(nullable: true),
            //        ParkingTime = table.Column<TimeSpan>(nullable: true),
            //        Departure = table.Column<TimeSpan>(nullable: true),
            //        Distance = table.Column<float>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_RouteStation", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_RouteStation_Routes_RouteId",
            //            column: x => x.RouteId,
            //            principalTable: "Routes",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_RouteStation_Stations_StationId",
            //            column: x => x.StationId,
            //            principalTable: "Stations",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Tickets",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        TypeOfTicket = table.Column<string>(nullable: true),
            //        PassengerId = table.Column<int>(nullable: false),
            //        TripId = table.Column<int>(nullable: true),
            //        OrderId = table.Column<int>(nullable: true),
            //        SeatNumber = table.Column<int>(nullable: false),
            //        WagonNumber = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Tickets", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Tickets_Orders_OrderId",
            //            column: x => x.OrderId,
            //            principalTable: "Orders",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_Tickets_Passengers_PassengerId",
            //            column: x => x.PassengerId,
            //            principalTable: "Passengers",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_Tickets_Trips_TripId",
            //            column: x => x.TripId,
            //            principalTable: "Trips",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_Orders_UserId",
            //    table: "Orders",
            //    column: "UserId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_RouteStation_RouteId",
            //    table: "RouteStation",
            //    column: "RouteId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_RouteStation_StationId",
            //    table: "RouteStation",
            //    column: "StationId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Stations_DurationId",
            //    table: "Stations",
            //    column: "DurationId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Tickets_OrderId",
            //    table: "Tickets",
            //    column: "OrderId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Tickets_PassengerId",
            //    table: "Tickets",
            //    column: "PassengerId",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_Tickets_TripId",
            //    table: "Tickets",
            //    column: "TripId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Trips_RouteId",
            //    table: "Trips",
            //    column: "RouteId",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_WagonRoute_RouteId",
            //    table: "WagonRoute",
            //    column: "RouteId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_WagonRoute_WagonId",
            //    table: "WagonRoute",
            //    column: "WagonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RouteStation");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "WagonRoute");

            migrationBuilder.DropTable(
                name: "Stations");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Passengers");

            migrationBuilder.DropTable(
                name: "Trips");

            migrationBuilder.DropTable(
                name: "Wagons");

            migrationBuilder.DropTable(
                name: "Durations");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Routes");
        }
    }
}
