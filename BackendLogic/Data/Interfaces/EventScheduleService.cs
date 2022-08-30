using BackendLogic.Data.Entities;
using BackendLogic.Data.Controlling;

namespace BackendLogic.Data.Services
{
    public class EventScheduleService
    {
        public async Task<IEnumerable<Host>> GetHosts()
        {
            return EventCalender.Hosts;
        }

        public async Task<bool> ScheduleEvent(Host host, Event plannedEvent)
        {
            foreach (var _host in EventCalender.Hosts)
            {
                if (host == _host)
                {
                    _host.ScheduleEvent(plannedEvent);
                    return true;
                }
            }
            return false;
        }



    }
}
