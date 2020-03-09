﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaFrameworkApp;

namespace AgendaWinFormsApp
{
    class ActionerOfFilter : ITaskOrder
    {
        private const int FILTER_BY_DATE = 1;
        private const int FILTER_BY_TEXT = 2;
        public static int FilteringCode;
        readonly AgendaController agendaController;
        public ActionerOfFilter(AgendaController agendaController)
        {
            this.agendaController = agendaController;
        }
        public void ExecuteTask(string filteringOption)
        {
            IAgendaFilterer agendaFilterer = GetAgendaFilterer(agendaController);
            FormHome.AgendaToDisplay = agendaFilterer.GetFilteredAgenda(filteringOption);
        }
        private IAgendaFilterer GetAgendaFilterer(AgendaController agendaController)
        {
            switch (FilteringCode)
            {
                case FILTER_BY_DATE:
                    return new DateFilterer(agendaController);
                case FILTER_BY_TEXT:
                    return new TextFilterer(agendaController);
                default:
                    return null;
            }
        }
    }
}
