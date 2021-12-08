using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XF.NET
{
    public sealed class GuestXenForoClient : XenForoClient
    {
        public GuestXenForoClient(string apiKey) : base(apiKey)
        {
        }
    }
}
