using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XF.NET.Endpoints;

public sealed class UsersEndpoint : Endpoint
{
    internal UsersEndpoint(HttpClient client, string apiKey) : base("users", client, apiKey)
    {
    }


}
