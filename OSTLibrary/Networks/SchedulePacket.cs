using OSTLibrary.Classes;
using System;
using System.Collections.Generic;

namespace OSTLibrary.Networks
{
    [Serializable]
    public class SchedulePacket : Packet
    {
        public Schedule schedule;
        public List<Schedule> schedules;
        public Employee employee;

        //클라이언트 켰을 때 받게 하기위한 생성자
        public SchedulePacket(List<Schedule> schedules)
        {
            type = PacketType.Schedule;
            this.schedules = schedules;
        }

        //기본 생성자
        public SchedulePacket(Schedule schedule)
        {
            type = PacketType.Schedule;

            schedules = new List<Schedule>();
            schedules.Add(schedule);
        }
    }
}
