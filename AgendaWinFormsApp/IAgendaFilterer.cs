using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaManager;

namespace AgendaWinFormsApp
{
    interface IAgendaFilterer
    {
        Dictionary<int, AgendaEntry> GetFilteredAgenda(string filteringOption);
    }
}
