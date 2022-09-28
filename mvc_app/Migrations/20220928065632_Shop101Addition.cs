using Microsoft.EntityFrameworkCore.Migrations;

namespace mvc_app.Migrations
{
    public partial class Shop101Addition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_data101_Shops_ShopId",
                table: "data101");

            migrationBuilder.DropForeignKey(
                name: "FK_data201_Shops_ShopId",
                table: "data201");

            migrationBuilder.DropForeignKey(
                name: "FK_data401_Shops_ShopId",
                table: "data401");

            migrationBuilder.AlterColumn<int>(
                name: "ShopId",
                table: "data401",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ShopId",
                table: "data201",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ShopId",
                table: "data101",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<decimal>(
                name: "Agidol",
                table: "data101",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "BenzinHard",
                table: "data101",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Ethylene",
                table: "data101",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "FractionC4",
                table: "data101",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "FractionPropan",
                table: "data101",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "FractionPyrolize",
                table: "data101",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Ingibitor",
                table: "data101",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "MVF",
                table: "data101",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Metanol",
                table: "data101",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Natrium",
                table: "data101",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Propylene",
                table: "data101",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Reflux",
                table: "data101",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "SPT",
                table: "data101",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Waste",
                table: "data101",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddForeignKey(
                name: "FK_data101_Shops_ShopId",
                table: "data101",
                column: "ShopId",
                principalTable: "Shops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_data201_Shops_ShopId",
                table: "data201",
                column: "ShopId",
                principalTable: "Shops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_data401_Shops_ShopId",
                table: "data401",
                column: "ShopId",
                principalTable: "Shops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_data101_Shops_ShopId",
                table: "data101");

            migrationBuilder.DropForeignKey(
                name: "FK_data201_Shops_ShopId",
                table: "data201");

            migrationBuilder.DropForeignKey(
                name: "FK_data401_Shops_ShopId",
                table: "data401");

            migrationBuilder.DropColumn(
                name: "Agidol",
                table: "data101");

            migrationBuilder.DropColumn(
                name: "BenzinHard",
                table: "data101");

            migrationBuilder.DropColumn(
                name: "Ethylene",
                table: "data101");

            migrationBuilder.DropColumn(
                name: "FractionC4",
                table: "data101");

            migrationBuilder.DropColumn(
                name: "FractionPropan",
                table: "data101");

            migrationBuilder.DropColumn(
                name: "FractionPyrolize",
                table: "data101");

            migrationBuilder.DropColumn(
                name: "Ingibitor",
                table: "data101");

            migrationBuilder.DropColumn(
                name: "MVF",
                table: "data101");

            migrationBuilder.DropColumn(
                name: "Metanol",
                table: "data101");

            migrationBuilder.DropColumn(
                name: "Natrium",
                table: "data101");

            migrationBuilder.DropColumn(
                name: "Propylene",
                table: "data101");

            migrationBuilder.DropColumn(
                name: "Reflux",
                table: "data101");

            migrationBuilder.DropColumn(
                name: "SPT",
                table: "data101");

            migrationBuilder.DropColumn(
                name: "Waste",
                table: "data101");

            migrationBuilder.AlterColumn<int>(
                name: "ShopId",
                table: "data401",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ShopId",
                table: "data201",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ShopId",
                table: "data101",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_data101_Shops_ShopId",
                table: "data101",
                column: "ShopId",
                principalTable: "Shops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_data201_Shops_ShopId",
                table: "data201",
                column: "ShopId",
                principalTable: "Shops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_data401_Shops_ShopId",
                table: "data401",
                column: "ShopId",
                principalTable: "Shops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
