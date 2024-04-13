namespace AirB_B.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public Landlord? Landlord { get; set; }
        public Location? Location { get; set; }
        public bool IsCover { get; set; }
    }
}
