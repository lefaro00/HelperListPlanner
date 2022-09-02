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

        public bool EnterInShift(Guid shiftID, ValueObjects.Helper helper)
        {
            foreach(var shift in Shifts)
            {
                if(shiftID == shift.ShiftID)
                {
                    var shiftHelpers = shift.Helpers;
                    shift.SignInHelper(helper);
                    if (shift.Helpers != shiftHelpers)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool ResignFromShift(Guid shiftID, ValueObjects.Helper helper)
        {
            foreach (var shift in Shifts)
            {
                if (shiftID == shift.ShiftID)
                {
                    var shiftHelpers = shift.Helpers;
                    shift.ResignHelper(helper);
                    if (shift.Helpers != shiftHelpers)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool Reschedule (DateTime startTime, DateTime endTime)
        {
            if(startTime <= endTime)
            {
                this.StartTime = startTime;
                this.EndTime = endTime;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AddShift(Shift shift)
        {
            foreach(var _shift in Shifts)
            {
                if( shift.StartTime             == _shift.StartTime     &&
                    shift.EndTime               == _shift.EndTime       &&
                    shift.Description           == _shift.Description   &&
                    shift.Type                  == _shift.Type          &&
                    shift.AmountHelpersNeeded   == _shift.AmountHelpersNeeded)
                {
                    return false;
                }
            }
            Shifts.Add(shift);
            return true;
        }
        
    }
}
