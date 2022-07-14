﻿// <auto-generated />
using HotelPortfolio.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HotelPortfolio.Migrations
{
    [DbContext(typeof(HotelDBContext))]
    [Migration("20220714155343_Second Commit")]
    partial class SecondCommit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("HotelPortfolio.Models.HotelModel", b =>
                {
                    b.Property<int>("hotelID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("hotelBranch")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("hotelCategory")
                        .IsRequired()
                        .HasColumnType("varchar(25)");

                    b.Property<string>("hotelName")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<int>("hotelRating")
                        .HasColumnType("int");

                    b.HasKey("hotelID");

                    b.ToTable("Hotel");
                });
#pragma warning restore 612, 618
        }
    }
}
