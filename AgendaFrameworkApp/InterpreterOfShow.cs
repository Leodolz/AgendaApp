using System;
using System.Collections.Generic;
using AgendaManager;

namespace AgendaFrameworkApp
{
    class InterpreterOfShow:ITaskOrder
    {
        readonly AgendaController agendaController;
        public InterpreterOfShow(AgendaController agendaController)
        {
            this.agendaController = agendaController;
        }
        public bool ExecuteTask(string showDate, string[] optionCommands)
        {
            if(showDate.Trim() == "")
                showDate = GetShowDate(optionCommands);
            DateFilterer dateFilterer = new DateFilterer(agendaController);
            showDate = AgendaTools.GetDateIfNecessary(showDate);
            if (Validators.IsValidDate(showDate.Trim()))
                ShowEntries(dateFilterer.GetFilteredAgenda(showDate));
            else return false;
            return true;
        }
        public static void ShowEntries(Dictionary<int,AgendaEntry> filteredAgenda)
        {
            foreach (KeyValuePair<int,AgendaEntry> agendaEntries in filteredAgenda)
            {
                Console.WriteLine(AgendaTools.BuildEntryShowingMessage(agendaEntries.Value));
            }
        }
        private string GetShowDate(string[] optionCommands)
        {
            foreach (string optionCommand in optionCommands)
            {
                if (optionCommand != "")
                {
                    return optionCommand;
                }
            }
            return "";
        }
    }
}
