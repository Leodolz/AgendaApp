using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaManager
{
    public interface ITaskOrder
    {
        bool ExecuteTask(string entryText, string[] optionCommands);
    }
}
