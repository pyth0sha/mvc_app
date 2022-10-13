﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using mvc_app.Models;

namespace mvc_app.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20221013060436_NewFields")]
    partial class NewFields
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("mvc_app.Models.Data101", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Agidol")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("BenzinHard")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("BenzinLight")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Butan")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Ethylene")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("FractionC4")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("FractionPropan")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("FractionPyrolize")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Ingibitor")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Kerosin")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("MVF")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Metanol")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Natrium")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Propylene")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Reflux")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SPT")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("ShopId")
                        .HasColumnType("int");

                    b.Property<decimal>("UVS")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Waste")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("ShopId");

                    b.ToTable("data101");
                });

            modelBuilder.Entity("mvc_app.Models.Data102", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Ethylene1")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("InitBU50AL")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("InitDTBP")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("InitOil")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("InitTBPEH")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PolyWasteA2")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PolyWasteA3")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PolyWasteA4")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PolyWasteB")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PolyethyleneNM")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PolyethyleneS1")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("ShopId")
                        .HasColumnType("int");

                    b.Property<decimal>("Trigonox")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("ShopId");

                    b.ToTable("data102");
                });

            modelBuilder.Entity("mvc_app.Models.Data104", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Agidol")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("BenzinHard")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("BenzinLight")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Butan")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("DimetilSulfid")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Ethylene")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("FractionC4")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("FractionPropan")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("FractionPyrolize")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Ingibitor")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Kerosin")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("MVF")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Metanol")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Natrium")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Propylene")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Reflux")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SPT")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("ShopId")
                        .HasColumnType("int");

                    b.Property<decimal>("UVS")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Waste")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("ShopId");

                    b.ToTable("data104");
                });

            modelBuilder.Entity("mvc_app.Models.Data105", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Ethylene1")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Ethylene2")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("InitDTBP")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("InitOil")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("InitTBPEH")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Oxygen")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PolyWasteA2")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PolyWasteA4")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PolyWasteB")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PolyethyleneNM")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PolyethyleneS2")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Propan")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("ShopId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ShopId");

                    b.ToTable("data105");
                });

            modelBuilder.Entity("mvc_app.Models.Data106_1", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("BagPoly")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("BagPolyprop")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("BagWastePlenka")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("PlenkaPoly")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PlenkaWaste")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PlenkaWasteE2")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PlenkaWastePlenka")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PolyWasteA2")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PolyWasteA4")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PolyWasteB")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PolyWasteD")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Polyethylene1")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Polyethylene1Bag")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Polyethylene1Plenka")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PolyethyleneS1")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("ShopId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ShopId");

                    b.ToTable("data106_1");
                });

            modelBuilder.Entity("mvc_app.Models.Data106_2", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("PlenkaWaste")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PlenkaWasteE2")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PolyWasteA2")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PolyWasteA4")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PolyWasteB")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PolyWasteD")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Polyethylene2")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PolyethyleneS2")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("ShopId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ShopId");

                    b.ToTable("data106_2");
                });

            modelBuilder.Entity("mvc_app.Models.Data201", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("ACG")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("AceticAcid")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Aceton")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Aerosil")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Ammiak")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Amonii")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Angidrid")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Hydroxinon")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Hydrozin")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("IronPowder")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Katalizator")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Laprol")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("LiquidAmmiak")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("NAK")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("NAKpolufab")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("NAKtovar")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Natrium")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("NatriumEdk")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("NitricAcid")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("NitroKalium")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("NitroNatrium")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("OrtophoAcid")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PMF")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Propilen")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("ShopId")
                        .HasColumnType("int");

                    b.Property<decimal>("SulfAcid")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Triphosphat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Vismuth")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("WoodCoal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("ShopId");

                    b.ToTable("data201");
                });

            modelBuilder.Entity("mvc_app.Models.Data204", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("BagPolyprop")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Calcium")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("CausticSoda")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ContainerMKR")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Hydroxinon")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("LabelsPolyprop")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Laprol")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("LiquidAmmiak")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("MA")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Metanol")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("NAK")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Natrium")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PMF")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("ShopId")
                        .HasColumnType("int");

                    b.Property<decimal>("SulphAcid")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SulphAmonium")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("ShopId");

                    b.ToTable("data204");
                });

            modelBuilder.Entity("mvc_app.Models.Data401", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("AMPS")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("AppleAcid")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Biaz")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Dimethil")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Filterpanel")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("MA")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("NAK")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Natrii")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("NatriiWater")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("NitronD")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Prophor")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("ShopId")
                        .HasColumnType("int");

                    b.Property<decimal>("SodaCalc")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SulphAcid")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SulphAcidWater")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Water")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("ShopId");

                    b.ToTable("data401");
                });

            modelBuilder.Entity("mvc_app.Models.Data402", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("NitroAcid")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("NitronD")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PAND")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PMS300")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PackagingKit")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("ShopId")
                        .HasColumnType("int");

                    b.Property<decimal>("SorbitalC20")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SorbitanC")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Synthezin")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Titan")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("VoloknoD")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("VoloknoTexJ")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("ShopId");

                    b.ToTable("data402");
                });

            modelBuilder.Entity("mvc_app.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "первый"
                        },
                        new
                        {
                            Id = 2,
                            Name = "второй"
                        },
                        new
                        {
                            Id = 3,
                            Name = "третий"
                        });
                });

            modelBuilder.Entity("mvc_app.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "admin"
                        },
                        new
                        {
                            Id = 2,
                            Name = "user"
                        });
                });

            modelBuilder.Entity("mvc_app.Models.Shop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Number")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Shops");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DepartmentId = 1,
                            Number = "101"
                        },
                        new
                        {
                            Id = 2,
                            DepartmentId = 1,
                            Number = "102"
                        },
                        new
                        {
                            Id = 3,
                            DepartmentId = 1,
                            Number = "104"
                        },
                        new
                        {
                            Id = 4,
                            DepartmentId = 1,
                            Number = "105"
                        },
                        new
                        {
                            Id = 5,
                            DepartmentId = 1,
                            Number = "106-1"
                        },
                        new
                        {
                            Id = 6,
                            DepartmentId = 1,
                            Number = "106-2"
                        },
                        new
                        {
                            Id = 7,
                            DepartmentId = 2,
                            Number = "201"
                        },
                        new
                        {
                            Id = 8,
                            DepartmentId = 2,
                            Number = "204"
                        },
                        new
                        {
                            Id = 9,
                            DepartmentId = 3,
                            Number = "401"
                        },
                        new
                        {
                            Id = 10,
                            DepartmentId = 3,
                            Number = "402"
                        });
                });

            modelBuilder.Entity("mvc_app.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RoleId")
                        .HasColumnType("int");

                    b.Property<int?>("ShopId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("ShopId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Number = "u55220",
                            Password = "123456",
                            RoleId = 1,
                            ShopId = 1
                        },
                        new
                        {
                            Id = 2,
                            Number = "u11111",
                            Password = "111",
                            RoleId = 2,
                            ShopId = 1
                        },
                        new
                        {
                            Id = 3,
                            Number = "u22222",
                            Password = "222",
                            RoleId = 2,
                            ShopId = 7
                        },
                        new
                        {
                            Id = 4,
                            Number = "u33333",
                            Password = "333",
                            RoleId = 2,
                            ShopId = 9
                        });
                });

            modelBuilder.Entity("mvc_app.Models.Data101", b =>
                {
                    b.HasOne("mvc_app.Models.Shop", "Shop")
                        .WithMany()
                        .HasForeignKey("ShopId");

                    b.Navigation("Shop");
                });

            modelBuilder.Entity("mvc_app.Models.Data102", b =>
                {
                    b.HasOne("mvc_app.Models.Shop", "Shop")
                        .WithMany()
                        .HasForeignKey("ShopId");

                    b.Navigation("Shop");
                });

            modelBuilder.Entity("mvc_app.Models.Data104", b =>
                {
                    b.HasOne("mvc_app.Models.Shop", "Shop")
                        .WithMany()
                        .HasForeignKey("ShopId");

                    b.Navigation("Shop");
                });

            modelBuilder.Entity("mvc_app.Models.Data105", b =>
                {
                    b.HasOne("mvc_app.Models.Shop", "Shop")
                        .WithMany()
                        .HasForeignKey("ShopId");

                    b.Navigation("Shop");
                });

            modelBuilder.Entity("mvc_app.Models.Data106_1", b =>
                {
                    b.HasOne("mvc_app.Models.Shop", "Shop")
                        .WithMany()
                        .HasForeignKey("ShopId");

                    b.Navigation("Shop");
                });

            modelBuilder.Entity("mvc_app.Models.Data106_2", b =>
                {
                    b.HasOne("mvc_app.Models.Shop", "Shop")
                        .WithMany()
                        .HasForeignKey("ShopId");

                    b.Navigation("Shop");
                });

            modelBuilder.Entity("mvc_app.Models.Data201", b =>
                {
                    b.HasOne("mvc_app.Models.Shop", "Shop")
                        .WithMany()
                        .HasForeignKey("ShopId");

                    b.Navigation("Shop");
                });

            modelBuilder.Entity("mvc_app.Models.Data204", b =>
                {
                    b.HasOne("mvc_app.Models.Shop", "Shop")
                        .WithMany()
                        .HasForeignKey("ShopId");

                    b.Navigation("Shop");
                });

            modelBuilder.Entity("mvc_app.Models.Data401", b =>
                {
                    b.HasOne("mvc_app.Models.Shop", "Shop")
                        .WithMany()
                        .HasForeignKey("ShopId");

                    b.Navigation("Shop");
                });

            modelBuilder.Entity("mvc_app.Models.Data402", b =>
                {
                    b.HasOne("mvc_app.Models.Shop", "Shop")
                        .WithMany()
                        .HasForeignKey("ShopId");

                    b.Navigation("Shop");
                });

            modelBuilder.Entity("mvc_app.Models.Shop", b =>
                {
                    b.HasOne("mvc_app.Models.Department", "Department")
                        .WithMany("Shops")
                        .HasForeignKey("DepartmentId");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("mvc_app.Models.User", b =>
                {
                    b.HasOne("mvc_app.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId");

                    b.HasOne("mvc_app.Models.Shop", "Shop")
                        .WithMany("Users")
                        .HasForeignKey("ShopId");

                    b.Navigation("Role");

                    b.Navigation("Shop");
                });

            modelBuilder.Entity("mvc_app.Models.Department", b =>
                {
                    b.Navigation("Shops");
                });

            modelBuilder.Entity("mvc_app.Models.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("mvc_app.Models.Shop", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
