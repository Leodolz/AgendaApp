using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaManager;

namespace AgendaFrameworkApp
{
    public class InterpreterOfAdd : ITaskOrder
    {
        private const int ONE_ENTRY = 1;
        private const int TWO_ENTRIES = 2;
        private const int THREE_ENTRIES = 3;
        readonly AgendaController agendaController;
        public InterpreterOfAdd(AgendaController agendaController)
        {
            this.agendaController = agendaController;
        }
        public bool ExecuteTask(string userEntry, string[] entryParameters)
        {
            int numberOfEntryValues = entryParameters.Length;
            ITaskOrder agendaAddCommand = GetAddCommand(numberOfEntryValues, agendaController);
            if (agendaAddCommand != null)
                 return agendaAddCommand.ExecuteTask(userEntry,entryParameters);
            else return false;
        }
        private ITaskOrder GetAddCommand(int numberOfEntryValues, AgendaController agendaClient)
        {
            switch (numberOfEntryValues)
            {
                case ONE_ENTRY:
                    return new AdderOneEntry(agendaClient);
                case TWO_ENTRIES:
                    return new AdderTwoEntries(agendaClient);
                case THREE_ENTRIES:
                    return new AdderThreeEntries(agendaClient);
                default:
                    return null;
            }
        }
    }
}
