using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace mvc_app.Migrations
{
    public partial class DataFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "data402",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "data401",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<decimal>(
                name: "BagPoly",
                table: "data106_1",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "BagWastePlenka",
                table: "data106_1",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PlenkaPoly",
                table: "data106_1",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PlenkaWastePlenka",
                table: "data106_1",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Polyethylene1Bag",
                table: "data106_1",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Polyethylene1Plenka",
                table: "data106_1",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "UVS",
                table: "data104",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "UVS",
                table: "data101",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "data402");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "data401");

            migrationBuilder.DropColumn(
                name: "BagPoly",
                table: "data106_1");

            migrationBuilder.DropColumn(
                name: "BagWastePlenka",
                table: "data106_1");

            migrationBuilder.DropColumn(
                name: "PlenkaPoly",
                table: "data106_1");

            migrationBuilder.DropColumn(
                name: "PlenkaWastePlenka",
                table: "data106_1");

            migrationBuilder.DropColumn(
                name: "Polyethylene1Bag",
                table: "data106_1");

            migrationBuilder.DropColumn(
                name: "Polyethylene1Plenka",
                table: "data106_1");

            migrationBuilder.DropColumn(
                name: "UVS",
                table: "data104");

            migrationBuilder.DropColumn(
                name: "UVS",
                table: "data101");
        }
    }
}
