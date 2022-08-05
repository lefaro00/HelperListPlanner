namespace BackendLogic.Data.Entities
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
            ContactPerson = contactPerson;
            Name = name;
            Street = street;
            HouseNumber = houseNumber;
            City = city;
            GuestCapacity = guestCapacity;
        }
    }
}
