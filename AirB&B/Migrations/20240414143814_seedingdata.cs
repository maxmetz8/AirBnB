﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AirB_B.Migrations
{
    /// <inheritdoc />
    public partial class seedingdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "maxmetz@gmail.com", "Max", "Metz" },
                    { 2, "lisawerner@gmail.com", "Lisa", "Werner" }
                });

            migrationBuilder.InsertData(
                table: "Image",
                columns: new[] { "Id", "IsCover", "LocationId", "Url" },
                values: new object[,]
                {
                    { 1, false, null, "https://images.pexels.com/photos/1681010/pexels-photo-1681010.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2" },
                    { 2, false, null, "https://images.pexels.com/photos/733872/pexels-photo-733872.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2" },
                    { 3, false, null, "https://images.pexels.com/photos/91227/pexels-photo-91227.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2" },
                    { 4, false, null, "https://images.pexels.com/photos/874158/pexels-photo-874158.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2" },
                    { 5, false, null, "https://images.pexels.com/photos/1212984/pexels-photo-1212984.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2" }
                });

            migrationBuilder.InsertData(
                table: "Landlords",
                columns: new[] { "Id", "Age", "AvatarId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, 40, 1, "John ", "Doe" },
                    { 2, 30, 2, "Mary ", "Bane" },
                    { 3, 34, 3, "Bruce ", "Spanner" },
                    { 4, 45, 4, "Tony ", "Spark" },
                    { 5, 25, 5, "Harry ", "de Spotter" }
                });

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "Id", "Description", "Features", "LandlordId", "NumberOfGuests", "PricePerDay", "Rooms", "SubTitle", "Title", "Type" },
                values: new object[,]
                {
                    { 1, "Nieuw hotel in de stad", 36, 1, 4, 74.99f, 2, "met 1 stap in het oude centrum van de stad", "Nieuwbouw Hotel", 4 },
                    { 2, "Vrijstaand huis met een rustige buurt en veel natuur in de omgeving", 6, 1, 6, 50f, 3, "geniet van de prachtige groene natuur in deze rustige omgeving", "Vrijstaand Huis", 5 },
                    { 3, "Groot oud huis met prachtige ligging aan het meer", 3, 2, 8, 88.5f, 4, "Een prachtig huis uit de 19de eeuw aan het water", "Villa aan het water", 5 },
                    { 4, "kamer in apartementencomplex", 8, 3, 2, 58.33f, 1, "2 persoons kamer in Barcelona", "2 persoons kamer ", 3 },
                    { 5, "luxeuze villa met zwembad en grote tuin", 28, 4, 15, 399.5f, 10, "grote villa voor een prachtige vakantie met vrienden of familie", "Super villa Milaan", 5 },
                    { 6, "Eengezinswoning voor starter in Almere", 2, 5, 4, 25f, 3, "Een goede starters woning met goed woon/werkverkeer", "Rijtjeshuis in Almere", 5 },
                    { 7, "Villa met uitzicht over de kust in Kijkduin", 8, 1, 8, 66.65f, 4, "Perfect voor de zomervakantie in Nederland ", "Villa aan het strand", 2 },
                    { 8, "Historisch kasteel in de binnenlanden van Frankrijk", 18, 5, 12, 420.1f, 8, "Verblijf hier als een koninklijke familie", "Kasteel in Frankrijk", 5 },
                    { 9, "Prijzige kamer in mooiste stad van Nederland", 4, 1, 5, 500f, 2, "Verken Amsterdam en geniet van de mogelijkheden in de stad", "Appartement Amsterdam", 0 },
                    { 10, "Oude gerestaureerde molen met 4 kamers", 12, 2, 8, 140f, 4, "Authentieke Molen gebruikt voor het maken van kaas", "Oude Molen", 1 }
                });

            migrationBuilder.InsertData(
                table: "Image",
                columns: new[] { "Id", "IsCover", "LocationId", "Url" },
                values: new object[,]
                {
                    { 6, true, 1, "https://images.pexels.com/photos/2462015/pexels-photo-2462015.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2" },
                    { 7, true, 2, "https://images.pexels.com/photos/259588/pexels-photo-259588.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2" },
                    { 8, true, 3, "https://images.pexels.com/photos/1438832/pexels-photo-1438832.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2" },
                    { 9, true, 4, "https://images.pexels.com/photos/2681205/pexels-photo-2681205.jpeg" },
                    { 10, true, 5, "https://images.pexels.com/photos/5563472/pexels-photo-5563472.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2" },
                    { 11, true, 6, "https://cdn.cbs.nl/images/6c544435792f56565844344b67534e686f3964532b413d3d/900x450.jpg" },
                    { 12, true, 7, "https://images.pexels.com/photos/1131573/pexels-photo-1131573.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2" },
                    { 13, true, 8, "https://images.pexels.com/photos/18705895/pexels-photo-18705895/free-photo-of-exterior-of-a-castle.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2" },
                    { 14, true, 9, "https://images.pexels.com/photos/1329510/pexels-photo-1329510.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2" },
                    { 15, true, 10, "https://images.pexels.com/photos/161123/windmill-water-church-agriculture-161123.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2" },
                    { 16, false, 1, "https://images.pexels.com/photos/1643384/pexels-photo-1643384.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2" },
                    { 17, false, 1, "https://images.pexels.com/photos/1428348/pexels-photo-1428348.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2" },
                    { 18, false, 5, "https://images.pexels.com/photos/870170/pexels-photo-870170.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2" },
                    { 19, false, 5, "https://images.pexels.com/photos/984619/pexels-photo-984619.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2" },
                    { 20, false, 9, "https://images.pexels.com/photos/4237154/pexels-photo-4237154.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2" },
                    { 21, false, 6, "https://images.pexels.com/photos/2098913/pexels-photo-2098913.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2" },
                    { 22, false, 8, "https://images.pexels.com/photos/2954929/pexels-photo-2954929.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2" },
                    { 23, false, 10, "https://images.pexels.com/photos/2449549/pexels-photo-2449549.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2" }
                });

            migrationBuilder.InsertData(
                table: "Reservation",
                columns: new[] { "Id", "CustomerId", "Discount", "EndDate", "LocationId", "StartDate" },
                values: new object[,]
                {
                    { 1, 1, 0f, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, 0f, new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2023, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Landlords",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Landlords",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Landlords",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Landlords",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Landlords",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
