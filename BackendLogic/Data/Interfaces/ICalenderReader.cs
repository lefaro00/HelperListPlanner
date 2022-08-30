using BackendLogic.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendLogic.Data.Interfaces
{
    internal interface ICalenderReader
    {
        public Task<IEnumerable<Event>> GetEventsInMonth(Month month, Host host = null);

        public Task<IEnumerable<Host>> GetHosts();

        public Task<IEnumerable<Event>> GetLocations();

    }
}
