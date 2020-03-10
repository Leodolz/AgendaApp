using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using AgendaManager;

namespace AgendaFrameworkApp
{
    class InterpreterOfSearch : ITaskOrder
    {
        readonly AgendaController agendaController;
        public InterpreterOfSearch(AgendaController agendaController)
        {
            this.agendaController = agendaController;
        }
        public bool ExecuteTask(string entryText, string[] commandOptions = null)
        {
            TextFilterer textFilterer = new TextFilterer(agendaController);
            Dictionary<int, AgendaEntry> filteredAgenda = textFilterer.GetFilteredAgenda(entryText);
            foreach (KeyValuePair<int, AgendaEntry> filteredEntry in filteredAgenda)
            {
                Console.WriteLine(AgendaTools.BuildEntryShowingMessage(filteredEntry.Value));
            }
            return true;
        }
    }
}
