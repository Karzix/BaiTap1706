using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp1.Migrations
{
    public partial class addTableVehicle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "vehicle",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RepairOrderVIN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DMSMakeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModelYear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LicenseNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeliveryDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehicle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_vehicle_header_HeaderId",
                        column: x => x.HeaderId,
                        principalTable: "header",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_vehicle_HeaderId",
                table: "vehicle",
                column: "HeaderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "vehicle");
        }
    }
}
