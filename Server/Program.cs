using System;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            // 매개 변수가 있을경우 그 번호를 포트로, 아닐 경우 기본 포트를 사용
            ushort port = 6756;
            if (args.Length > 0) ushort.TryParse(args[0], out port);

            Processor.Log = (string type, string empNum, string content) =>
                Console.WriteLine(string.Format("[{0}] {1} | {2} : {3}\n",
                    DateTime.Now.ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss"),
                    type, empNum, content));
            Processor.Instance.InitSocket(port);
        }
    }
}
