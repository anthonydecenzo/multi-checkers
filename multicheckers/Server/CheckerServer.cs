using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using multicheckers.Server;

/// <summary>
/// The Server class serves as the host of the multiplayer checker game
/// by using asynchronous methods. As of right now, it grabs the ipv4 address 
/// of the machine running the server and allows the user to input a port.
/// </summary>
public class CheckerServer
    {

        // MRE is used to block and release threads manually.
        // Notifies one or more waiting threads that an event has occurred.
        public static ManualResetEvent allDone = new ManualResetEvent(false);
        private IPAddress ipAddress;
        private Int32 portNumber;
        private Socket serverSocket = null;
        private Boolean serverIsActive = false;

        public CheckerServer(Int32 portNumber) {
            this.portNumber = portNumber;
            setIpAddress();
        }

        // validates the ip address then sets the class variable
        private void setIpAddress()
        {
            IPAddress tempIPAddress = getIpAddress();

            if((tempIPAddress != null) && (tempIPAddress.ToString().Length != 0))
            {
            Console.WriteLine("Your IP: {0}", tempIPAddress.ToString()); 
                ipAddress = tempIPAddress;
            } 
        }

        // grabs the machine's DNS then grabs the IP Address
        private IPAddress getIpAddress()
        {
            for(int i = 0; i < Dns.GetHostEntry(Dns.GetHostName()).AddressList.Length; i++){
                Console.WriteLine("IP {0}: {1}", i, Dns.GetHostEntry(Dns.GetHostName()).AddressList[i]);
             }

            return Dns.GetHostEntry(Dns.GetHostName()).AddressList[0];
        }

        // checks if a port number is valid
        private Boolean isPortNumberValid()
        {
            return portNumber >= 1024 && portNumber <= 65535; 
        }

        // starts the server if it is not already running and has valid parameters
        public void startServer()
        {
            if(serverIsActive != true && isPortNumberValid())
            {
                Console.WriteLine("Starting Server..");
                IPEndPoint endPoint = new IPEndPoint(ipAddress, portNumber);

                serverSocket = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

                try
                {
                    // binds the socket to the specified ip address and port number
                    // then sets the limit of waiting connections to 2. 
                    serverSocket.Bind(endPoint);
                    serverSocket.Listen(2);


                    while (true)
                    {
                        allDone.Reset();

                        Console.WriteLine("Waiting for connection..");

                        // begin asynchronous socket to listen for connections
                        // calls the AcceptCallback method 
                        serverSocket.BeginAccept(new AsyncCallback(AcceptCallback), 
                            serverSocket);

                        allDone.WaitOne();
                    }

                } catch(Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        // grabs the async state and obtains necessary data to 
        // read data from the client's socket.
        public void AcceptCallback(IAsyncResult result)
        {
            allDone.Set();

            Socket clientListener = (Socket) result.AsyncState;
            Socket clientHandler = clientListener.EndAccept(result);

            Client client = new Client();
            client.workSocket = clientHandler;

           
            clientHandler.BeginReceive(client.buffer, 0, Client.bufferSize, 0, 
                new AsyncCallback(ReadCallback), client);
        }

        // reads the client's connection stream from the given
        // asynchronous client object
        public void ReadCallback(IAsyncResult result)
        {
            String streamContent = String.Empty;

            Client client = (Client) result.AsyncState;
            Socket clientSocket = client.workSocket;

            // these are the bytes from the client's socket stream
            int streamBytes = clientSocket.EndReceive(result);

            // checks if any data is inside and if somehow the socket 
            // stream surpassed 1024 bytes
            if(streamBytes > 0 && streamBytes <= 1024)
            {
                client.clientData.Append(Encoding.ASCII.GetString(client.buffer,
                    0, streamBytes));

                streamContent = client.clientData.ToString();

                // if the EOF tag is not read, continue to read data
                if(streamContent.IndexOf("<EOF>") > -1)
                {
                    Console.WriteLine("Read {0} bytes from socket. \n Data : {1}",
                        streamContent.Length, streamContent);
                } else
                {
                    clientSocket.BeginReceive(client.buffer, 0, 
                        Client.bufferSize, 0, new AsyncCallback(ReadCallback), client);
                }
            }

        } 

        // sends data to the client connected to server
        private void Send(Socket handler, String data)
        {
            // convert string to byte array
            byte[] byteData = Encoding.ASCII.GetBytes(data);

            handler.BeginSend(byteData, 0, byteData.Length, 0, 
                new AsyncCallback(SendCallback), handler);

        }

        private void SendCallback(IAsyncResult result)
        {
            try {
                Socket handler = (Socket)result.AsyncState;

                int bytesSent = handler.EndSend(result);

                Console.WriteLine("Sent {0} bytes to the client", bytesSent);

                handler.Shutdown(SocketShutdown.Both);
                handler.Close();

            } catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public Int32 Port
        {
            get { return portNumber; }
            set { portNumber = value; }
        }

    }

