using HelperListPlanner.Data.Entities;
using HelperListPlanner.Data.Controlling;

namespace HelperListPlanner.Data.Services
{
    public class EventScheduleService
    {
        public async Task<IEnumerable<Entities.Host>> GetHosts()
        {
            return EventCalender.Hosts;

        }
        public async Task<bool> ScheduleEvent(Entities.Host host, Event plannedEvent)
        {
            foreach(var _host in EventCalender.Hosts)
            {
                if( host == _host)
                {
                    _host.ScheduleEvent(plannedEvent);
                    return true;
                }
            }
            return false;
        }
        


    }
}
