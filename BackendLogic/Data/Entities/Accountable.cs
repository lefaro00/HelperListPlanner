using BackendLogic.Data.Interfaces;

namespace BackendLogic.Data.Entities
{
    public class Accountable : IPerson
    {
        public Accountable(string firstName, string lastName, string poneNumber, string eMail)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = poneNumber;
            Email = eMail;
        }
    }
}
