using AgendaManager;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaWinFormsApp
{
    class AgendaTableGenerator
    {
        public static DataTable GetDataTableAgenda(Dictionary<int, AgendaEntry> agendaToDisplay)
        {
            DataTable allAgendaEntries = new DataTable();
            InflateTableColumns(allAgendaEntries);
            InflateTableRows(allAgendaEntries, AgendaEntriesAsArrayList(agendaToDisplay));
            return allAgendaEntries;
        }
        private static void InflateTableColumns(DataTable agendaTable)
        {
            agendaTable.Columns.Add("ID", typeof(int));
            agendaTable.Columns.Add("Date", typeof(string));
            agendaTable.Columns.Add("Time", typeof(string));
            agendaTable.Columns.Add("Entry", typeof(string));
        }
        private static void InflateTableRows(DataTable agendaTable, ArrayList agendaEntries)
        {
            foreach (AgendaEntry entry in agendaEntries)
            {
                agendaTable.Rows.Add(entry.ID, entry.date, entry.time, entry.text);
            }
        }
        private static ArrayList AgendaEntriesAsArrayList(Dictionary<int, AgendaEntry> agendaToDisplay)
        {
            ArrayList agendaEntriesList = new ArrayList();
            foreach (AgendaEntry entry in agendaToDisplay.Values)
            {
                agendaEntriesList.Add(entry);
            }
            return agendaEntriesList;
        }
    }
}
