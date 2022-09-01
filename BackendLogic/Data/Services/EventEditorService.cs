using BackendLogic.Data.Entities;
using BackendLogic.Data.Controlling;
using BackendLogic.Data.Interfaces;
using BackendLogic.Data.ValueObjects;

namespace BackendLogic.Data.Services
{
    public class EventEditorService : IEventEditor
    {
        public Task AddShift(string name, string? description, int amountHelpersNeeded, ShiftType type, DateTime startTime, DateTime endTime)
        {
            throw new NotImplementedException();
        }

        public Task AlterShift(Guid shiftID, string name, string? description, int amountHelpersNeeded, ShiftType type, DateTime startTime, DateTime endTime)
        {
            throw new NotImplementedException();
        }

        public async Task EnterForShift(Event _event, Guid shiftID, Helper helper)
        {
            foreach(var openEvent in EventCalender.OpenEvents)
            {
                if(_event == openEvent)
                {
                    foreach (Shift shift in openEvent.Shifts)
                    {
                        if (shift.ShiftID == shiftID)
                        {
                            shift.SignInHelper(helper);
                            
                        }
                    }
                }
            }            
        }

        public Task RemoveShift(Guid shiftID)
        {
            throw new NotImplementedException();
        }

        public Task Reschedule(Host host, Event _event, DateTime startTime, DateTime endTime)
        {
            throw new NotImplementedException();
        }
    }
}
