﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaFrameworkApp
{
    class AdderOneEntry : ITaskOrder
    {
        AgendaController agendaController;
        public AdderOneEntry(AgendaController agendaController)
        {
            this.agendaController = agendaController;
        }
        public void ExecuteTask(string entryText)
        {
            agendaController.AddEntry(entryText);
        }
    }
}
