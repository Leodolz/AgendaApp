using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaFrameworkApp;

namespace AgendaWinFormsApp
{
    public class AppTaskManager : IUserClient
    {
        public static Dictionary<string, ITaskOrder> TaskValidCommands = new Dictionary<string, ITaskOrder>();
        AgendaController agendaController = new AgendaController();
        public void AddValidCommand(string taskCommandName, ITaskOrder executableCommand)
        {
            TaskValidCommands.Add(taskCommandName, executableCommand);
        }
        public AppTaskManager()
        {
            TaskValidCommands =
                new Dictionary<string, ITaskOrder>()
                {
                    {"ADD", new InterpreterOfAdd(agendaController,'|')},
                    {"REMOVE", new ActionerOfRemove(agendaController)},
                    {"FILTER", new ActionerOfFilter(agendaController) }
                };
        }

        public AgendaController GetAgendaController()
        {
            return agendaController;
        }

        public void ExecuteCommand(string commandEntry)
        {
            string[] nameAndEntry = commandEntry.Split('~');
            string commandName = nameAndEntry[0];
            string userEntry = nameAndEntry[1];
            if (TaskValidCommands.ContainsKey(commandName))
                TaskValidCommands[commandName].ExecuteTask(userEntry);
        }
    }
}
