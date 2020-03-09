using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaFrameworkApp;

namespace AgendaWinFormsApp
{
    class TextFilterer : IAgendaFilterer
    {
        AgendaController agendaController;
        public TextFilterer(AgendaController agendaController)
        {
            this.agendaController = agendaController;
        }
        public Dictionary<int, AgendaEntry> GetFilteredAgenda(string filteringText)
        {
            return FilterByText(filteringText, agendaController.GetAgenda());
        }
        private Dictionary<int, AgendaEntry> FilterByText(string filteringText, Dictionary<int, AgendaEntry> userAgenda)
        {
            Dictionary<int, AgendaEntry> filteredAgenda =
                userAgenda.Where(agendaItem => agendaItem.Value.text.Contains(filteringText))
                .ToDictionary(agenda => agenda.Key, agenda => agenda.Value);
            return GetSortedByDate(AgendaTools.GetAgendaValues(filteredAgenda));
        }
        private Dictionary<int, AgendaEntry> GetSortedByDate(ArrayList entryList)
        {
            entryList.Sort(new CustomDateComparer());
            Dictionary<int, AgendaEntry> sortedAgenda = new Dictionary<int, AgendaEntry>();
            foreach (AgendaEntry agendaEntry in entryList)
            {
                sortedAgenda.Add(agendaEntry.ID, agendaEntry);
            }
            return sortedAgenda;
        }
        /*
         Dictionary<int, AgendaEntry> filteredEntryList = new Dictionary<int, AgendaEntry>();
         foreach (KeyValuePair<int, AgendaEntry> agendaEntry in userAgenda)
            {
                if (agendaEntry.Value.text.Contains(filteringText))
                    filteredEntryList.Add(agendaEntry.Key,agendaEntry.Value);
            }
         */ 
         //General Way
    }
}
