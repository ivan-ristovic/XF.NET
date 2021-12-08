using System.Net;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using XF.NET.Models;

namespace XF.NET.Endpoints
{
    public abstract class XFEndpoint
    {
        private Uri EndpointUrl { get; }
        private string ApiKey { get; }
        private HttpClient Client { get; }
        
        internal int? AsUserId { get; set; }


        internal XFEndpoint(Uri apiUrl, string endpoint, HttpClient client, string apiKey)
        {
            this.EndpointUrl = new Uri(apiUrl, endpoint);
            this.ApiKey = apiKey;
            this.Client = client;
        }


        protected Uri JoinEndpointUrl(params object[] args)
            => new(this.EndpointUrl, string.Join("/", args.Select(arg => arg.ToString())));

        protected Task<T> GetAsync<T>(string prop, int? userId, params object[] args)
            => this.GetAsync<T>(prop, userId, this.JoinEndpointUrl(args));

        protected async Task<T> GetAsync<T>(string prop, int? userId, Uri url)
        {
            using var request = new HttpRequestMessage(HttpMethod.Get, url);

            request.Headers.Add("XF-Api-Key", this.ApiKey);
            userId ??= this.AsUserId;
            if (userId.HasValue)
                request.Headers.Add("XF-Api-User", userId.ToString());

            HttpResponseMessage response = await this.Client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            string json = await response.Content.ReadAsStringAsync();

            var deserialized = JObject.Parse(json);
            if (deserialized["errors"] is not null)
                throw new HttpRequestException(deserialized["errors"]?.ToObject<XFError>()?.Message);
            JToken token = deserialized[prop] 
                ?? throw new JsonSerializationException("Unexpected JSON string");
            return token.ToObject<T>() 
                ?? throw new JsonSerializationException("Failed to deserialize JSON response");
        }
    }
}
