using BasicWebServer.Server.Common;
using BasicWebServer.Server.HTTP;
using BasicWebServer.Server.Responses;

namespace BasicWebServer.Server.Routing
{
    public class RoutingTable : IRoutingTable
    {
        private readonly Dictionary<Method, Dictionary<string, Response>> _routes;

        public RoutingTable()
        {
            this._routes = new Dictionary<Method, Dictionary<string, Response>>()
            {
                [Method.GET] = new Dictionary<string, Response>(),
                [Method.POST] = new Dictionary<string, Response>(),
                [Method.PUT] = new Dictionary<string, Response>(),
                [Method.DELETE] = new Dictionary<string, Response>()
            };
        }

        public IRoutingTable Map(string url, Method method, Response response)
        {
            switch (method)
            {
                case Method.GET:
                    this.MapGet(url, response);
                    break;
                case Method.POST:
                    this.MapPost(url, response);
                    break;
                default:
                    throw new InvalidOperationException($"Method '{method}' is not supported.");
            }

            return this;
        }

        public IRoutingTable MapGet(string url, Response response)
        {
            Guard.AgainstNull(url, nameof(url));
            Guard.AgainstNull(response, nameof(response));

            this._routes[Method.GET][url] = response;

            return this;
        }

        public IRoutingTable MapPost(string url, Response response)
        {
            Guard.AgainstNull(url, nameof(url));
            Guard.AgainstNull(response, nameof(response));

            this._routes[Method.POST][url] = response;

            return this;
        }

        public Response MatchRequest(Request request)
        {
            var requestMethod = request.Method;
            var requestUrl = request.Url;

            if (!this._routes.ContainsKey(requestMethod) || !this._routes[requestMethod].ContainsKey(requestUrl))
            {
                return new NotFoundResponse(); // 404
            }

            return this._routes[requestMethod][requestUrl];
        }
    }
}
