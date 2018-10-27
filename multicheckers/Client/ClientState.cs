using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace multicheckers.Client
{
    class ClientState
    {
        public Socket workSocket = null;

        public const int bufferSize = 256;

        public byte[] buffer = new byte[bufferSize];

        public StringBuilder streamData = new StringBuilder();
    }
}
