using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Xml;

namespace PointDeSortie
{
    class SortieXML
    {
        public static void EnvoieXML(string IP, byte[] Send)
        {

            IPAddress host = IPAddress.Parse(IP);

            IPEndPoint hostep = new IPEndPoint(host, 5000);
            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                sock.Connect(hostep);
            }
            catch (SocketException e)
            {
                Console.WriteLine("Problem connecting to host");
                Console.WriteLine(e.ToString());
                sock.Close();
                return;
            }

            try
            {
                sock.Send(Send);
            }
            catch (SocketException e)
            {
                Console.WriteLine("Problem sending data");
                Console.WriteLine(e.ToString());
                sock.Close();
                return;
            }
            sock.Close();

        }
    }
}
