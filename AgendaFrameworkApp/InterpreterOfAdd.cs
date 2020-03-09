using System;
using AgendaManager;
namespace AgendaFrameworkApp
{
    public class InterpreterOfAdd : ITaskOrder
    {
        private const int ONE_ENTRY = 1;
        private const int TWO_ENTRIES = 2;
        private const int THREE_ENTRIES = 3;
        private char splitChar;
        readonly AgendaController agendaController;
        public InterpreterOfAdd(AgendaController agendaController, char splitChar)
        {
            this.agendaController = agendaController;
            this.splitChar = splitChar;
        }
        public void ExecuteTask(string userEntry, string )
        {
            int numberOfEntryValues = userEntry.Split(splitChar).Length;
            ITaskOrder agendaAddCommand = GetAddCommand(numberOfEntryValues, agendaController);
            if (agendaAddCommand != null)
                agendaAddCommand.ExecuteTask(userEntry);
            else Console.WriteLine("Formato invalido, vuelva a intentar");
        }
        private ITaskOrder GetAddCommand(int numberOfEntryValues, AgendaController agendaClient)
        {
            switch (numberOfEntryValues)
            {
                case TWO_ENTRIES:
                    return new AdderTwoEntries(agendaClient,splitChar);
                case THREE_ENTRIES:
                    return new AdderThreeEntries(agendaClient,splitChar);
                default:
                    return null;
            }
        }
    }
}
