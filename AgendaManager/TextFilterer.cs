using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaManager
{
    public static class TextFilterer
    {
        public static ArrayList FilterByText(string filteringText, Dictionary<int, AgendaEntry> userAgenda)
        {
            ArrayList filteredEntryList = new ArrayList();
            foreach (KeyValuePair<int, AgendaEntry> agendaEntry in userAgenda)
            {
                if (agendaEntry.Value.text.Contains(filteringText))
                    filteredEntryList.Add(agendaEntry.Value);
            }
            return SortByDate(filteredEntryList);

        }
        private static ArrayList SortByDate(ArrayList entryList)
        {
            entryList.Sort(new CustomDateComparer());
            return entryList;
        }
    }
}
