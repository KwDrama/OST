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
        public string scope;
        public string contents;
        public string target;

        public Schedule(int author, string title, DateTime start, DateTime end,string scope, string contents, string target)
        {
            this.author = author;
            this.title = title;
            this.start = start;
            this.end = end;
            this.scope = scope;
            this.contents = contents;
            this.target = target;
        }
    }
}
