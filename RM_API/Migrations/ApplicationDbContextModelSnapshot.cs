﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RM_API.Data;

namespace RM_API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("RM_API.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Deleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("ParentId")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("RM_API.Models.Guest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Deleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Phone")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Guest");
                });

            modelBuilder.Entity("RM_API.Models.GuestTable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Deleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<int?>("GuestId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int?>("StatusId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("GuestId");

                    b.HasIndex("StatusId");

                    b.ToTable("GuestTable");
                });

            modelBuilder.Entity("RM_API.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Deleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int?>("UnitId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UnitId");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("RM_API.Models.ItemImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Data")
                        .HasColumnType("longtext");

                    b.Property<bool>("Deleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<int?>("ItemId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.ToTable("ItemImage");
                });

            modelBuilder.Entity("RM_API.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Deleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("OrderNumber")
                        .HasColumnType("longtext");

                    b.Property<double>("PaidAmount")
                        .HasColumnType("double");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("double");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Voided")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("RM_API.Models.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Deleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<int?>("ItemId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<double>("SalePrice")
                        .HasColumnType("double");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Voided")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItem");
                });

            modelBuilder.Entity("RM_API.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Deleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("RM_API.Models.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Deleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Status");
                });

            modelBuilder.Entity("RM_API.Models.Unit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Deleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int?>("UnitTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("UnitTypeId");

                    b.ToTable("Unit");
                });

            modelBuilder.Entity("RM_API.Models.UnitType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Deleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("UnitType");
                });

            modelBuilder.Entity("RM_API.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasColumnType("longtext");

                    b.Property<string>("UserName")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("RM_API.Models.GuestTable", b =>
                {
                    b.HasOne("RM_API.Models.Guest", "Guest")
                        .WithMany()
                        .HasForeignKey("GuestId");

                    b.HasOne("RM_API.Models.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId");

                    b.Navigation("Guest");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("RM_API.Models.Item", b =>
                {
                    b.HasOne("RM_API.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.HasOne("RM_API.Models.Unit", "Unit")
                        .WithMany()
                        .HasForeignKey("UnitId");

                    b.Navigation("Category");

                    b.Navigation("Unit");
                });

            modelBuilder.Entity("RM_API.Models.ItemImage", b =>
                {
                    b.HasOne("RM_API.Models.Item", null)
                        .WithMany("ItemImage")
                        .HasForeignKey("ItemId");
                });

            modelBuilder.Entity("RM_API.Models.OrderItem", b =>
                {
                    b.HasOne("RM_API.Models.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId");

                    b.HasOne("RM_API.Models.Order", null)
                        .WithMany("OrderItem")
                        .HasForeignKey("OrderId");

                    b.Navigation("Item");
                });

            modelBuilder.Entity("RM_API.Models.Unit", b =>
                {
                    b.HasOne("RM_API.Models.UnitType", "UnitType")
                        .WithMany()
                        .HasForeignKey("UnitTypeId");

                    b.Navigation("UnitType");
                });

            modelBuilder.Entity("RM_API.Models.Item", b =>
                {
                    b.Navigation("ItemImage");
                });

            modelBuilder.Entity("RM_API.Models.Order", b =>
                {
                    b.Navigation("OrderItem");
                });
#pragma warning restore 612, 618
        }
    }
}
