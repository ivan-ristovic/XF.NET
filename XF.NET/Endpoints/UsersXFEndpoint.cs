using XF.NET.Models;

namespace XF.NET.Endpoints;

public sealed class UsersXFEndpoint : XFEndpoint
{
    internal UsersXFEndpoint(Uri apiUrl, HttpClient client, string apiKey, int? asUserId)
        : base(apiUrl, "users/", client, apiKey, asUserId) { }


    public Task<XFUser> SearchByIdAsync(int id)
        => this.GetAndExtractPropertyAsync<XFUser>("user", id);
}
