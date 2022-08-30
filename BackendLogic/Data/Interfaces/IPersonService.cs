using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendLogic.Data.Interfaces
{
    public interface IPersonService
    {
        public Task<Entities.Helper> CreateHelper(string Nickname, string firstName, string lastName, string eMail, string? phoneNumber);

        public Task<Entities.Helper> AlterHelper(Entities.Helper helper, string Nickname, string firstName, string lastName, string? eMail, string? phoneNumber); 

        public Task<Entities.Accountable> CreateAccountable(string firstName, string lastName, string eMail, string phoneNumber);

        public Task<Entities.Host> CreateHost(string name, Entities.Accountable accountable);

    }
}
