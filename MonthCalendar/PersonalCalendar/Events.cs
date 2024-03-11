using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChum
{
    public class Events
    {
        Dictionary<string, string> eventsDict;

        public Events()
        {
            eventsDict = new Dictionary<string, string>();
        }

        public void AddEvent(string date, string holiday)
        {
            eventsDict.Add(date, holiday);   
        }

        public string RetrieveEvent(string date)
        {
            if (eventsDict.ContainsKey(date))
            {
                return date + " - " + eventsDict[date];
            }
            return date;
        }
    }
}
