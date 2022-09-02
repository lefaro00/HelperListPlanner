using BackendLogic.Data.Factories;
using BackendLogic.Data.ValueObjects;

namespace BackendLogic.Data.Entities
{
    public class Host
    {
        public string Name { get; }
        public IPerson Accountable { get; set; }
        List<IPerson> Team { get; set; }


        public Host(string name, Accountable accountable)
        {
            Name = name;
            Accountable = accountable;
            Team = new();
        }

        public void AddTeamMember(Helper teamMember)
        {
            Team.Add(teamMember);
        }
/*
        public void RefreshHostedEvents()
        {
            List<Event> passedEvents = new();
            foreach (Event scheduledEvent in OpenEvents)
            {
                if (scheduledEvent.EndTime.CompareTo(DateTime.Now) < 0)
                {
                    passedEvents.Append(scheduledEvent);
                }
            }
            foreach (Event passedEvent in passedEvents)
            {
                HostedEvents.Add(passedEvent);
                OpenEvents.Remove(passedEvent);
            }
        }
*/
    }
}
