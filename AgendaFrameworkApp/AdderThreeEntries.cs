using System;
using System.Collections.Generic;
using System.Text;
using AgendaManager;

namespace AgendaFrameworkApp
{
    class AdderThreeEntries : ITaskOrder
    {
        AgendaController agendaController;
        public AdderThreeEntries(AgendaController agendaController)
        {
            this.agendaController = agendaController;
        }
        public bool ExecuteTask(string userEntry, string[] commandOptions)
        {
            string[] controllerCommands = commandOptions;
            string entryText = controllerCommands[2]; string entryDate = controllerCommands[0]; string entryTime = controllerCommands[1];
            if (Validators.IsValidDate(entryDate) && Validators.IsValidTime(entryTime))
                return agendaController.AddEntry(entryText, entryDate, entryTime);
            else return false;
        }
    }
}
