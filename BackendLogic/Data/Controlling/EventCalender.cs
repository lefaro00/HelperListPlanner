using BackendLogic.Data.Entities;

namespace BackendLogic.Data.Controlling
{
    public static class EventCalender
    {
        public static List<Event> OpenEvents { get; } = new();
        public static List<Event> PassedEvents { get; } = new();
        public static IEnumerable<Host> Hosts
        {
            get
            {
                List<Host> hosts = new();
                foreach (var _event in OpenEvents)
                {
                    hosts.Add(_event.Host);
                }
                foreach (var _event in PassedEvents)
                {
                    hosts.Add(_event.Host);
                }
                hosts = (List<Host>)hosts.Distinct();
                return hosts;
            }
        }
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
    }
}
