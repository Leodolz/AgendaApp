using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaFrameworkApp
{
    class UserInterpreterDecorator:IUserClient
    {
        protected IUserClient decoratedClient;
        protected AgendaController agendaController;
        public UserInterpreterDecorator(IUserClient decoratedInterpreter)
        {
            this.decoratedClient = decoratedInterpreter;
            agendaController = GetAgendaController();
            AddValidcommand();
        }

        public void AddValidcommand(string commandName=null, ITaskOrder executableCommand=null)
        {
            decoratedClient.AddValidcommand("SEARCH ", new InterpreterOfSearch(agendaController));
        }
        public AgendaController GetAgendaController()
        {
            return decoratedClient.GetAgendaController();
        }

        public void ExecuteCommand(string userEntry)
        {
            decoratedClient.ExecuteCommand(userEntry);
        }
    }
}
