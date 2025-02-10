using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWebServer.Server.HTTP
{
    public class Response
    {
        public Response(StatusCode statusCode)
        {
            this.StatusCode = statusCode;

            this.Headers.Add("Server", "My Web Server");
            this.Headers.Add("Date", $"{DateTime.UtcNow:R}");
        }

        public StatusCode StatusCode { get; init; }

        public HeaderCollection Headers { get; init; } = new HeaderCollection();

        public string Body { get; set; }
    }
}
