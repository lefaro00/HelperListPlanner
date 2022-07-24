namespace HelperListPlanner.Data.Entities
{
    public class Event
    {
        string Name { get; set; }
        string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        List<Shift> Shifts { get; set; }
        Location Location { get; set; }

        public Event(string name, string description, DateTime startTime, DateTime endTime, List<Shift> shifts, Location location)
        {
            Name = name;
            Description = description;
            StartTime = startTime;
            EndTime = endTime;
            Shifts = shifts;
            Location = location;
        }
    }
}
