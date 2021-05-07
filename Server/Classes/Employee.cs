namespace Server.Classes
{
    public class Employee
    {
        public string num, password, name, rank, gender, phone, email, department, team;

        public Employee(string num)
            => this.num = num;
        public Employee(string num, string password, string name, string rank,
            string gender, string phone, string email, string department, string team)
        {
            this.num = num;
            this.password = password;
            this.name = name;
            this.rank = rank;
            this.gender = gender;
            this.phone = phone;
            this.email = email;
            this.department = department;
            this.team = team;
        }
    }
}
