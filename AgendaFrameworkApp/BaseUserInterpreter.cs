using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using AgendaManager;
namespace AgendaFrameworkApp
{
    class BaseUserInterpreter:IUserClient
    {
        public static Dictionary<string, ITaskOrder> AgendaValidCommands = new Dictionary<string,ITaskOrder>();
        readonly AgendaController agendaController = AgendaTools.CreateAgendaController();
        public BaseUserInterpreter()
        {
            AgendaValidCommands =
                new Dictionary<string, ITaskOrder>()
                {
                    {"EXIT", new InterpreterOfEscape()},
                    {"ADD ", new ActionerOfAdd(agendaController,GetCustomAddCommands())},
                    {"SHOW", new InterpreterOfShow(agendaController)},
                    {"REMOVE ", new ActionerOfRemove(agendaController)},
                    {"SEARCH ", new InterpreterOfSearch(agendaController) }
                };
           
        }
        public void ExecuteCommand(string commandName, string userEntry)
        {
            foreach(string validCommandName in AgendaValidCommands.Keys)
            {
                if (commandName.StartsWith(validCommandName.Trim()))
                {
                    string[] agendaCommands = ReplaceTextOnce(userEntry, validCommandName, string.Empty).Split(' ');
                    if (AgendaValidCommands[validCommandName].ExecuteTask(agendaCommands[0], agendaCommands))
                    {
                        Console.WriteLine("Operation " + validCommandName.Trim() + " executed succesfully");
                        return;
                    }
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
        private Dictionary<int,ITaskOrder> GetCustomAddCommands()
        {
            return new Dictionary<int, ITaskOrder>()
            {
                {1,new AdderOneEntry(agendaController)},
                {2,new AdderTwoEntries(agendaController)},
                {3,new AdderThreeEntries(agendaController)}
            };
        }
    }
}
