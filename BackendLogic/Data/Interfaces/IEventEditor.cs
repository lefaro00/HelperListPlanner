using BackendLogic.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendLogic.Data.Services
{
    internal interface IEventEditor
    {
        public Task Reschedule(Host host, Event _event, DateTime startTime, DateTime endTime);
        public Task AddShift(string name, string? description, int amountHelpersNeeded, ValueObjects.ShiftType type, DateTime startTime, DateTime endTime);
        public Task RemoveShift(Guid shiftID);
        public Task EnterForShift(Guid shiftID, Helper helper);
    }
}
