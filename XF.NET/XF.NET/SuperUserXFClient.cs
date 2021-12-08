namespace XF.NET
{
    public sealed class SuperUserXFClient : XFClient
    {
        public SuperUserXFClient(Uri apiUrl, string apiKey) : base(apiUrl, apiKey)
        {
        }
    }
}
