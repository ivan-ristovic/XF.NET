using XF.NET.Endpoints;

namespace XF.NET
{
    public abstract class XFClient
    {
        public static GuestXFClient CreateGuestClient(Uri apiUrl, string apiKey) => new(apiUrl, apiKey);

        public static UserXFClient CreateUserClient(Uri apiUrl, string apiKey, int userId) => new(apiUrl, apiKey, userId);

        public static SuperUserXFClient CreateSuperUserClient(Uri apiUrl, string apiKey) => new(apiUrl, apiKey);

        private static readonly HttpClientHandler _handler = new() { AllowAutoRedirect = false };
        private static readonly HttpClient _http = new(_handler, true);

        private Uri ApiUrl { get; }
        private string ApiKey { get; }


        public XFClient(Uri apiUrl, string apiKey, int? asUser)
        {
            if (!apiUrl.ToString().EndsWith('/'))
                apiUrl = new Uri(apiUrl.ToString() + "/");
            this.ApiUrl = apiUrl;
            this.ApiKey = apiKey;
            this.Users = new UsersXFEndpoint(this.ApiUrl, _http, this.ApiKey, asUser);
        }


        public readonly UsersXFEndpoint Users;
    }
}