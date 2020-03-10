using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaManager
{
    public interface IAgendaFilterer
    {
        Dictionary<int, AgendaEntry> GetFilteredAgenda(string filteringOption);
    }
}
