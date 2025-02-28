using BasicWebServer.Server.Common;

namespace BasicWebServer.Server.HTTP
{
    public class Header
    {
        public const string CONTENT_TYPE = "Content-Type";
        public const string CONTENT_LENGTH = "Content-Length";
        public const string DATE = "Date";
        public const string LOCATION = "Location";
        public const string SERVER = "Server";

        public Header(string name, string value)
        {
            Guard.AgainstNull(name, nameof(name));
            Guard.AgainstNull(value, nameof(value));
        }

        public string Name { get; init; }
        public string Value { get; set; }

        public override string ToString()
        {
            return $"{this.Name}: {this.Value}";
        }
    }
}
