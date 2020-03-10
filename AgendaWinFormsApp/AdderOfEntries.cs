using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaManager;

namespace AgendaWinFormsApp
{
    class AdderOfEntries : ITaskOrder
    {
        AgendaController agendaController;
        public AdderOfEntries(AgendaController agendaController)
        {
            this.agendaController = agendaController;
        }
        public bool ExecuteTask(string entryText, string[] optionCommands=null)
        {
            optionCommands = entryText.Split('|');
            return agendaController.AddEntry(optionCommands[0], optionCommands[1], optionCommands[2]);
        }
    }
}
