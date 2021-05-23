using System;
using System.Drawing;

namespace OSTLibrary.Networks
{
    [Serializable]
    public class RegisterPacket : Packet
    {
        public bool success = false;
        public string result;

        public Image profile;
        public int empId;
        public string password, name, phone, central, team, rank;

        public RegisterPacket(bool success, string result = "")
        {
            type = PacketType.Register;
            this.success = success;
            this.result = result;
        }

        public RegisterPacket(Image profile, int empId, string password,
            string name, string phone, string central, string team, string rank)
        {
            type = PacketType.Register;
            this.profile = profile;
            this.empId = empId;
            this.password = password;
            this.name = name;
            this.phone = phone;
            this.central = central;
            this.team = team;
            this.rank = rank;
        }
    }
}
