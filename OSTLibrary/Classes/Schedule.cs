using System;

namespace OSTLibrary.Classes
{
    [Serializable]
    public class Schedule
    {
        public string department = null, team = null, num = null;
        public int start_year, start_month, start_day;
        public int end_year, end_month, end_day;

        public Schedule(string department, string team, string num,
            int start_year, int start_month, int start_day,
            int end_year, int end_month, int end_day)
        {
            this.department = department;
            this.team = team;
            this.num = num;
            this.start_year = start_year;
            this.start_month = start_month;
            this.start_day = start_day;
            this.end_year = end_year;
            this.end_month = end_month;
            this.end_day = end_day;
        }
    }
}
