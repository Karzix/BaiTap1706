using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp1.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CCR",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Complaint = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cause = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Resolution = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CCR", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CCR_header_HeaderId",
                        column: x => x.HeaderId,
                        principalTable: "header",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CONTACT",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerSalutation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerEveningPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerDayPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerMobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerEmail2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerEmail3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerDear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONTACT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CONTACT_header_HeaderId",
                        column: x => x.HeaderId,
                        principalTable: "header",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "customer",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServiceCustomerSalutation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceCustomerLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceCustomerFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceCustomerAddress1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceCustomerAddress2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceCustomerCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceCustomerStateCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceCustomerPostCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceCustomerEveningPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceCustomerDayPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceCustomerEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceCustomerMobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DMSCustomerID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ABN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerContactType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssociatedDealerCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerEmail2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerEmail3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_customer_header_HeaderId",
                        column: x => x.HeaderId,
                        principalTable: "header",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "job",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DMSJobNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DMSOperationCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DMSOperationDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobLabourPrice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobPartsPrice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobSubletPrice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobMiscellaneousPrice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobGOGPrice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobsSundryPrice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobLabourCOS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_job", x => x.Id);
                    table.ForeignKey(
                        name: "FK_job_header_HeaderId",
                        column: x => x.HeaderId,
                        principalTable: "header",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "laborline",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LabourOperationCodeType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_laborline", x => x.Id);
                    table.ForeignKey(
                        name: "FK_laborline_header_HeaderId",
                        column: x => x.HeaderId,
                        principalTable: "header",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "misc",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MiscellaneousCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiscellaneousDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiscellaneousPrice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiscellaneousPriceAfterSplit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiscellaneousSplitPercentage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiscellaneounsCostOfSale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_misc", x => x.Id);
                    table.ForeignKey(
                        name: "FK_misc_header_HeaderId",
                        column: x => x.HeaderId,
                        principalTable: "header",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "partline",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PartNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PartDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Count = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PartUnitCost = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PartUnitPrice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PartsWarehouse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RelatedVINForThisOrder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PartsBin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_partline", x => x.Id);
                    table.ForeignKey(
                        name: "FK_partline_header_HeaderId",
                        column: x => x.HeaderId,
                        principalTable: "header",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "privacy",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PrivacyIndicator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrivacyType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_privacy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_privacy_header_HeaderId",
                        column: x => x.HeaderId,
                        principalTable: "header",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CCR_HeaderId",
                table: "CCR",
                column: "HeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_CONTACT_HeaderId",
                table: "CONTACT",
                column: "HeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_customer_HeaderId",
                table: "customer",
                column: "HeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_job_HeaderId",
                table: "job",
                column: "HeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_laborline_HeaderId",
                table: "laborline",
                column: "HeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_misc_HeaderId",
                table: "misc",
                column: "HeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_partline_HeaderId",
                table: "partline",
                column: "HeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_privacy_HeaderId",
                table: "privacy",
                column: "HeaderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CCR");

            migrationBuilder.DropTable(
                name: "CONTACT");

            migrationBuilder.DropTable(
                name: "customer");

            migrationBuilder.DropTable(
                name: "job");

            migrationBuilder.DropTable(
                name: "laborline");

            migrationBuilder.DropTable(
                name: "misc");

            migrationBuilder.DropTable(
                name: "partline");

            migrationBuilder.DropTable(
                name: "privacy");
        }
    }
}
