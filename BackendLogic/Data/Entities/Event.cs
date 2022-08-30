namespace BackendLogic.Data.Entities
{
    public class Event
    {
        string Name { get; set; }
        public Host Host { get; }
        string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        List<Shift> Shifts { get; set; }
        Location Location { get; set; }
        public bool Passed { get => (StartTime < DateTime.Now); }

        public Event(string name, Host host, string description, DateTime startTime, DateTime endTime, List<Shift> shifts, Location location)
        {
            Name = name;
            Host = host;
            Description = description;
            StartTime = startTime;
            EndTime = endTime;
            Shifts = shifts;
            Location = location;
        }
    }
}
