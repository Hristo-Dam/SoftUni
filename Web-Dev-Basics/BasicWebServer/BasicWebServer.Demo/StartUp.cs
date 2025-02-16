using BasicWebServer.Server;
using BasicWebServer.Server.HTTP;
using BasicWebServer.Server.Responses;

namespace BasicWebServer.Demo
{
    public class StartUp
    {
        private const string HTML_FORM = @"<form action='/HTML' method='POST'>
   Name: <input type='text' name='Name'/>
   Age: <input type='number' name ='Age'/>
<input type='submit' value ='Save' />
</form>";

        //private const string HTML_FORM = @"<form action='/HTML' method='POST'>
        //    Name: <input type='text' name='Name'/>
        //    Age: <input type='number' name='Age'/>
        //    <input type='submit' value ='Save' />
        //</form>";
        public static void Main()
        {
            HttpServer server = new HttpServer(routes => routes
                .MapGet("/", new TextResponse("Hello from the server!"))
                .MapGet("Redirect", new RedirectResponse("https://www.softuni.com"))
                .MapGet("/HTML", new HtmlResponse(StartUp.HTML_FORM))
                .MapPost("/HTML", new TextResponse("", StartUp.AddFormDataAction))
            );
            server.Start();
        }
        private static void AddFormDataAction(Request request, Response response)
        {
            response.Body = "";

            foreach (var (key, value) in request.Form)
            {
                response.Body += $"{key} - {value}";
                response.Body += Environment.NewLine;
            }
        }
    }
}
