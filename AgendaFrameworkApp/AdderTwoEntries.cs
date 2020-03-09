using System;
using AgendaManager;

namespace AgendaFrameworkApp
{
    class AdderTwoEntries : ITaskOrder
    {
        AgendaController agendaController;
        char splitChar;
        public AdderTwoEntries(AgendaController agendaController, char splitChar)
        {
            this.agendaController = agendaController;
            this.splitChar = splitChar;
        }
        public bool ExecuteTask(string entryTextCommand, string[] commandOptions)
        {
            return ValidateCommand(entryTextCommand.Split(splitChar));
        }
        private bool ValidateCommand(string[] entryAttributes)
        {
            string entryText = entryAttributes[1];
            string dateOrTime = entryAttributes[0];
            if (Validators.IsValidTime(dateOrTime))
                agendaController.AddEntry(entryText, string.Empty, dateOrTime);
            else if (Validators.IsValidDate(dateOrTime))
                agendaController.AddEntry(entryText, dateOrTime, string.Empty);
            else return false;
            return true;
        }

    }
}
