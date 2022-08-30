using BackendLogic.Data.Entities;

namespace BackendLogic.Data.Controlling
{
    public static class EventCalender
    {
        public static List<Entities.Host> Hosts { get; set; } = new();
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
        public static void EnterEvent(Event @event)
        {
            if (@event.StartTime < DateTime.Now)
            {
                OpenEvents.Add(@event);
            }
            else
            {
                PassedEvents.Add(@event);
            }
        }
        public static void DeleteEvent(Event _event, bool markAsCanceled)
        {
            if (markAsCanceled)
            {
                var success = OpenEvents.Remove(_event);
                if (!success)
                {
                    PassedEvents.Remove(_event);
                }
            }
        }
        public static IEnumerable<Event> GetEventsInMonth(Month month, Entities.Host host)
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
    }
}
