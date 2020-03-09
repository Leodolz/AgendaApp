using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaFrameworkApp
{
    public class UserClientDecorator:IUserClient
    {
        protected IUserClient decoratedClient;
        protected AgendaController agendaController;
        public UserClientDecorator(IUserClient decoratedInterpreter)
        {
            this.decoratedClient = decoratedInterpreter;
            agendaController = GetAgendaController();
            AddValidCommand();
        }

        public void AddValidCommand(string commandName=null, ITaskOrder executableCommand=null)
        {
            if(commandName !=null && executableCommand != null)
                decoratedClient.AddValidCommand(commandName, executableCommand);
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
