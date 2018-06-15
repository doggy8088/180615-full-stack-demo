using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace demo1.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ScenicSpots",
                columns: table => new
                {
                    Ticketinfo = table.Column<int>(nullable: false),
                    Zone = table.Column<string>(nullable: true),
                    Px = table.Column<string>(nullable: true),
                    Py = table.Column<string>(nullable: true),
                    Add = table.Column<string>(nullable: true),
                    Gov = table.Column<int>(nullable: false),
                    Class2 = table.Column<string>(nullable: true),
                    Class1 = table.Column<string>(nullable: true),
                    Website = table.Column<string>(nullable: true),
                    Opentime = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Remarks = table.Column<string>(nullable: true),
                    ParkinginfoPy = table.Column<int>(nullable: false),
                    ParkinginfoPx = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Level = table.Column<string>(nullable: true),
                    Picture1 = table.Column<string>(nullable: true),
                    Toldescribe = table.Column<string>(nullable: true),
                    Changetime = table.Column<DateTimeOffset>(nullable: false),
                    Tel = table.Column<string>(nullable: true),
                    Picdescribe1 = table.Column<string>(nullable: true),
                    Travellinginfo = table.Column<int>(nullable: false),
                    RecordId = table.Column<long>(nullable: false),
                    Id = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScenicSpots", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ScenicSpots");
        }
    }
}
