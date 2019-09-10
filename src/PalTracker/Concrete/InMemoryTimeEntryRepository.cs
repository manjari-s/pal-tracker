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
            var ID = timeEntryList.Any()?(timeEntryList.Last().id+1):1;
            //var ID=1;
            var newEntry = new TimeEntry(ID, entry.projectId, entry.userId, entry.date, entry.hours);
            
            timeEntryList.Add(newEntry);          
             return timeEntryList.FirstOrDefault(e=>e.id==ID);
        }
        public TimeEntry Find(int id){
            return timeEntryList.FirstOrDefault(e=>e.id==id);
        }
        public bool Contains(int id){
             return timeEntryList.Any(e=>e.id==id);
        }
        public List<TimeEntry> List(){
            return timeEntryList;
        }
        public TimeEntry Update(int id, TimeEntry entry){
           var val=timeEntryList.FirstOrDefault(e=>e.id==id); 
            val.projectId=entry.projectId;
            val.userId=entry.userId;
            val.hours=entry.hours;
            val.date=entry.date;           
           return timeEntryList.FirstOrDefault(e=>e.id==id);
        }
        public bool Delete(int id){
            return timeEntryList.Remove(timeEntryList.FirstOrDefault(e=>e.id==id));
        }
    }
}