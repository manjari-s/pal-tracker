using System;
using System.Linq;
using System.Collections;

using System.Collections.Generic;
namespace PalTracker
{
    public interface ITimeEntryRepository
    {
        TimeEntry Create(TimeEntry entry);
        TimeEntry Find(long id);
        bool Contains(long id);
        IEnumerable<TimeEntry> List();
        TimeEntry Update(long id, TimeEntry entry);
        bool Delete(long id);
    }
}