#nullable disable
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace XF.NET.Models;

public sealed class XFError
{
    [JsonProperty("code")]
    public string Code { get; set; }

    [JsonProperty("message")]
    public string Message { get; set; }

    [JsonProperty("params")]
    public JArray Params { get; set; }
}