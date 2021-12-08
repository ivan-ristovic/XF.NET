#nullable disable
using Newtonsoft.Json;

namespace XF.NET.Models;

public sealed class LinkForum
{
    [JsonProperty("link_url")]
    public string LinkUrl { get; set; }

    [JsonProperty("redirect_count")]
    public int RedirectCount { get; set; }
}

