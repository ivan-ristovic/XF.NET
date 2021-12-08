namespace XF.NET.Endpoints
{
    public abstract class Endpoint
    {
        internal string Name { get; }
        internal string ApiKey { get; }
        internal HttpClient Client { get; }


        internal Endpoint(string name, HttpClient client, string apiKey)
        {
            this.Name = name;
            this.Client = client;
            this.ApiKey = apiKey;
        }
    }
}
