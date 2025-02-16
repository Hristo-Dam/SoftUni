using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace BasicWebServer.Server.HTTP
{
    public class HeaderCollection : IEnumerable<Header>
    {
        private readonly Dictionary<string, Header> _headers;

        public HeaderCollection()
        {
            this._headers = new Dictionary<string, Header>();
        }

        public string this[string name]
            => this._headers[name].Value;

        public int Count => this._headers.Count;

        public bool Contains(string name)
            => this._headers.ContainsKey(name);

        public void Add(string name, string value)
            => this._headers[name] = new Header(name, value);

        //public void Add(string name, string value)
        //{
        //    Header header = new Header(name, value);
        //    this._headers.Add(name, header);
        //}

        public IEnumerator<Header> GetEnumerator()
        {
            return this._headers.Values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
