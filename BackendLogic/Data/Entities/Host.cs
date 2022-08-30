using BackendLogic.Data.Interfaces;

namespace BackendLogic.Data.Entities
{
    public class Host
    {
        string Name { get; set; }
        IPerson Accountable { get; set; }
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
