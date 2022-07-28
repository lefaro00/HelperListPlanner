namespace HelperListPlanner.Data.Entities
{
    public class Event
    {
        string Name { get; set; }
        public Entities.Host Host { get; }
        string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        List<Shift> Shifts { get; set; }
        Location Location { get; set; }

        public Event(string name, Entities.Host host, string description, DateTime startTime, DateTime endTime, List<Shift> shifts, Location location)
        {
            Name = name;
            this.Host = host;
            Description = description;
            StartTime = startTime;
            EndTime = endTime;
            Shifts = shifts;
            Location = location;
        }
    }
}
