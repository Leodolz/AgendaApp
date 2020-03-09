using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using AgendaManager;

namespace AgendaFrameworkApp
{
    class InterpreterOfSearch : ITaskOrder
    {
        AgendaController agendaController;
        public InterpreterOfSearch(AgendaController agendaController)
        {
            this.agendaController = agendaController;
        }
        public bool ExecuteTask(string entryText, string[] commandOptions =null)
        {
            ArrayList entriesToShow = FilterByText(entryText, agendaController.GetAgenda());
            foreach (AgendaEntry entry in entriesToShow)
            {
                Console.WriteLine(AgendaTools.BuildEntryShowingMessage(entry));
            }
            return true;
        }
        private ArrayList FilterByText(string filteringText, Dictionary<int, AgendaEntry> userAgenda)
        {
            ArrayList filteredEntryList = new ArrayList();
            foreach (KeyValuePair<int, AgendaEntry> agendaEntry in userAgenda)
            {
                if (agendaEntry.Value.text.Contains(filteringText))
                    filteredEntryList.Add(agendaEntry.Value);
            }
            return SortByDate(filteredEntryList);

        }
        private ArrayList SortByDate(ArrayList entryList)
        {
            entryList.Sort(new CustomDateComparer());
            return entryList;
        }
    }
}
