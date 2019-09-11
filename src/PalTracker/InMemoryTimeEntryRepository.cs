using System;
using System.Linq;

using System.Collections;
using System.Collections.Generic;
namespace PalTracker
{
    public class InMemoryTimeEntryRepository : ITimeEntryRepository
    {
       List<TimeEntry> timeEntryList;

       public InMemoryTimeEntryRepository() => timeEntryList = new List<TimeEntry>();

        public TimeEntry Create(TimeEntry entry)
        {
            var ID = timeEntryList.Any()?(timeEntryList.Last().Id+1):1;
            //var ID=1;
            var newEntry = new TimeEntry(ID, entry.ProjectId, entry.UserId, entry.Date, entry.Hours);
            
            timeEntryList.Add(newEntry);          
             return timeEntryList.FirstOrDefault(e=>e.Id==ID);
        }
        public TimeEntry Find(long id){
            return timeEntryList.FirstOrDefault(e=>e.Id==id);
        }
        public bool Contains(long id){
             return timeEntryList.Any(e=>e.Id==id);
        }
        public IEnumerable<TimeEntry> List(){
            return timeEntryList;
        }
        public TimeEntry Update(long id, TimeEntry entry){
           var val=timeEntryList.FirstOrDefault(e=>e.Id==id); 
            val.ProjectId=entry.ProjectId;
            val.UserId=entry.UserId;
            val.Hours=entry.Hours;
            val.Date=entry.Date;           
           return timeEntryList.FirstOrDefault(e=>e.Id==id);
        }
        public bool Delete(long id){
            return timeEntryList.Remove(timeEntryList.FirstOrDefault(e=>e.Id==id));
        }
    }
}