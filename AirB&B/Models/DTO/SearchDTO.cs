using static AirB_B.Models.Location;

namespace AirB_B.Models.DTO
{
    public class SearchDTO
    {
        public LocationFeatures? Features { get; set; }
        public LocationType? Type { get; set; }
        public int? Rooms { get; set; }
        public int? MinPrice { get; set; }
        public int? MaxPrice{get; set;}
    }
}
