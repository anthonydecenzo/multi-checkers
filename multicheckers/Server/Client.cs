using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace multicheckers.Server
{
    class Client
    {
        public Client() { }
        public Socket workSocket = null;

        public const int bufferSize = 1024;

        public byte[] buffer = new byte[bufferSize];

        public StringBuilder clientData = new StringBuilder();
    }
}
