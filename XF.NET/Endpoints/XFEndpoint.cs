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
        
        public int? AsUserId { get; set; }


        internal XFEndpoint(Uri apiUrl, string endpoint, HttpClient client, string apiKey, int? asUserId)
        {
            this.EndpointUrl = new Uri(apiUrl, endpoint);
            this.ApiKey = apiKey;
            this.Client = client;
            this.AsUserId = asUserId;
        }
        

        protected Uri JoinEndpointUrl(params object[] args)
            => new(this.EndpointUrl, string.Join("/", args.Select(arg => arg.ToString())));

        protected Task<T> GetAsync<T>(params object[] args)
            => this.GetAsync<T>(this.JoinEndpointUrl(args));

        protected async Task<T> GetAsync<T>(Uri url)
        {
            string json = await this.GetJsonAsync(url);
            return JsonConvert.DeserializeObject<T>(json)
                ?? throw new JsonSerializationException("Failed to deserialize JSON response");
        }

        protected Task<T> GetAndExtractPropertyAsync<T>(string prop, params object[] args)
            => this.GetAndExtractPropertyAsync<T>(prop, this.JoinEndpointUrl(args));

        protected async Task<T> GetAndExtractPropertyAsync<T>(string prop, Uri url)
        {
            string json = await this.GetJsonAsync(url);
            JToken token = JObject.Parse(json)[prop]
                ?? throw new JsonSerializationException($"Failed to find property {prop} in the JSON response");
            return token.ToObject<T>()
                ?? throw new JsonSerializationException("Failed to deserialize JSON response");
        }

        private async Task<string> GetJsonAsync(Uri url)
        {
            using var request = new HttpRequestMessage(HttpMethod.Get, url);

            request.Headers.Add("XF-Api-Key", this.ApiKey);
            if (this.AsUserId.HasValue)
                request.Headers.Add("XF-Api-User", this.AsUserId.ToString());

            HttpResponseMessage response = await this.Client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            string json = await response.Content.ReadAsStringAsync();

            var deserialized = JObject.Parse(json);
            if (deserialized["errors"] is not null)
                throw new HttpRequestException(deserialized["errors"]?.ToObject<XFError>()?.Message);

            return json;
        }
    }
}
