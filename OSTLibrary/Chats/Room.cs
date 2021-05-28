using System;

namespace OSTLibrary.Chats
{
    [Serializable]
    public class Room
    {
        public static string[] Range = { "회사 전체", "본부 전체", "팀 전체", "개인" };

        public string roomId;
        public int rangeIdx;
        public string target;

        public Room(string roomId, int rangeIdx, string target)
        {
            this.roomId = roomId;
            this.rangeIdx = rangeIdx;
            this.target = target;
        }
    }
}
