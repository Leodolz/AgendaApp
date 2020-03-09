using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaManager
{
    public class AdderOneEntry : ITaskOrder
    {
        AgendaController agendaController;
        public AdderOneEntry(AgendaController agendaController)
        {
            this.agendaController = agendaController;
        }
        public bool ExecuteTask(string entryText,string[] commandOptions =null)
        {
            Console.WriteLine("At executing add entry");
            return agendaController.AddEntry(entryText);
        }
    }
}
