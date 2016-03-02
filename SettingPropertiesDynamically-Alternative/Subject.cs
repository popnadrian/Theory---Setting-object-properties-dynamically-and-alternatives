using System;
using System.Collections.Generic;

namespace SettingPropertiesDynamically_Alternative
{
    public class Subject
    {
        private readonly List<DateTime> _items = new List<DateTime>();

        public IEnumerable<DateTime> Dates { get { return _items; } }
        
        public void AddEvent(DateTime eventDateTime)
        {
            _items.Add(eventDateTime);
        }
    }
}
