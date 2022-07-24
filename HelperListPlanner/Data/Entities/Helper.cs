namespace HelperListPlanner.Data.Entities
{
    public class Helper:IPerson
    {
        string NickName { get; set; }
        public Helper(string nickName, string firstName, string? lastName , string eMail, string? phone)
        {
            nickName = nickName;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = eMail;
            this.PhoneNumber = phone;
        }
    }
}
