using mxgpSystem.Models;

namespace mxgpSystem
{
    public class RacesDB
    {
        private RacesDB raceDB;
        public List<Bike> Bikes { get; set; }
        public List<Member> Members { get; set; }

        public List<Race> Races { get; set; }
        public List<Track> Tracks { get; set; }
        

        private RacesDB()
        {
            Bikes = new List<Bike>();
            Members = new List<Member>();
            Races = new List<Race>();
            Tracks = new List<Track>();
        }
        public RacesDB getDBInstance()
        {
            if(raceDB == null )
                raceDB = new RacesDB();
            return raceDB;
        }
    }
}
