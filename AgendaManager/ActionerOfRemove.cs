using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaManager
{
    public class ActionerOfRemove:ITaskOrder
    { 
        AgendaController agendaController;
        public ActionerOfRemove(AgendaController agendaController)
        {
            this.agendaController = agendaController;
        }
        public bool ExecuteTask(string idEntry, string[] commandOptions = null)
        {
            if (int.TryParse(idEntry, out int parsedId))
                return RemoveEntry(parsedId);
            else return false;
        }
        private bool RemoveEntry(int entryID)
        {
            if (agendaController.GetAgenda().Remove(entryID))
                return true;
            else return false;
        }
    }
}

