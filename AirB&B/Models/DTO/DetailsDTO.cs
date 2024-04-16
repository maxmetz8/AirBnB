using static AirB_B.Models.Location;

namespace AirB_B.Models.DTO
{
    public class DetailsDTO
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public int Rooms { get; set; }

        public int NumberOfGuests { get; set; }

        public float PricePerDay { get; set; }

        public LocationType Type { get; set; }
        public LocationFeatures Features { get; set; }
        public virtual List<ImageDTO> Images { get; set; }
        public virtual LandlordDTO Landlord { get; set; }
    }
}
