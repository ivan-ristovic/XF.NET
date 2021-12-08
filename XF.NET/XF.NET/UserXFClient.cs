using XF.NET.Endpoints;

namespace XF.NET
{
    public sealed class UserXFClient : XFClient
    {
        public int UserId { get; }

        public UserXFClient(Uri apiUrl, string apiKey, int userId) : base(apiUrl, apiKey)
        {
            this.UserId = userId;
            foreach (XFEndpoint endpoint in this.Endpoints)
                endpoint.AsUserId = this.UserId;
        }
    }
}
