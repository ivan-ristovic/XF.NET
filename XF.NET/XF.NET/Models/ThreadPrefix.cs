#nullable disable
using Newtonsoft.Json;

namespace XF.NET.Models;

public sealed class ThreadPrefix
{
    [JsonProperty("prefix_id")]
    public int PrefixId { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("usage_help")]
    public string UsageHelp { get; set; }

    /// <summary>
    /// True if the acting user can use (select) this prefix.
    /// </summary>
    [JsonProperty("is_usable")]
    public bool IsUsable { get; set; }

    [JsonProperty("prefix_group_id")]
    public int PrefixGroupId { get; set; }

    [JsonProperty("display_order")]
    public int DisplayOrder { get; set; }

    /// <summary>
    /// Effective order, taking group ordering into account.
    /// </summary>
    [JsonProperty("materialized_order")]
    public int MaterializedOrder { get; set; }
}

