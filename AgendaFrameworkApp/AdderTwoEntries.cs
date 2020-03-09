using System;
using AgendaManager;

namespace AgendaFrameworkApp
{
    class AdderTwoEntries : ITaskOrder
    {
        AgendaController agendaController;
        public AdderTwoEntries(AgendaController agendaController)
        {
            this.agendaController = agendaController;
        }
        public bool ExecuteTask(string entryTextCommand, string[] commandOptions)
        {
            return ValidateCommand(commandOptions);
        }
        private bool ValidateCommand(string[] entryAttributes)
        {
            string entryText = entryAttributes[1];
            string dateOrTime = entryAttributes[0];
            if (Validators.IsValidTime(dateOrTime))
                return agendaController.AddEntry(entryText, string.Empty, dateOrTime);
            else if (Validators.IsValidDate(dateOrTime))
                return agendaController.AddEntry(entryText, dateOrTime, string.Empty);
            else return false;
        }

    }
}
