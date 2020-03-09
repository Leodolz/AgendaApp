using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaManager;

namespace AgendaWinFormsApp
{
    class DateFilterer: IAgendaFilterer
    {
        AgendaController agendaController;
        public DateFilterer(AgendaController agendaController)
        {
            this.agendaController = agendaController;
        }
        public Dictionary<int, AgendaEntry> GetFilteredAgenda(string filteringDate)
        {
            if (filteringDate == null)
                return agendaController.GetAgenda();
            Dictionary<int, AgendaEntry> filteredAgenda = new Dictionary<int, AgendaEntry>();
            DateTime filteringDateTime = Validators.GetDateTime(filteringDate.Trim());
            foreach (KeyValuePair<int, AgendaEntry> agendaEntry in agendaController.GetAgenda())
            {
                DateTime entryDateTime = Validators.GetDateTime(agendaEntry.Value.date.Trim());
                if (entryDateTime.Date == filteringDateTime.Date)
                    filteredAgenda.Add(agendaEntry.Key, agendaEntry.Value);
            }
            return filteredAgenda;
        }
    }
}

