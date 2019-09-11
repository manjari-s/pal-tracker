using System;

namespace PalTracker
{
    public class TimeEntry
    {
        
        public long? Id{get;set;}
        public long ProjectId{get;set;}
        public long UserId{get;set;}
        public int Hours{get;set;}
       public DateTime Date{get;set;}
        public TimeEntry(long projectId,long userId,DateTime date,int hours)
        {
            this.ProjectId= projectId;
            this.UserId= userId;
            this.Hours= hours;
            this.Date= date;
        }
        public TimeEntry(long? id,long projectId,long userId,DateTime date,int hours)
        {
             this.Id= id;
              this.ProjectId= projectId;
            this.UserId= userId;
            this.Hours= hours;
            this.Date= date;
        }
        public TimeEntry(){}

        public override bool Equals(object obj)
        {
            return obj is TimeEntry entry &&
                   Id == entry.Id &&
                   ProjectId == entry.ProjectId &&
                   UserId == entry.UserId &&
                   Hours == entry.Hours &&
                   Date == entry.Date;
        }
    }
}