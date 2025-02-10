using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Numerics;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BasicWebServer.Server
{
    public class HttpServer
    {
        private readonly IPAddress _ipAddress;
        private readonly int _port;
        private readonly TcpListener _serverListener;

        public HttpServer(string ipAddress, int port)
        {
            this._ipAddress = IPAddress.Parse(ipAddress);
            this._port = port;

            this._serverListener = new TcpListener(_ipAddress, _port);
        }

        public void Start()
        {
            this._serverListener.Start();
            Console.WriteLine($"Server started on port {this._port}.");
            Console.WriteLine("Listening for requests...");

            while (true)
            {
                var connection = _serverListener.AcceptTcpClient();

                var networkStream = connection.GetStream();

                var requestText = this.ReadRequest(networkStream);

                Console.WriteLine(requestText);

                WriteResponse(networkStream, "Hello from the server!");
                connection.Close();
            }
        }
        private void WriteResponse(NetworkStream networkStream, string message)
        {
            var contentLenth = Encoding.UTF8.GetByteCount(message);
            var response = $@"HTTP/1.1 200 OK
Content-Type: text/plain; charset=UTF-8
Content-Length: {contentLenth}

{message}";

            var responseBytes = Encoding.UTF8.GetBytes(response);
            networkStream.Write(responseBytes);
        }

        private string ReadRequest(NetworkStream networkStream)
        {
            var bufferLength = 1024;
            var buffer = new byte[bufferLength];

            var totalBytes = 0;

            var requestBuilder = new StringBuilder();

            do
            {
                var bytesRead = networkStream.Read(buffer, 0, bufferLength);

                totalBytes =+ bytesRead;

                if (totalBytes > 1024 * 10)
                {
                    throw new InvalidOperationException("Request is too large.");
                }

                requestBuilder.Append(Encoding.UTF8.GetString(buffer, 0, bytesRead));
            }
            //May not run ocrretly over Internet
            while (networkStream.DataAvailable);

            return requestBuilder.ToString();
        }
    }
}
