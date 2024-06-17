using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp1.Migrations
{
    public partial class AddForeignKeyForHEADER : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "IDENTID",
                table: "header",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_header_IDENTID",
                table: "header",
                column: "IDENTID");

            migrationBuilder.AddForeignKey(
                name: "FK_header_identifiers_IDENTID",
                table: "header",
                column: "IDENTID",
                principalTable: "identifiers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_header_identifiers_IDENTID",
                table: "header");

            migrationBuilder.DropIndex(
                name: "IX_header_IDENTID",
                table: "header");

            migrationBuilder.DropColumn(
                name: "IDENTID",
                table: "header");
        }
    }
}
