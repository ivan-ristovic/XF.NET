using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XF.NET
{
    public sealed class SuperUserXenForoClient : XenForoClient
    {
        public SuperUserXenForoClient(string apiKey) : base(apiKey)
        {
        }
    }
}
