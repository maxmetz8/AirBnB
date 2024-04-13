﻿// <auto-generated />
using System;
using AirB_B.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AirB_B.Migrations
{
    [DbContext(typeof(AirB_BContext))]
    [Migration("20240412151814_testdata")]
    partial class testdata
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AirB_B.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("AirB_B.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsCover")
                        .HasColumnType("bit");

                    b.Property<int?>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.ToTable("Image");
                });

            modelBuilder.Entity("AirB_B.Models.Landlord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int?>("AvatarId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AvatarId")
                        .IsUnique()
                        .HasFilter("[AvatarId] IS NOT NULL");

                    b.ToTable("Landlords");
                });

            modelBuilder.Entity("AirB_B.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Features")
                        .HasColumnType("int");

                    b.Property<int?>("LandlordId")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfGuests")
                        .HasColumnType("int");

                    b.Property<float>("PricePerDay")
                        .HasColumnType("real");

                    b.Property<int>("Rooms")
                        .HasColumnType("int");

                    b.Property<string>("SubTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LandlordId");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("AirB_B.Models.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<float>("Discount")
                        .HasColumnType("real");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LocationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("LocationId");

                    b.ToTable("Reservation");
                });

            modelBuilder.Entity("AirB_B.Models.Image", b =>
                {
                    b.HasOne("AirB_B.Models.Location", "Location")
                        .WithMany("Images")
                        .HasForeignKey("LocationId");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("AirB_B.Models.Landlord", b =>
                {
                    b.HasOne("AirB_B.Models.Image", "Avatar")
                        .WithOne("Landlord")
                        .HasForeignKey("AirB_B.Models.Landlord", "AvatarId");

                    b.Navigation("Avatar");
                });

            modelBuilder.Entity("AirB_B.Models.Location", b =>
                {
                    b.HasOne("AirB_B.Models.Landlord", "Landlord")
                        .WithMany("Locations")
                        .HasForeignKey("LandlordId");

                    b.Navigation("Landlord");
                });

            modelBuilder.Entity("AirB_B.Models.Reservation", b =>
                {
                    b.HasOne("AirB_B.Models.Customer", "Customer")
                        .WithMany("Reservations")
                        .HasForeignKey("CustomerId");

                    b.HasOne("AirB_B.Models.Location", "Location")
                        .WithMany("Reservations")
                        .HasForeignKey("LocationId");

                    b.Navigation("Customer");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("AirB_B.Models.Customer", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("AirB_B.Models.Image", b =>
                {
                    b.Navigation("Landlord");
                });

            modelBuilder.Entity("AirB_B.Models.Landlord", b =>
                {
                    b.Navigation("Locations");
                });

            modelBuilder.Entity("AirB_B.Models.Location", b =>
                {
                    b.Navigation("Images");

                    b.Navigation("Reservations");
                });
#pragma warning restore 612, 618
        }
    }
}
