using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace mvc_app.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shops",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shops", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shops_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "data101",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShopId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BenzinLight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BenzinHard = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Reflux = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Butan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Kerosin = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Natrium = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Metanol = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Agidol = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Ingibitor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Ethylene = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Propylene = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FractionC4 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FractionPropan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FractionPyrolize = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SPT = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MVF = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Waste = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_data101", x => x.Id);
                    table.ForeignKey(
                        name: "FK_data101_Shops_ShopId",
                        column: x => x.ShopId,
                        principalTable: "Shops",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "data102",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShopId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ethylene1 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    InitDTBP = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    InitBU50AL = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    InitTBPEH = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    InitOil = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Trigonox = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PolyethyleneS1 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PolyethyleneNM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PolyWasteA3 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PolyWasteA2 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PolyWasteB = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PolyWasteA4 = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_data102", x => x.Id);
                    table.ForeignKey(
                        name: "FK_data102_Shops_ShopId",
                        column: x => x.ShopId,
                        principalTable: "Shops",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "data104",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShopId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BenzinLight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BenzinHard = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Reflux = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Butan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Kerosin = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Natrium = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Metanol = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Agidol = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Ingibitor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DimetilSulfid = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Ethylene = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Propylene = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FractionC4 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FractionPropan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FractionPyrolize = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SPT = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MVF = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Waste = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_data104", x => x.Id);
                    table.ForeignKey(
                        name: "FK_data104_Shops_ShopId",
                        column: x => x.ShopId,
                        principalTable: "Shops",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "data105",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShopId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ethylene1 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Ethylene2 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    InitDTBP = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    InitTBPEH = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    InitOil = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Oxygen = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Propan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PolyethyleneS2 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PolyethyleneNM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PolyWasteA2 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PolyWasteB = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PolyWasteA4 = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_data105", x => x.Id);
                    table.ForeignKey(
                        name: "FK_data105_Shops_ShopId",
                        column: x => x.ShopId,
                        principalTable: "Shops",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "data106_1",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShopId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PolyethyleneS1 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BagPolyprop = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Polyethylene1 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PolyWasteA2 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PolyWasteB = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PolyWasteA4 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PolyWasteD = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PlenkaWaste = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PlenkaWasteE2 = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_data106_1", x => x.Id);
                    table.ForeignKey(
                        name: "FK_data106_1_Shops_ShopId",
                        column: x => x.ShopId,
                        principalTable: "Shops",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "data106_2",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShopId = table.Column<int>(type: "int", nullable: true),
                    PolyethyleneS2 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Polyethylene2 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PolyWasteA2 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PolyWasteB = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PolyWasteA4 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PolyWasteD = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PlenkaWaste = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PlenkaWasteE2 = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_data106_2", x => x.Id);
                    table.ForeignKey(
                        name: "FK_data106_2_Shops_ShopId",
                        column: x => x.ShopId,
                        principalTable: "Shops",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "data201",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShopId = table.Column<int>(type: "int", nullable: true),
                    Propilen = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Angidrid = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Hydroxinon = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Laprol = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Natrium = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AceticAcid = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Triphosphat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Hydrozin = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SulfAcid = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PMF = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Ammiak = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Aceton = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NitricAcid = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NatriumEdk = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    WoodCoal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Amonii = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Aerosil = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NitroKalium = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NitroNatrium = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LiquidAmmiak = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Vismuth = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IronPowder = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrtophoAcid = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_data201", x => x.Id);
                    table.ForeignKey(
                        name: "FK_data201_Shops_ShopId",
                        column: x => x.ShopId,
                        principalTable: "Shops",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "data204",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShopId = table.Column<int>(type: "int", nullable: true),
                    NAK = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BagPolyprop = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LabelsPolyprop = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ContainerMKR = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CausticSoda = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Hydroxinon = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Laprol = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Natrium = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Metanol = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SulphAcid = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PMF = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Calcium = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LiquidAmmiak = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MA = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SulphAmonium = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_data204", x => x.Id);
                    table.ForeignKey(
                        name: "FK_data204_Shops_ShopId",
                        column: x => x.ShopId,
                        principalTable: "Shops",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "data401",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShopId = table.Column<int>(type: "int", nullable: true),
                    NAK = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MA = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Filterpanel = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Biaz = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Natrii = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SulphAcid = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Prophor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Dimethil = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AppleAcid = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AMPS = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SodaCalc = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NitronD = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_data401", x => x.Id);
                    table.ForeignKey(
                        name: "FK_data401_Shops_ShopId",
                        column: x => x.ShopId,
                        principalTable: "Shops",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "data402",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShopId = table.Column<int>(type: "int", nullable: true),
                    NitronD = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SorbitanC = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SorbitalC20 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NitroAcid = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PMS300 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Synthezin = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Titan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PAND = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VoloknoD = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VoloknoTexJ = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_data402", x => x.Id);
                    table.ForeignKey(
                        name: "FK_data402_Shops_ShopId",
                        column: x => x.ShopId,
                        principalTable: "Shops",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleId = table.Column<int>(type: "int", nullable: true),
                    ShopId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_Shops_ShopId",
                        column: x => x.ShopId,
                        principalTable: "Shops",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "первый" },
                    { 2, "второй" },
                    { 3, "третий" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "admin" },
                    { 2, "user" }
                });

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "Id", "DepartmentId", "Number" },
                values: new object[,]
                {
                    { 1, 1, "101" },
                    { 2, 1, "102" },
                    { 3, 1, "104" },
                    { 4, 1, "105" },
                    { 5, 1, "106-1" },
                    { 6, 1, "106-2" },
                    { 7, 2, "201" },
                    { 8, 2, "204" },
                    { 9, 3, "401" },
                    { 10, 3, "402" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Number", "Password", "RoleId", "ShopId" },
                values: new object[,]
                {
                    { 1, "u55220", "123456", 1, 1 },
                    { 2, "u11111", "111", 2, 1 },
                    { 3, "u22222", "222", 2, 7 },
                    { 4, "u33333", "333", 2, 9 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_data101_ShopId",
                table: "data101",
                column: "ShopId");

            migrationBuilder.CreateIndex(
                name: "IX_data102_ShopId",
                table: "data102",
                column: "ShopId");

            migrationBuilder.CreateIndex(
                name: "IX_data104_ShopId",
                table: "data104",
                column: "ShopId");

            migrationBuilder.CreateIndex(
                name: "IX_data105_ShopId",
                table: "data105",
                column: "ShopId");

            migrationBuilder.CreateIndex(
                name: "IX_data106_1_ShopId",
                table: "data106_1",
                column: "ShopId");

            migrationBuilder.CreateIndex(
                name: "IX_data106_2_ShopId",
                table: "data106_2",
                column: "ShopId");

            migrationBuilder.CreateIndex(
                name: "IX_data201_ShopId",
                table: "data201",
                column: "ShopId");

            migrationBuilder.CreateIndex(
                name: "IX_data204_ShopId",
                table: "data204",
                column: "ShopId");

            migrationBuilder.CreateIndex(
                name: "IX_data401_ShopId",
                table: "data401",
                column: "ShopId");

            migrationBuilder.CreateIndex(
                name: "IX_data402_ShopId",
                table: "data402",
                column: "ShopId");

            migrationBuilder.CreateIndex(
                name: "IX_Shops_DepartmentId",
                table: "Shops",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ShopId",
                table: "Users",
                column: "ShopId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "data101");

            migrationBuilder.DropTable(
                name: "data102");

            migrationBuilder.DropTable(
                name: "data104");

            migrationBuilder.DropTable(
                name: "data105");

            migrationBuilder.DropTable(
                name: "data106_1");

            migrationBuilder.DropTable(
                name: "data106_2");

            migrationBuilder.DropTable(
                name: "data201");

            migrationBuilder.DropTable(
                name: "data204");

            migrationBuilder.DropTable(
                name: "data401");

            migrationBuilder.DropTable(
                name: "data402");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Shops");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
