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
            AddUserValidCommand();
        }

        public void AddUserValidCommand(string commandName=null, IUserOrder executableCommand=null)
        {
            decoratedClient.AddUserValidCommand("SEARCH ", new InterpreterOfSearch(agendaController));
        }
        public AgendaController GetAgendaController()
        {
            return decoratedClient.GetAgendaController();
        }

        public void ParseUserCommand(string userEntry)
        {
            decoratedClient.ParseUserCommand(userEntry);
        }
    }
}
