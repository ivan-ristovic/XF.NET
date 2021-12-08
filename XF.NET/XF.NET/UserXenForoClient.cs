using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XF.NET
{
    public sealed class UserXenForoClient : XenForoClient
    {
        public UserXenForoClient(string apiKey, int userId) : base(apiKey)
        {
            this.UserId = userId;
        }

        public int UserId { get; }
    }
}
