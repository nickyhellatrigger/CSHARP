namespace mxgpSystem.Models
{
    public class Bike
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string BikeName { get; set; }
        public List<Member> Members { get; set; }
    }
}
