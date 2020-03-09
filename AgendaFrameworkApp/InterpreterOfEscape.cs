using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaManager;

namespace AgendaFrameworkApp
{
    class InterpreterOfEscape : ITaskOrder
    {
        public bool ExecuteTask(string entryText=null, string[] optionCommands=null)
        {
            Environment.Exit(0);
            return true;
        }
    }
}
