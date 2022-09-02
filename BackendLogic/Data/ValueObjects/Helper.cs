using BackendLogic.Data.Interfaces;

namespace BackendLogic.Data.ValueObjects
{
    public class Helper : IPerson
    {
        public string NickName { get; set; }
        public Helper(string nickName, string firstName, string? lastName, string eMail, string phone = "")
        {
            NickName = nickName;
            FirstName = firstName;
            LastName = lastName;
            Email = eMail;
            PhoneNumber = phone;
        }
    }
}
