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
    [Migration("20240417135214_changed_reservations")]
    partial class changed_reservations
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "maxmetz@gmail.com",
                            FirstName = "Max",
                            LastName = "Metz"
                        },
                        new
                        {
                            Id = 2,
                            Email = "lisawerner@gmail.com",
                            FirstName = "Lisa",
                            LastName = "Werner"
                        },
                        new
                        {
                            Id = 3,
                            Email = "NdeJong@gmail.com",
                            FirstName = "Nora",
                            LastName = "De Jong"
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsCover = false,
                            Url = "https://images.pexels.com/photos/1681010/pexels-photo-1681010.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2"
                        },
                        new
                        {
                            Id = 2,
                            IsCover = false,
                            Url = "https://images.pexels.com/photos/733872/pexels-photo-733872.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2"
                        },
                        new
                        {
                            Id = 3,
                            IsCover = false,
                            Url = "https://images.pexels.com/photos/91227/pexels-photo-91227.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2"
                        },
                        new
                        {
                            Id = 4,
                            IsCover = false,
                            Url = "https://images.pexels.com/photos/874158/pexels-photo-874158.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2"
                        },
                        new
                        {
                            Id = 5,
                            IsCover = false,
                            Url = "https://images.pexels.com/photos/1212984/pexels-photo-1212984.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2"
                        },
                        new
                        {
                            Id = 6,
                            IsCover = true,
                            LocationId = 1,
                            Url = "https://images.pexels.com/photos/2462015/pexels-photo-2462015.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2"
                        },
                        new
                        {
                            Id = 7,
                            IsCover = true,
                            LocationId = 2,
                            Url = "https://images.pexels.com/photos/259588/pexels-photo-259588.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2"
                        },
                        new
                        {
                            Id = 8,
                            IsCover = true,
                            LocationId = 3,
                            Url = "https://images.pexels.com/photos/1438832/pexels-photo-1438832.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2"
                        },
                        new
                        {
                            Id = 9,
                            IsCover = true,
                            LocationId = 4,
                            Url = "https://images.pexels.com/photos/2681205/pexels-photo-2681205.jpeg"
                        },
                        new
                        {
                            Id = 10,
                            IsCover = true,
                            LocationId = 5,
                            Url = "https://images.pexels.com/photos/5563472/pexels-photo-5563472.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2"
                        },
                        new
                        {
                            Id = 11,
                            IsCover = true,
                            LocationId = 6,
                            Url = "https://cdn.cbs.nl/images/6c544435792f56565844344b67534e686f3964532b413d3d/900x450.jpg"
                        },
                        new
                        {
                            Id = 12,
                            IsCover = true,
                            LocationId = 7,
                            Url = "https://images.pexels.com/photos/1131573/pexels-photo-1131573.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2"
                        },
                        new
                        {
                            Id = 13,
                            IsCover = true,
                            LocationId = 8,
                            Url = "https://images.pexels.com/photos/18705895/pexels-photo-18705895/free-photo-of-exterior-of-a-castle.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2"
                        },
                        new
                        {
                            Id = 14,
                            IsCover = true,
                            LocationId = 9,
                            Url = "https://images.pexels.com/photos/1329510/pexels-photo-1329510.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2"
                        },
                        new
                        {
                            Id = 15,
                            IsCover = true,
                            LocationId = 10,
                            Url = "https://images.pexels.com/photos/161123/windmill-water-church-agriculture-161123.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2"
                        },
                        new
                        {
                            Id = 16,
                            IsCover = false,
                            LocationId = 1,
                            Url = "https://images.pexels.com/photos/1643384/pexels-photo-1643384.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2"
                        },
                        new
                        {
                            Id = 17,
                            IsCover = false,
                            LocationId = 1,
                            Url = "https://images.pexels.com/photos/1428348/pexels-photo-1428348.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2"
                        },
                        new
                        {
                            Id = 18,
                            IsCover = false,
                            LocationId = 5,
                            Url = "https://images.pexels.com/photos/870170/pexels-photo-870170.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2"
                        },
                        new
                        {
                            Id = 19,
                            IsCover = false,
                            LocationId = 5,
                            Url = "https://images.pexels.com/photos/984619/pexels-photo-984619.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2"
                        },
                        new
                        {
                            Id = 20,
                            IsCover = false,
                            LocationId = 9,
                            Url = "https://images.pexels.com/photos/4237154/pexels-photo-4237154.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2"
                        },
                        new
                        {
                            Id = 21,
                            IsCover = false,
                            LocationId = 6,
                            Url = "https://images.pexels.com/photos/2098913/pexels-photo-2098913.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2"
                        },
                        new
                        {
                            Id = 22,
                            IsCover = false,
                            LocationId = 8,
                            Url = "https://images.pexels.com/photos/2954929/pexels-photo-2954929.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2"
                        },
                        new
                        {
                            Id = 23,
                            IsCover = false,
                            LocationId = 10,
                            Url = "https://images.pexels.com/photos/2449549/pexels-photo-2449549.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2"
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 40,
                            AvatarId = 1,
                            FirstName = "John ",
                            LastName = "Doe"
                        },
                        new
                        {
                            Id = 2,
                            Age = 30,
                            AvatarId = 2,
                            FirstName = "Mary ",
                            LastName = "Bane"
                        },
                        new
                        {
                            Id = 3,
                            Age = 34,
                            AvatarId = 3,
                            FirstName = "Bruce ",
                            LastName = "Spanner"
                        },
                        new
                        {
                            Id = 4,
                            Age = 45,
                            AvatarId = 4,
                            FirstName = "Tony ",
                            LastName = "Spark"
                        },
                        new
                        {
                            Id = 5,
                            Age = 25,
                            AvatarId = 5,
                            FirstName = "Harry ",
                            LastName = "de Spotter"
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Nieuw hotel in de stad",
                            Features = 36,
                            LandlordId = 1,
                            NumberOfGuests = 4,
                            PricePerDay = 74.99f,
                            Rooms = 2,
                            SubTitle = "met 1 stap in het oude centrum van de stad",
                            Title = "Nieuwbouw Hotel",
                            Type = 4
                        },
                        new
                        {
                            Id = 2,
                            Description = "Vrijstaand huis met een rustige buurt en veel natuur in de omgeving",
                            Features = 6,
                            LandlordId = 1,
                            NumberOfGuests = 6,
                            PricePerDay = 50f,
                            Rooms = 3,
                            SubTitle = "geniet van de prachtige groene natuur in deze rustige omgeving",
                            Title = "Vrijstaand Huis",
                            Type = 5
                        },
                        new
                        {
                            Id = 3,
                            Description = "Groot oud huis met prachtige ligging aan het meer",
                            Features = 3,
                            LandlordId = 2,
                            NumberOfGuests = 8,
                            PricePerDay = 88.5f,
                            Rooms = 4,
                            SubTitle = "Een prachtig huis uit de 19de eeuw aan het water",
                            Title = "Villa aan het water",
                            Type = 5
                        },
                        new
                        {
                            Id = 4,
                            Description = "kamer in apartementencomplex",
                            Features = 8,
                            LandlordId = 3,
                            NumberOfGuests = 2,
                            PricePerDay = 58.33f,
                            Rooms = 1,
                            SubTitle = "2 persoons kamer in Barcelona",
                            Title = "2 persoons kamer ",
                            Type = 3
                        },
                        new
                        {
                            Id = 5,
                            Description = "luxeuze villa met zwembad en grote tuin",
                            Features = 28,
                            LandlordId = 4,
                            NumberOfGuests = 15,
                            PricePerDay = 399.5f,
                            Rooms = 10,
                            SubTitle = "grote villa voor een prachtige vakantie met vrienden of familie",
                            Title = "Super villa Milaan",
                            Type = 5
                        },
                        new
                        {
                            Id = 6,
                            Description = "Eengezinswoning voor starter in Almere",
                            Features = 2,
                            LandlordId = 5,
                            NumberOfGuests = 4,
                            PricePerDay = 25f,
                            Rooms = 3,
                            SubTitle = "Een goede starters woning met goed woon/werkverkeer",
                            Title = "Rijtjeshuis in Almere",
                            Type = 5
                        },
                        new
                        {
                            Id = 7,
                            Description = "Villa met uitzicht over de kust in Kijkduin",
                            Features = 8,
                            LandlordId = 1,
                            NumberOfGuests = 8,
                            PricePerDay = 66.65f,
                            Rooms = 4,
                            SubTitle = "Perfect voor de zomervakantie in Nederland ",
                            Title = "Villa aan het strand",
                            Type = 2
                        },
                        new
                        {
                            Id = 8,
                            Description = "Historisch kasteel in de binnenlanden van Frankrijk",
                            Features = 18,
                            LandlordId = 5,
                            NumberOfGuests = 12,
                            PricePerDay = 420.1f,
                            Rooms = 8,
                            SubTitle = "Verblijf hier als een koninklijke familie",
                            Title = "Kasteel in Frankrijk",
                            Type = 5
                        },
                        new
                        {
                            Id = 9,
                            Description = "Prijzige kamer in mooiste stad van Nederland",
                            Features = 4,
                            LandlordId = 1,
                            NumberOfGuests = 5,
                            PricePerDay = 500f,
                            Rooms = 2,
                            SubTitle = "Verken Amsterdam en geniet van de mogelijkheden in de stad",
                            Title = "Appartement Amsterdam",
                            Type = 0
                        },
                        new
                        {
                            Id = 10,
                            Description = "Oude gerestaureerde molen met 4 kamers",
                            Features = 12,
                            LandlordId = 2,
                            NumberOfGuests = 8,
                            PricePerDay = 140f,
                            Rooms = 4,
                            SubTitle = "Authentieke Molen gebruikt voor het maken van kaas",
                            Title = "Oude Molen",
                            Type = 1
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CustomerId = 1,
                            Discount = 0f,
                            EndDate = new DateTime(2025, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LocationId = 3,
                            StartDate = new DateTime(2025, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CustomerId = 2,
                            Discount = 0f,
                            EndDate = new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LocationId = 6,
                            StartDate = new DateTime(2025, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            CustomerId = 3,
                            Discount = 0f,
                            EndDate = new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LocationId = 4,
                            StartDate = new DateTime(2025, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
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
