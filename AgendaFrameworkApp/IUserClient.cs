using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaFrameworkApp
{
    public interface IUserClient
    {
        void ExecuteCommand(string commandEntry);
        void AddValidCommand(string commandName, ITaskOrder executableCommand);
        AgendaController GetAgendaController();
    }
}
