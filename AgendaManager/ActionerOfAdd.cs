using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaManager
{
    public class ActionerOfAdd:ITaskOrder
    {

        private Dictionary<string, ITaskOrder> validAddCommands;
        readonly AgendaController agendaController;
        public ActionerOfAdd(AgendaController agendaController)
        {
            this.agendaController = agendaController;
            validAddCommands = new Dictionary<string, ITaskOrder>()
            {
                { "ADD",new AdderOneEntry(agendaController)}
            };
        }
        public bool ExecuteTask(string userEntry, string[] commandOptions)
        {
            ITaskOrder agendaAddCommand = GetAddCommand(userEntry, agendaController);
            if (agendaAddCommand != null)
            {
                agendaAddCommand.ExecuteTask(userEntry, commandOptions);
            }
            else return false;
            return true;
        }
        private ITaskOrder GetAddCommand(string commandName, AgendaController agendaClient)
        {
            if (validAddCommands.ContainsKey(commandName))
                return validAddCommands[commandName];
            else return null;
        }
        private void AddValidCommand(Dictionary<string, ITaskOrder> newCommands)
        {
            foreach(KeyValuePair<string,ITaskOrder> newCommand in newCommands)
            {
                validAddCommands.Add(newCommand.Key, newCommand.Value);
            }
        }
    }
}
