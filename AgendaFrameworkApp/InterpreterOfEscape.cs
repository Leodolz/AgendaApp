using System;
using AgendaManager;
namespace AgendaFrameworkApp
{
    class InterpreterOfEscape : ITaskOrder
    {
        public bool ExecuteTask(string text= "", string[] commandOptions = null)
        {
            Environment.Exit(0);
            return true;
        }

    }
}
