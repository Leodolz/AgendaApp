using System;

namespace AgendaFrameworkApp
{
    class InterpreterOfEscape : ITaskOrder
    {
        public void ExecuteTask(string text= "")
        {
            Environment.Exit(0);
        }
    }
}
