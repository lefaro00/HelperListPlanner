namespace HelperListPlanner.Data.Entities
{
    public class Accountable:IPerson
    {
        public Accountable(string firstName, string lastName, string poneNumber, string eMail)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PhoneNumber = poneNumber;
            this.Email = eMail;
        }
    }
}
