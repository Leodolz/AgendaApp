using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaManager;

namespace AgendaWinFormsApp
{
    class ActionerOfRemove: ITaskOrder
    {
        AgendaController agendaController;
        public ActionerOfRemove(AgendaController agendaController)
        {
            this.agendaController = agendaController;
        }
        public void ExecuteTask(string entryText)
        {
            if (int.TryParse(entryText, out int parsedId))
                RemoveEntry(parsedId);
            else Console.WriteLine("Comando invalido, revisar seccion Actioner of Remove");
        }
        private void RemoveEntry(int entryID)
        {
            agendaController.GetAgenda().Remove(entryID);
        }
    }
}
