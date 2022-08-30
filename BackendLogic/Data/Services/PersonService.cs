using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackendLogic.Data.Entities;
using BackendLogic.Data.Interfaces;

namespace BackendLogic.Data.Services
{
    internal class PersonService : IPersonService
    {
        public Task<Helper> AlterHelper(Helper helper, string Nickname, string firstName, string lastName, string? eMail, string? phoneNumber)
        {
            throw new NotImplementedException();
        }

        public async Task<Accountable> CreateAccountable(string firstName, string lastName, string eMail, string phoneNumber)
        {
            var accountable = new Accountable(firstName, lastName, eMail, phoneNumber);
            return accountable;
        }

        public async Task<Helper> CreateHelper(string nickname, string firstName, string lastName, string eMail, string? phoneNumber)
        {
            var helper = new Helper(nickname, firstName, lastName, eMail, phoneNumber);

            return helper;
        }

        public async Task<Host> CreateHost(string name, Accountable accountable)
        {
            var host = new Host(name, accountable);
            return host;
        }
    }
}
