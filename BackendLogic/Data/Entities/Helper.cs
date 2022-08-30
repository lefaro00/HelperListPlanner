using BackendLogic.Data.Interfaces;

namespace BackendLogic.Data.Entities
{
    public class Helper : IPerson
    {
        string NickName { get; set; }
        public Helper(string nickName, string firstName, string? lastName, string eMail, string? phone)
        {
            NickName = nickName;
            FirstName = firstName;
            LastName = lastName;
            Email = eMail;
            PhoneNumber = phone;
        }
    }
}
