namespace mxgpSystem.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string Country { get; set; }

        public string Name { get; set; }
        public string Password { get; set; }
        public Bike Bike { get; set; }

        public Member()
        { 
        }
    }
}
