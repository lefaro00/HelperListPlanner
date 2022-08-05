using BackendLogic.Data.ValueObjects;

namespace BackendLogic.Data.Entities
{
    public class Shift
    {
        string Name { get; set; }
        string? Description { get; set; }
        Helper[] Helpers { get; set; }
        ShiftType Type { get; }
        DateTime StartTime { get; set; }
        DateTime EndTime { get; set; }
        int AmountHelpersNeeded { get => Helpers.Length; set => Helpers = ReinitializeHelpers(value, Helpers); }

        public Shift(string name, string? description, int amountHelpersNeeded, ShiftType type, DateTime startTime, DateTime endTime)
        {
            Name = name;
            Description = description;
            Helpers = new Helper[amountHelpersNeeded];
            Type = type;
            StartTime = startTime;
            EndTime = endTime;
        }

        public bool SignInHelper(Helper helper)
        {
            if (!Helpers.Contains(helper))
            {
                for (int i = 0; i < AmountHelpersNeeded; i++)
                {
                    if (Helpers[i] == null)
                    {
                        Helpers[i] = helper;
                        return true;
                    }
                }
            }
            return false;
        }

        private static Helper[] ReinitializeHelpers(int amountHelpersNeeded, Helper[] helpers)
        {
            var helperList = new Helper[amountHelpersNeeded];
            for (int i = 0; i < helperList.Length && i < helpers.Length; i++)
            {
                helperList[i] = helpers[i];
            }
            return helperList;
        }
    }
}
