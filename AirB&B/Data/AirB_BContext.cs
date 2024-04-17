using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AirB_B.Models;

namespace AirB_B.Data
{
    public class AirB_BContext : DbContext
    {
        public AirB_BContext(DbContextOptions<AirB_BContext> options)
            : base(options)
        {
        }


        public DbSet<AirB_B.Models.Landlord> Landlords { get; set; } = default!;
        public DbSet<AirB_B.Models.Location> Location { get; set; } = default!;
        public DbSet<AirB_B.Models.Reservation> Reservation { get; set; }
        public DbSet<AirB_B.Models.Customer> Customer { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Image>().HasOne(i => i.Landlord).WithOne(l => l.Avatar).HasForeignKey<Landlord>(i => i.AvatarId);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>().HasData(
             new { Id = 1, FirstName = "Max", LastName = "Metz", Email = "maxmetz@gmail.com"},
             new { Id = 2, FirstName = "Lisa", LastName = "Werner", Email = "lisawerner@gmail.com"},
             new { Id = 3, FirstName = "Nora", LastName = "De Jong", Email = "NdeJong@gmail.com" }
                );


            modelBuilder.Entity<Landlord>().HasData(
            new { Id = 1, FirstName = "John ", LastName = "Doe", Age = 40,  AvatarId = 1 },
            new { Id = 2, FirstName = "Mary ", LastName = "Bane",  Age = 30, AvatarId = 2 },
            new { Id = 3, FirstName = "Bruce ", LastName = "Spanner", Age = 34,  AvatarId = 3 },
            new { Id = 4, FirstName = "Tony ", LastName = "Spark", Age = 45, AvatarId = 4 },
            new { Id = 5, FirstName = "Harry ", LastName = "de Spotter", Age = 25, AvatarId = 5 }
                );



            modelBuilder.Entity<Location>().HasData(
                new { Id = 1, Rooms = 2, Description = "Nieuw hotel in de stad", Features = AirB_B.Models.Location.LocationFeatures.Breakfast | AirB_B.Models.Location.LocationFeatures.Wifi, SubTitle = "met 1 stap in het oude centrum van de stad", NumberOfGuests = 4, Title = "Nieuwbouw Hotel", Type = AirB_B.Models.Location.LocationType.Hotel, PricePerDay = 74.99F, LandlordId = 1, ImageId = 6 },
                new { Id = 2, Rooms = 3, Description = "Vrijstaand huis met een rustige buurt en veel natuur in de omgeving", Features = AirB_B.Models.Location.LocationFeatures.PetsAllowed | AirB_B.Models.Location.LocationFeatures.Wifi, SubTitle = "geniet van de prachtige groene natuur in deze rustige omgeving", NumberOfGuests = 6, Title = "Vrijstaand Huis", Type = AirB_B.Models.Location.LocationType.House, PricePerDay = 50F, LandlordId = 1, ImageId = 4 },
                new { Id = 3, Rooms = 4, Description = "Groot oud huis met prachtige ligging aan het meer", Features = AirB_B.Models.Location.LocationFeatures.Smoking | AirB_B.Models.Location.LocationFeatures.PetsAllowed, SubTitle = "Een prachtig huis uit de 19de eeuw aan het water", NumberOfGuests = 8, Title = "Villa aan het water", Type = AirB_B.Models.Location.LocationType.House, PricePerDay = 88.5F, LandlordId = 2, ImageId = 5 },
                new { Id = 4, Rooms = 1, Description = "kamer in apartementencomplex", Features = AirB_B.Models.Location.LocationFeatures.TV, SubTitle = "2 persoons kamer in Barcelona", NumberOfGuests = 2, Title = "2 persoons kamer ", Type = AirB_B.Models.Location.LocationType.Room, PricePerDay = 58.33F, LandlordId = 3, ImageId = 6 },
                new { Id = 5, Rooms = 10, Description = "luxeuze villa met zwembad en grote tuin", Features = AirB_B.Models.Location.LocationFeatures.Wifi | AirB_B.Models.Location.LocationFeatures.TV | AirB_B.Models.Location.LocationFeatures.Bath, SubTitle = "grote villa voor een prachtige vakantie met vrienden of familie", NumberOfGuests = 15, Title = "Super villa Milaan", Type = AirB_B.Models.Location.LocationType.House, PricePerDay = 399.5F, LandlordId = 4, ImageId = 7 },
                new { Id = 6, Rooms = 3, Description = "Eengezinswoning voor starter in Almere", Features = AirB_B.Models.Location.LocationFeatures.PetsAllowed, SubTitle = "Een goede starters woning met goed woon/werkverkeer", NumberOfGuests = 4, Title = "Rijtjeshuis in Almere", Type = AirB_B.Models.Location.LocationType.House, PricePerDay = 25F, LandlordId = 5, ImageId = 8 },
                new { Id = 7, Rooms = 4, Description = "Villa met uitzicht over de kust in Kijkduin", Features = AirB_B.Models.Location.LocationFeatures.TV, SubTitle = "Perfect voor de zomervakantie in Nederland ", NumberOfGuests = 8, Title = "Villa aan het strand", Type = AirB_B.Models.Location.LocationType.Chalet, PricePerDay = 66.65F, LandlordId = 1, ImageId = 9 },
                new { Id = 8, Rooms = 8, Description = "Historisch kasteel in de binnenlanden van Frankrijk", Features = AirB_B.Models.Location.LocationFeatures.Bath | AirB_B.Models.Location.LocationFeatures.PetsAllowed, SubTitle = "Verblijf hier als een koninklijke familie", NumberOfGuests = 12, Title = "Kasteel in Frankrijk", Type = AirB_B.Models.Location.LocationType.House, PricePerDay = 420.1F, LandlordId = 5, ImageId = 10 },
                new { Id = 9, Rooms = 2, Description = "Prijzige kamer in mooiste stad van Nederland", Features = AirB_B.Models.Location.LocationFeatures.Wifi, SubTitle = "Verken Amsterdam en geniet van de mogelijkheden in de stad", NumberOfGuests = 5, Title = "Appartement Amsterdam", Type = AirB_B.Models.Location.LocationType.Appartment, PricePerDay = 500F, LandlordId = 1, ImageId = 11 },
                new { Id = 10, Rooms = 4, Description = "Oude gerestaureerde molen met 4 kamers", Features = AirB_B.Models.Location.LocationFeatures.TV | AirB_B.Models.Location.LocationFeatures.Wifi, SubTitle = "Authentieke Molen gebruikt voor het maken van kaas", NumberOfGuests = 8, Title = "Oude Molen", Type = AirB_B.Models.Location.LocationType.Cottage, PricePerDay = 140F, LandlordId = 2, ImageId = 12 }
                );


            modelBuilder.Entity<Image>().HasData(
           new { Id = 1, IsCover = false, Url = "https://images.pexels.com/photos/1681010/pexels-photo-1681010.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2" },
           new { Id = 2, IsCover = false, Url = "https://images.pexels.com/photos/733872/pexels-photo-733872.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2" },
           new { Id = 3, IsCover = false, Url = "https://images.pexels.com/photos/91227/pexels-photo-91227.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2" },
           new { Id = 4, IsCover = false, Url = "https://images.pexels.com/photos/874158/pexels-photo-874158.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2"},
           new { Id = 5, IsCover = false, Url = "https://images.pexels.com/photos/1212984/pexels-photo-1212984.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2" },
           new { Id = 6, IsCover = true, Url = "https://images.pexels.com/photos/2462015/pexels-photo-2462015.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", LocationId = 1},
           new { Id = 7, IsCover = true, Url = "https://images.pexels.com/photos/259588/pexels-photo-259588.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", LocationId = 2},
           new { Id = 8, IsCover = true, Url = "https://images.pexels.com/photos/1438832/pexels-photo-1438832.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", LocationId = 3},
           new { Id = 9, IsCover = true, Url = "https://images.pexels.com/photos/2681205/pexels-photo-2681205.jpeg", LocationId = 4},
           new { Id = 10, IsCover = true, Url = "https://images.pexels.com/photos/5563472/pexels-photo-5563472.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", LocationId = 5},
           new { Id = 11, IsCover = true, Url = "https://cdn.cbs.nl/images/6c544435792f56565844344b67534e686f3964532b413d3d/900x450.jpg", LocationId = 6},
           new { Id = 12, IsCover = true, Url = "https://images.pexels.com/photos/1131573/pexels-photo-1131573.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", LocationId = 7},
           new { Id = 13, IsCover = true, Url = "https://images.pexels.com/photos/18705895/pexels-photo-18705895/free-photo-of-exterior-of-a-castle.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", LocationId = 8},
           new { Id = 14, IsCover = true, Url = "https://images.pexels.com/photos/1329510/pexels-photo-1329510.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", LocationId = 9},
           new { Id = 15, IsCover = true, Url = "https://images.pexels.com/photos/161123/windmill-water-church-agriculture-161123.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", LocationId =10},
           new { Id = 16, IsCover = false, Url = "https://images.pexels.com/photos/1643384/pexels-photo-1643384.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", LocationId = 1 },
           new { Id = 17, IsCover = false, Url = "https://images.pexels.com/photos/1428348/pexels-photo-1428348.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", LocationId = 1},
           new { Id = 18, IsCover = false, Url = "https://images.pexels.com/photos/870170/pexels-photo-870170.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", LocationId = 5},
           new { Id = 19, IsCover = false, Url = "https://images.pexels.com/photos/984619/pexels-photo-984619.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", LocationId = 5 },
           new { Id = 20, IsCover = false, Url = "https://images.pexels.com/photos/4237154/pexels-photo-4237154.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", LocationId = 9 },
           new { Id = 21, IsCover = false, Url = "https://images.pexels.com/photos/2098913/pexels-photo-2098913.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", LocationId = 6 },
           new { Id = 22, IsCover = false, Url = "https://images.pexels.com/photos/2954929/pexels-photo-2954929.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", LocationId = 8 },
           new { Id = 23, IsCover = false, Url = "https://images.pexels.com/photos/2449549/pexels-photo-2449549.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", LocationId = 10 }
                 );





            modelBuilder.Entity<Reservation>().HasData(
    new { Id = 1, StartDate = new DateTime(2025, 7, 5), EndDate = new DateTime(2025, 8, 5), CustomerId = 1, LocationId = 3, Discount = 0F },
    new { Id = 2, StartDate = new DateTime(2025, 5, 9), EndDate = new DateTime(2025, 6, 1), CustomerId = 2, LocationId = 6, Discount = 0F },
    new { Id = 3, StartDate = new DateTime(2025, 11, 11), EndDate = new DateTime(2025, 1, 1), CustomerId = 3, LocationId = 4, Discount = 0F }
);






        }
    }
}



