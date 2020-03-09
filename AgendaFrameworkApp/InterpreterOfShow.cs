using System;
using AgendaManager;

namespace AgendaFrameworkApp
{
    class InterpreterOfShow:ITaskOrder
    {
        AgendaController agendaController;
        public InterpreterOfShow(AgendaController agendaController)
        {
            this.agendaController = agendaController;
        }

        public bool ExecuteTask(string showDate, string[] optionCommands)
        {
            foreach (string optionCommand in optionCommands)
            {
                if(optionCommand!= null)
                {
                    showDate = optionCommand;
                }
            }
            showDate = AgendaTools.GetDateIfNecessary(showDate);
            Console.WriteLine(showDate);
            if (Validators.IsValidDate(showDate.Trim()))
                ShowEntries(showDate);
            else return false;
            return true;
        }

        private void ShowEntries(string entryDate)
        {
            foreach (AgendaEntry entry in AgendaTools.FilterByDate(entryDate, agendaController.GetAgenda()))
            {
                Console.WriteLine(AgendaTools.BuildEntryShowingMessage(entry));
            }
        }
    }
}
