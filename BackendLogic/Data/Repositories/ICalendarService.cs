using BackendLogic.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendLogic.Data.Interfaces
{
    public interface ICalendarService
    {
        public Task<bool> ScheduleEvent(Event plannedEvent);
        public Task<bool> CancelEvent(Event plannedEvent);

        public Task<IEnumerable<Event>> GetOpenEvents();
        public Task<IEnumerable<Event>> GetEventsInMonth(Month month, Entities.Host? host = null);
        public Task<IEnumerable<Event>> GetEventsByHost(Entities.Host host, bool includePassedEvents = false);

        public Task<IEnumerable<Host>> GetHosts();
        public Task<IEnumerable<Location>> GetLocations();

    }
}
