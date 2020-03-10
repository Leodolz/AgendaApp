using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaManager;

namespace AgendaFrameworkApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IUserClient userInterpreter = new UserClientDecorator(new BaseUserInterpreter());
            Console.WriteLine("Agenda App\nComandos:\n1. ADD\n2. SHOW\n3. REMOVE\n4. SEARCH\n5. EXIT");
            while (true)
            {
                string userCommandEntry = Console.ReadLine();
                userInterpreter.ExecuteCommand(userCommandEntry.Split(' ')[0],userCommandEntry);
            }
        }
    }
}
