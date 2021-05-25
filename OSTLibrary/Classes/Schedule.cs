using System;

namespace OSTLibrary.Classes
{
    [Serializable]
    public class Schedule
    {
        public int author;
        public int range;
        public string title;
        

        public Schedule(int author,int range, string title)
        {
            this.author = author;
            this.range = range;
            this.title = title;
        }
    }
}
