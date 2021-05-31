using OSTLibrary.Classes;
using System;

namespace OSTLibrary.Chats
{
    [Serializable]
    public class Room
    {
        public static string[] Scope = { "회사 전체", "본부 전체", "팀 전체", "개인" };

        public string id;
        public int scopeIdx;
        public string target;

        public Chat lastChat;

        public Room(string id, int scopeIdx, string target, Chat lastChat = null)
        {
            this.id = id;
            this.scopeIdx = scopeIdx;
            this.target = target;
            this.lastChat = lastChat;
        }

        public int FindOtherEmployeeId(Employee myEmp)
        {
            if (scopeIdx != 3)
                return 0;

            string[] targetArr = target.Split(',');

            if (targetArr[0] == myEmp.id.ToString())
                return int.Parse(targetArr[1]);
            else
                return int.Parse(targetArr[0]);

        }
    }
}
