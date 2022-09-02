using BackendLogic.Data.ValueObjects;

namespace BackendLogic.Data.Entities
{
    public class Shift
    {
        public Guid ShiftID { get; set; }
        public string? Description { get; set; }
        public Helper[] Helpers { get; private set; }
        public ShiftType Type { get; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int AmountHelpersNeeded { get => Helpers.Length; set => Helpers = ReinitializeHelpers(value, Helpers); }

        public Shift(string? description, int amountHelpersNeeded, ShiftType type, DateTime startTime, DateTime endTime)
        {
            ShiftID = new Guid();
            Description = description;
            Helpers = new Helper[amountHelpersNeeded];
            Type = type;
            StartTime = startTime;
            EndTime = endTime;
        }

        public IEnumerable<Helper> SignInHelper(Helper helper)
        {
            var returnVal = Helpers;
            for (int i = 0; i < AmountHelpersNeeded; i++)
            {
                if(Helpers[i] != null)
                {
                    if (Helpers[i].NickName == helper.NickName)
                    {
                        returnVal = Helpers;
                        return returnVal;
                    }
                }
            }
            for (int i = 0; i < AmountHelpersNeeded; i++)
            {
                if (Helpers[i]== null)
                {
                    Helpers[i] = helper;
                    returnVal = Helpers;
                    return returnVal;
                }
            }
            return returnVal;
        }

        public IEnumerable<Helper> ResignHelper(Helper helper)
        {
            for(int i = 0; i < AmountHelpersNeeded; i++)
            {
                if (Helpers[i] == helper)
                {
                    Helpers[i] = null;
                }
            }
            var returnVal = Helpers;
            return returnVal;
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
