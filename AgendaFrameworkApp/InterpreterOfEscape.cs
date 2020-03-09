using System;

namespace AgendaFrameworkApp
{
    class InterpreterOfEscape : IUserOrder
    {
        public void ExecuteTask(string text= "")
        {
            Environment.Exit(0);
        }
    }
}
