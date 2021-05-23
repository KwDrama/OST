using System;
using System.Drawing;

namespace OSTLibrary.Classes
{
    [Serializable]
    public class Employee
    {
        public Image profile;
        public int id;
        public string password, name, phone, central, team, rank;

        public Employee(int id, string password)
        {
            this.id = id;
            this.password = password;
        }
        public Employee(Image profile, int empId, string password, string name,
            string phone, string central, string team, string rank)
        {
            this.profile = profile;
            this.id = empId;
            this.password = password;
            this.name = name;
            this.phone = phone;
            this.central = central;
            this.team = team;
            this.rank = rank;
        }
    }
}
