using BackendLogic.Data.Entities;
using BackendLogic.Data.Controlling;

namespace BackendLogic.Data.Services
{
    public class EventService
    {
        public async Task<IEnumerable<Host>> GetHosts()
        {
            return EventCalender.Hosts;
        }

        public async Task<bool> ScheduleEvent(Event plannedEvent)
        {
            EventCalender.ScheduleEvent(plannedEvent);
            return false;
        }

        


    }
}
