using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackendLogic.Data.Entities;
using BackendLogic.Data.Interfaces;
using BackendLogic.Data.ValueObjects;
using BackendLogic.Data.Model;

namespace BackendLogic.Data.Services
{
    public class PersonService : IPersonService
    {
        public async Task<Accountable> CreateAccountable(string firstName, string lastName, string eMail, string phoneNumber)
        {
            var accountable = new Accountable(firstName, lastName, eMail, phoneNumber);
            return accountable;
        }

        public async Task<Host> CreateHost(string name, Accountable accountable)
        {
            var host = new Host(name, accountable);
            return host;
        }

        public async Task<Host?> ChangeHostAccountable(Host host, Accountable accountable)
        {
            Host alteredHost = null;
            foreach (Host _host in EventCalender.Hosts)
            {
                if (_host == host)
                {
                    _host.ChangeAccountable(accountable);
                    alteredHost = _host;
                }
            }
            foreach (Event _event in EventCalender.OpenEvents)
            {
                if (_event.Host == host)
                {
                    _event.Host.ChangeAccountable(accountable);
                }
            }
            return alteredHost;
        }

        public async Task<Helper> CreateHelper(string nickname, string firstName, string lastName, string eMail, string phoneNumber)
        {
            var helper = new Helper(nickname, firstName, lastName, eMail, phoneNumber);

            return helper;
        }
    }
}
