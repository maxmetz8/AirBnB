namespace AirB_B.Models
{
    public class Landlord
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Image? Avatar { get; set; }

        // Deze mag blijven
        public int? AvatarId { get; set; }

        public List<Location> Locations { get; set; }

        public Landlord()
        {
            Locations = new List<Location>();

        }
    }
}
