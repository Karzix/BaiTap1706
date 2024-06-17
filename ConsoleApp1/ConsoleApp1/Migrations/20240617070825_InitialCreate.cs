using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp1.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "header",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DocumentNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentOpenDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentCompletedDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentInvoiceDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RepairOrderCustomerPayTotalPrice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceAdvisorEmpIDCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceAdvisorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvoiceOrCredit = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_header", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "identifiers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RecordIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TimeCreate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DealerNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Make = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Store = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Version = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_identifiers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "header");

            migrationBuilder.DropTable(
                name: "identifiers");
        }
    }
}
