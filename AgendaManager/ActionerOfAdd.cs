﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaManager
{
    public class ActionerOfAdd:ITaskOrder
    {
        private Dictionary<int, ITaskOrder> validAddCommands;
        readonly AgendaController agendaController;
        public ActionerOfAdd(AgendaController agendaController)
        {
            this.agendaController = agendaController;
            validAddCommands = new Dictionary<int, ITaskOrder>()
            {
                { 1,new AdderOneEntry(agendaController)}
            };
        }
        public bool ExecuteTask(string nullable, string[] commandEntry)
        {
            ITaskOrder agendaAddCommand = GetAddCommand(commandEntry.Length, agendaController);
            if (agendaAddCommand != null)
            {
                agendaAddCommand.ExecuteTask(commandEntry[0], commandEntry);
            }
            else return false;
            return true;
        }
        private ITaskOrder GetAddCommand(int commandName, AgendaController agendaClient)
        {
            if (validAddCommands.ContainsKey(commandName))
                return validAddCommands[commandName];
            else return null;
        }
        private void AddValidCommand(Dictionary<int, ITaskOrder> newCommands)
        {
            foreach(KeyValuePair<int,ITaskOrder> newCommand in newCommands)
            {
                validAddCommands.Add(newCommand.Key, newCommand.Value);
            }
        }
    }
}
