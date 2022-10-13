using Microsoft.EntityFrameworkCore.Migrations;

namespace mvc_app.Migrations
{
    public partial class NewFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "PackagingKit",
                table: "data402",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "NatriiWater",
                table: "data401",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "SulphAcidWater",
                table: "data401",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Water",
                table: "data401",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ACG",
                table: "data201",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Katalizator",
                table: "data201",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "NAK",
                table: "data201",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "NAKpolufab",
                table: "data201",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "NAKtovar",
                table: "data201",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PackagingKit",
                table: "data402");

            migrationBuilder.DropColumn(
                name: "NatriiWater",
                table: "data401");

            migrationBuilder.DropColumn(
                name: "SulphAcidWater",
                table: "data401");

            migrationBuilder.DropColumn(
                name: "Water",
                table: "data401");

            migrationBuilder.DropColumn(
                name: "ACG",
                table: "data201");

            migrationBuilder.DropColumn(
                name: "Katalizator",
                table: "data201");

            migrationBuilder.DropColumn(
                name: "NAK",
                table: "data201");

            migrationBuilder.DropColumn(
                name: "NAKpolufab",
                table: "data201");

            migrationBuilder.DropColumn(
                name: "NAKtovar",
                table: "data201");
        }
    }
}
