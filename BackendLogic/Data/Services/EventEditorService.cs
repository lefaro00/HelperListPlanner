using BackendLogic.Data.Entities;
using BackendLogic.Data.Model;
using BackendLogic.Data.Interfaces;
using BackendLogic.Data.ValueObjects;

namespace BackendLogic.Data.Services
{
    public class EventEditorService : IEventEditor
    {
        public Task Reschedule(Host host, Event _event, DateTime startTime, DateTime endTime)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AddShift(string name, string? description, int amountHelpersNeeded, ShiftType type, DateTime startTime, DateTime endTime)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveShift(Guid shiftID)
        {
            throw new NotImplementedException();
        }

        public Task AlterShift(Guid shiftID, string name, string? description, int amountHelpersNeeded, ShiftType type, DateTime startTime, DateTime endTime)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> SignIntoShift(Event _event, Guid shiftID, Helper helper)
        {
            return EventCalender.SignIntoShift(_event, shiftID, helper);
        }

        public async Task<bool> ResignFromShift(Event _event, Guid shiftID, Helper helper)
        {
            return EventCalender.ResignFromShift(_event, shiftID, helper);
        }     
    }
}
