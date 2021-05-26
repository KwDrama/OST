using System;
using MySql.Data.Types;
namespace OSTLibrary.Classes
{
    [Serializable]
    public class Schedule
    {
        public int author;
        public string title;
        public MySqlDateTime start;
        public MySqlDateTime end;
        public int range;
        public string contents;



        public Schedule(int author, string title, MySqlDateTime start, MySqlDateTime end,int range, string contents)
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
