﻿using OSTNetwork;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace Client.Forms
{
    static class Program
    {
        public static TcpClient client;                                 // 서버와 연결된 TCP 소켓
        public static NetworkStream ns;                                 // 네트워크 스트림
        public static readonly string hostname = "127.0.0.1";           // 접속할 서버 주소
        public static readonly ushort port = 6756;                      // 접속할 서버 포트
        static byte[] sendBuffer;                                       // 송신 버퍼
        static byte[] readBuffer;                                       // 수신 버퍼
        public static Thread recvThread;                                // 서버로부터 수신을 대기하는 스레드
        public static int empNum = 0;                                   // 나의 사원 번호
        public static Dictionary<PacketType, Action<Packet>> callback;  // 타입에 따른 콜백 메소드
        public static FormMain formMain;                                // 적당한 폼 상호작용을 위한 메인폼

        [STAThread]
        static void Main()
        {
            client = new TcpClient();
            sendBuffer = new byte[Packet.BUFFER_SIZE];
            readBuffer = new byte[Packet.BUFFER_SIZE];
            recvThread = new Thread(new ThreadStart(Recieve));
            callback = new Dictionary<PacketType, Action<Packet>>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(formMain = new FormMain());
        }

        static void Recieve()
        {
            // 패킷 읽기
            try
            {
                ns.Read(readBuffer, 0, readBuffer.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show(formMain, ex.Message, "Recieve", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Array.Clear(readBuffer, 0, readBuffer.Length);
                return;
            }

            // 패킷 번역
            object pakcetObj = Packet.Deserialize(readBuffer);
            if (pakcetObj == null)
                return;
            Packet packet = pakcetObj as Packet;
            Array.Clear(readBuffer, 0, readBuffer.Length);

            // 패킷 타입에 따라 호출 가능한 콜백 메서드 실행
            if (packet.Type == PacketType.None)
            {
                MessageBox.Show(formMain, "PacketType is none", "Recieve", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (callback.ContainsKey(packet.Type))
                callback[packet.Type].Invoke(packet);
        }
        public static void Send(byte[] data)
        {
            data.CopyTo(sendBuffer, 0);
            ns.Write(sendBuffer, 0, sendBuffer.Length);
            ns.Flush();
        }
    }
}
