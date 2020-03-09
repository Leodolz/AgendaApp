using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaManager
{
    public class AgendaController
    {
        private Dictionary<int, AgendaEntry> userAgenda = new Dictionary<int, AgendaEntry>();
        private static int entryID = 1;
        public bool AddEntry(string entryText, string entryDate = "", string entryTime = "")
        {
            entryDate = AgendaTools.GetDateIfNecessary(entryDate);
            userAgenda.Add(entryID, new AgendaEntry(entryText, entryDate, entryTime, entryID));
            entryID++;
            return true;
        }
        public int GetID()
        {
            return entryID;
        }
        public void IncID()
        {
            entryID++;
        }
        public Dictionary<int, AgendaEntry> GetAgenda()
        {
            return userAgenda;
        }
        
    }
}
