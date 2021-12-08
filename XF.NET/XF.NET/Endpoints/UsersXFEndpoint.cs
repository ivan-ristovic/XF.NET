using XF.NET.Models;

namespace XF.NET.Endpoints;

public sealed class UsersXFEndpoint : XFEndpoint
{
    internal UsersXFEndpoint(Uri apiUrl, HttpClient client, string apiKey) : base(apiUrl, "users/", client, apiKey)
    {
    }


    public Task<XFUser> SearchByIdAsync(int? asUser, int id) => this.GetAsync<XFUser>("user", asUser, id);
}
