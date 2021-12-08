#nullable disable
using Newtonsoft.Json;

namespace XF.NET.Models;

public sealed class Forum
{
    [JsonProperty("forum_type_id")]
    public string ForumTypeId { get; set; }

    [JsonProperty("allow_posting")]
    public bool AllowPosting { get; set; }

    [JsonProperty("require_prefix")]
    public bool RequirePrefix { get; set; }

    [JsonProperty("min_tags")]
    public int MinTags { get; set; }
}

