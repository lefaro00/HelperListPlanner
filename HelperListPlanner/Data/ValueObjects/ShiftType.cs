namespace HelperListPlanner.Data.Entities
{
    public class ShiftType
    {
        string Name { get; }
        string Description { get; }

        public ShiftType(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
