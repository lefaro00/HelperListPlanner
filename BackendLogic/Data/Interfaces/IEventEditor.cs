using BackendLogic.Data.Entities;
using BackendLogic.Data.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendLogic.Data.Interfaces
{
    internal interface IEventEditor
    {
        public Task Reschedule(Host host, Event _event, DateTime startTime, DateTime endTime);
        public Task AddShift(string name, string? description, int amountHelpersNeeded, ValueObjects.ShiftType type, DateTime startTime, DateTime endTime);
        public Task AlterShift(Guid shiftID, string name, string? description, int amountHelpersNeeded, ValueObjects.ShiftType type, DateTime startTime, DateTime endTime);
        public Task RemoveShift(Guid shiftID);
        public Task EnterForShift(Event _event, Guid shiftID, Helper helper);
    }
}
