namespace HelperListPlanner.Data.Entities
{
    public class Location
    {
        Accountable ContactPerson { get; set; }
        string Name { get; set; }
        string Street { get; }
        string HouseNumber { get; }
        string City { get; }
        int GuestCapacity { get; }

        public Location(Accountable contactPerson, string name, string street, string houseNumber, string city, int guestCapacity)
        {
            this.ContactPerson = contactPerson;
            this.Name = name;
            this.Street = street;
            this.HouseNumber = houseNumber;
            this.City = city;
            this.GuestCapacity = guestCapacity;
        }
    }
}
