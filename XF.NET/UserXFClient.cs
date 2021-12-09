namespace XF.NET
{
    public sealed class UserXFClient : XFClient
    {
        public UserXFClient(Uri apiUrl, string apiKey, int userId)
            : base(apiUrl, apiKey, userId) { }
    }
}
