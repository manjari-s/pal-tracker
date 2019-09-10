using System;
using System.Linq;
using System.Collections;

using System.Collections.Generic;
namespace PalTracker
{
    public interface ITimeEntryRepository
    {
        TimeEntry Create(TimeEntry entry);
        TimeEntry Find(int id);
        bool Contains(int id);
        List<TimeEntry> List();
        TimeEntry Update(int id, TimeEntry entry);
        bool Delete(int id);
    }
}