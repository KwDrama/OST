using OSTLibrary.Classes;
using System;
using System.Collections.Generic;

namespace OSTLibrary.Networks
{
    [Serializable]
    public class SchedulePacket : Packet
    {
        public List<Schedule> schedules;

        public SchedulePacket(List<Schedule> schedules)
        {
            type = PacketType.Schedule;
            this.schedules = schedules;
        }

        public SchedulePacket(Schedule schedule)
        {
            type = PacketType.Schedule;

            schedules = new List<Schedule>();
            schedules.Add(schedule);
        }
    }
}
