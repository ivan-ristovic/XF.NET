#nullable disable
using Newtonsoft.Json;

namespace XF.NET.Models;

public sealed class XFPage
{
    [JsonProperty("publish_date")]
    public int PublishDate { get; set; }

    [JsonProperty("view_count")]
    public int ViewCount { get; set; }
}

