namespace mxgpSystem.Models
{
    public class Race
    {
        public int Id { get; set; }
        public Track Track { get; set; }
        public List<Member> Members { get; set; }
        public DateTime StartDate { get; set; }
        public double DurationMinutes { get; set; }
    }
}
