using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BasicWebServer.Server.HTTP
{
    public class HeaderCollection
    {
        private readonly Dictionary<string, Header> _headers;

        public HeaderCollection()
        {
            this._headers = new Dictionary<string, Header>();
        }

        public int Count => this._headers.Count;

        public void Add(string name, string value)
        {
            Header header = new Header(name, value);
            this._headers.Add(name, header);
        }
    }
}
