using BackendLogic.Data.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendLogic.Data.Interfaces
{
    public interface IPersonService
    {
        public Task<Helper> CreateHelper(string nickname, string firstName, string lastName, string eMail, string phoneNumber="");

        public Task<Entities.Accountable> CreateAccountable(string firstName, string lastName, string eMail, string phoneNumber);

        public Task<Entities.Host> CreateHost(string name, Entities.Accountable accountable);

        public Task<Entities.Host?> ChangeHostAccountable(Entities.Host host, Entities.Accountable accountable);

    }
}
