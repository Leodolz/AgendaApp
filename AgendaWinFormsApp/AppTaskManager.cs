using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaManager;

namespace AgendaWinFormsApp
{
    public class AppTaskManager : IUserClient
    {
        public static Dictionary<string, ITaskOrder> TaskValidCommands = new Dictionary<string, ITaskOrder>();
        readonly AgendaController agendaController = AgendaTools.CreateAgendaController();
        public void AddValidCommand(string taskCommandName, ITaskOrder executableCommand)
        {
            TaskValidCommands.Add(taskCommandName, executableCommand);
        }
        public AppTaskManager()
        {
            TaskValidCommands =
                new Dictionary<string, ITaskOrder>()
                {
                    {"ADD", new ActionerOfAdd(agendaController, GetCustomDictionary())},
                    {"REMOVE", new ActionerOfRemove(agendaController)},
                    {"FILTER", new ActionerOfFilter(agendaController) }
                };
        }

        public AgendaController GetAgendaController()
        {
            return agendaController;
        }

        public void ExecuteCommand(string commandName, string commandEntry)
        {
            if (TaskValidCommands.ContainsKey(commandName))
                TaskValidCommands[commandName].ExecuteTask(commandEntry,commandEntry.Split('|'));
        }
        private Dictionary<int,ITaskOrder> GetCustomDictionary()
        {
            return new Dictionary<int, ITaskOrder>()
            {
                { 3,new AdderOfEntries(agendaController) }
            };
        }
    }
}
