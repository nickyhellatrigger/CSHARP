namespace mxgpSystem.Models
{
    public class Track
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public List<Race> Races { get; set; }
    }
}
