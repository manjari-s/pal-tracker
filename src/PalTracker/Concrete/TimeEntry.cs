using System;

namespace PalTracker
{
    public class TimeEntry
    {
        
        public int id{get;set;}
        public int projectId{get;set;}
        public int userId{get;set;}
        public int hours{get;set;}
       public DateTime date{get;set;}
        public TimeEntry(int a,int b,DateTime date1,int c)
        {
            projectId=a;
            userId=b;
            hours=c;
            date=date1;
        }
        public TimeEntry(int a,int b,int d,DateTime date1,int c)
        {
             id=a;
              projectId=b;
            userId=d;
            hours=c;
            date=date1;
        }
        public TimeEntry(){}

        public override bool Equals(object obj)
        {
            return obj is TimeEntry entry &&
                   id == entry.id &&
                   projectId == entry.projectId &&
                   userId == entry.userId &&
                   hours == entry.hours &&
                   date == entry.date;
        }
    }
}