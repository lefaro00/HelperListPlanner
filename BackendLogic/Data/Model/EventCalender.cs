using BackendLogic.Data.Entities;
using BackendLogic.Data.ValueObjects;

namespace BackendLogic.Data.Model
{
    public static class EventCalender
    {
        public static List<Entities.Host> Hosts { get; set; } = new();

        public static List<Entities.Location> Locations { get; set; } = new();

        public static List<Entities.Event> OpenEvents { get; set; } = new();
        public static List<Entities.Event> PassedEvents { get; set; } = new();

        private static IEnumerable<Event> Events
        {
            get
            {
                List<Event> events = new();
                events.AddRange(PassedEvents);
                events.AddRange(OpenEvents);
                return events;
            }
        }
        public static bool CancelEvent(Event _event)
        {
            var success = OpenEvents.Remove(_event);
            if (!success)
            {
                success = PassedEvents.Remove(_event);
            }
            return success;
            
        }
        public static void ScheduleEvent(Event plannedEvent)
        {
            if (!(Hosts.Contains(plannedEvent.Host)))
            {
                Hosts.Add(plannedEvent.Host);
            }
            if (plannedEvent.Passed)
            {
                PassedEvents.Add(plannedEvent);
            }
            else 
            {
                OpenEvents.Add(plannedEvent);
            }
        }
        public static IEnumerable<Event> GetEventsInMonth(Month month, Entities.Host? host = null)
        {
            List<Event> eventsInMonth = new();
            foreach (Event _event in Events)
            {
                if (host == null || _event.Host == host)
                {
                    if (_event.StartTime.Month == (int)month || _event.EndTime.Month == (int)month)
                    {
                        eventsInMonth.Add(_event);
                    }
                }
            }
            return eventsInMonth;
        }

        public static bool SignIntoShift(Event _event, Guid shiftID, Helper helper)
        {
            foreach (var openEvent in OpenEvents)
            {
                if (_event == openEvent)
                {
                    return openEvent.EnterInShift(shiftID, helper);
                }
            }
            return false;
        }

        public static bool ResignFromShift(Event _event, Guid shiftID, Helper helper)
        {
            foreach (var openEvent in EventCalender.OpenEvents)
            {
                if (_event == openEvent)
                {
                    return openEvent.ResignFromShift(shiftID, helper);
                }
            }
            return false;
        }
    }
}
