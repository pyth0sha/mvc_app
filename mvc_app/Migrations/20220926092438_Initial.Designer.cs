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
    [Migration("20220926092438_Initial")]
    partial class Initial
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

                    b.Property<decimal>("BenzinLight")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Butan")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Kerosin")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ShopId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ShopId");

                    b.ToTable("data101");
                });

            modelBuilder.Entity("mvc_app.Models.Data201", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Angidrid")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Laprol")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Propilen")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ShopId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ShopId");

                    b.ToTable("data201");
                });

            modelBuilder.Entity("mvc_app.Models.Data401", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("MA")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("NAK")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Natrii")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ShopId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ShopId");

                    b.ToTable("data401");
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
                        .HasForeignKey("ShopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Shop");
                });

            modelBuilder.Entity("mvc_app.Models.Data201", b =>
                {
                    b.HasOne("mvc_app.Models.Shop", "Shop")
                        .WithMany()
                        .HasForeignKey("ShopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Shop");
                });

            modelBuilder.Entity("mvc_app.Models.Data401", b =>
                {
                    b.HasOne("mvc_app.Models.Shop", "Shop")
                        .WithMany()
                        .HasForeignKey("ShopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

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