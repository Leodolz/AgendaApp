using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaManager
{
    public interface IUserClient
    {
        void ExecuteCommand(string commandEntry);
        void AddValidCommand(string commandName, ITaskOrder executableCommand);
        AgendaController GetAgendaController();
    }
}
