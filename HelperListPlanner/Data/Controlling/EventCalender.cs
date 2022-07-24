using HelperListPlanner.Data.Entities;
namespace HelperListPlanner.Data.Controlling
{
    public static class EventCalender
    {
        public static List<Event> OpenEvents { get; set; } = new();
        public static List<Entities.Host> Hosts { get; } = new();

        public static void AddHost(Entities.Host host)
        {
            Hosts.Add(host);
        }

        public static void EnterEvent(Entities.Host host, Event @event)
        {
            
        }
    }
}
