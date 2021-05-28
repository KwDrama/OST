using System;
using System.Collections.Generic;

namespace OSTLibrary.Chats
{
    [Serializable]
    public class Room
    {
        public static string[] Scope = { "회사 전체", "본부 전체", "팀 전체", "개인" };

        public string id;
        public int scopeIdx;
        public string target;
        public List<Chat> chats;

        public Room(string id, int scopeIdx, string target)
        {
            this.id = id;
            this.scopeIdx = scopeIdx;
            this.target = target;
            chats = new List<Chat>();
        }
    }
}
