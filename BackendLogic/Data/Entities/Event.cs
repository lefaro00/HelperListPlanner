using BackendLogic.Data.ValueObjects;

namespace BackendLogic.Data.Entities
{
    public class Event
    {
        public string Name { get; set; }
        public Host Host { get; }
        string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public List<Shift> Shifts { get; set; }
        public Location Location { get; set; }
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

        public bool EnterInShift(Guid shiftID, Helper helper)
        {
            foreach(var shift in Shifts)
            {
                if(shiftID == shift.ShiftID)
                {
                    try
                    {
                        shift.SignInHelper(helper);
                        return true;
                    }
                    catch
                    {
                        return false;
                    }                  
                }
            }
            return false;
        }
    }
}
