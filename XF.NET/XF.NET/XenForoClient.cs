using XF.NET.Endpoints;

namespace XF.NET
{
    public abstract class XenForoClient
    {
        public static GuestXenForoClient CreateGuestClient(string apiKey) => new(apiKey);

        public static UserXenForoClient CreateUserClient(string apiKey, int userId) => new(apiKey, userId);

        public static SuperUserXenForoClient CreateSuperUserClient(string apiKey) => new(apiKey);

        private static readonly HttpClientHandler _handler = new() { AllowAutoRedirect = false };
        private static readonly HttpClient _http = new(_handler, true);

        private string ApiKey { get; }


        public XenForoClient(string apiKey)
        {
            this.ApiKey = apiKey;
            this.Users = new UsersEndpoint(_http, apiKey);
        }


        public readonly UsersEndpoint Users;
    }
}