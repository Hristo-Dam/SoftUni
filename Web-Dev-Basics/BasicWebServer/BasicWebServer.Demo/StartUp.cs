using BasicWebServer.Server;

namespace BasicWebServer.Demo
{
    public class StartUp
    {
        public static void Main()
        {
            HttpServer server = new HttpServer("127.0.0.1", 8080);
            server.Start();
        }
    }
}
