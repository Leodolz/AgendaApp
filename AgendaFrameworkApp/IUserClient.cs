using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaFrameworkApp
{
    public interface IUserClient
    {
        void ParseUserCommand(string userEntry);
        void AddUserValidCommand(string commandName, IUserOrder executableCommand);
        AgendaController GetAgendaController();
    }
}
