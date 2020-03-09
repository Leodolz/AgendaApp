using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaFrameworkApp
{
    class AdderThreeEntries : ITaskOrder
    {
        AgendaController agendaController;
        char splitChar;
        public AdderThreeEntries(AgendaController agendaController, char splitChar)
        {
            this.agendaController = agendaController;
            this.splitChar = splitChar;
        }
        public void ExecuteTask(string userEntry)
        {
            string[] controllerCommands = userEntry.Split(splitChar);
            string entryText = controllerCommands[2]; string entryDate = controllerCommands[0]; string entryTime = controllerCommands[1];
            if (Validators.IsValidDate(entryDate) && Validators.IsValidTime(entryTime))
                agendaController.AddEntry(entryText, entryDate, entryTime);
            else Console.WriteLine("Formato invalido... Debe considerar un formato de: <Fecha> <Hora> <Texto>");
        }
    }
}
