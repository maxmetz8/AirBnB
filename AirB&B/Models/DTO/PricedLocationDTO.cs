using static AirB_B.Models.Location;

namespace AirB_B.Models.DTO
{
    public class PricedLocationDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public string LandlordAvatarURL { get; set; }

        public float Price { get; set; }
        public LocationType Type { get; set; }
    }
}
