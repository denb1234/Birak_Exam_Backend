﻿// <auto-generated />
using System;
using Birak_Exam_Backend.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Birak_Exam_Backend.Migrations
{
    [DbContext(typeof(ShopDbContext))]
    [Migration("20221216101913_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Birak_Exam_Backend.Models.Clothes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Discount")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<double>("Size")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("ClothesItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "gergerm",
                            Date = new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Discount = 15,
                            Model = "fewfwe",
                            Name = "wegwegweg",
                            Price = 450.5,
                            Quantity = 5,
                            Size = 37.5
                        },
                        new
                        {
                            Id = 2,
                            Brand = "rthrt",
                            Date = new DateTime(2022, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Discount = 20,
                            Model = "h65h65",
                            Name = "gerg",
                            Price = 750.5,
                            Quantity = 7,
                            Size = 40.5
                        });
                });
#pragma warning restore 612, 618
        }
    }
}