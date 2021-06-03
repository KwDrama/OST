using System;
namespace OSTLibrary.Classes
{
    [Serializable]
    public class Schedule
    {
        public int author;
        public string title;
        public DateTime start;
        public DateTime end;
        public string range;
        public string contents;



        public Schedule(int author, string title, DateTime start, DateTime end,string range, string contents)
        {
            this.author = author;
            this.title = title;
            this.start = start;
            this.end = end;
            this.range = range;
            this.contents = contents;
        }
    }
}
