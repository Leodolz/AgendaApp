using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using AgendaManager;
namespace AgendaFrameworkApp
{
    class BaseUserInterpreter:IUserClient
    {
        public static Dictionary<string, ITaskOrder> AgendaValidCommands = new Dictionary<string,ITaskOrder>();
        AgendaController agendaController = AgendaTools.CreateAgendaController();
        public BaseUserInterpreter()
        {
            AgendaValidCommands =
                new Dictionary<string, ITaskOrder>()
                {
                    {"EXIT", new InterpreterOfEscape()},
                    {"ADD ", new InterpreterOfAdd(agendaController)},
                    {"SHOW", new InterpreterOfShow(agendaController)},
                    {"REMOVE ", new ActionerOfRemove(agendaController)},
                    {"SEARCH ", new InterpreterOfSearch(agendaController) }
                };
        }
        public void ExecuteCommand(string userEntry)
        {
            foreach(string commandName in AgendaValidCommands.Keys)
            {
                if (userEntry.StartsWith(commandName))
                {
                    string[] agendaCommands = ReplaceTextOnce(userEntry, commandName, string.Empty).Split(' ');
                    Console.WriteLine(agendaCommands[0]);
                    if (AgendaValidCommands[commandName].ExecuteTask(agendaCommands[0], agendaCommands))
                        return;
                }
            }
            ThrowInvalidCommandError(AgendaValidCommands);
        }
       
        private string ReplaceTextOnce(string textToModify,string oldCharSeq,string newCharSeq)
        {
            var regex = new Regex(Regex.Escape(oldCharSeq));
            return regex.Replace(textToModify, newCharSeq, 1);
        }
        private void ThrowInvalidCommandError(Dictionary<string,ITaskOrder> agendaValidCommands)
        {
            Console.WriteLine("Error, porfavor inserte un comando valido\nCOMANDOS:");
            int commandNumber = 1;
            foreach (string validCommand in agendaValidCommands.Keys)
            {
                Console.WriteLine(commandNumber+". "+validCommand);
                commandNumber++;
            }
        }
        public void AddValidCommand(string commandName, ITaskOrder executableCommand)
        {
            AgendaValidCommands.Add(commandName, executableCommand);
        }

        public AgendaController GetAgendaController()
        {
            return agendaController;
        }
    }
}
