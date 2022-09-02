using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackendLogic.Data.Model;
using BackendLogic.Data.Entities;
using BackendLogic.Data.Interfaces;

namespace BackendLogic.Data.Services
{
    public class CalendarService: ICalendarService
    {
        public async Task<bool> ScheduleEvent(Event plannedEvent)
        {
            EventCalender.ScheduleEvent(plannedEvent);
            return false;
        }

        public async Task<bool> CancelEvent(Event plannedEvent)
        {
            return EventCalender.CancelEvent(plannedEvent);
        }

        public async Task<IEnumerable<Event>> GetOpenEvents()
        {
            return EventCalender.OpenEvents;
        }

        public async Task<IEnumerable<Event>> GetEventsByHost(Host host, bool includePassedEvents = false)
        {
            var events = EventCalender.OpenEvents;
            if (includePassedEvents)
            {
                events.AddRange(EventCalender.PassedEvents);
            }

            return events;            
        }

        public async Task<IEnumerable<Event>> GetEventsInMonth(Month month, Host? host = null)
        {
            return EventCalender.GetEventsInMonth(month, host);
        }

        public async Task<IEnumerable<Host>> GetHosts()
        {
            return EventCalender.Hosts;
        }

        public async Task<IEnumerable<Location>> GetLocations()
        {
            List<Location> locations = new List<Location>();
            var events = EventCalender.PassedEvents;
            events.AddRange(EventCalender.OpenEvents);
            foreach (var _event in events)
            {
                locations.Add(_event.Location);
            }
            locations.Distinct();
            return locations;

        }


    }
}
