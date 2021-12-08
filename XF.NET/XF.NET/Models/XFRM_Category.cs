#nullable disable
using Newtonsoft.Json;

namespace XF.NET.Models;

public sealed class XFRM_Category
{
    [JsonProperty("resource_category_id")]
    public int ResourceCategoryId { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("resource_count")]
    public int ResourceCount { get; set; }

    [JsonProperty("last_update")]
    public int LastUpdate { get; set; }

    [JsonProperty("last_resource_title")]
    public string LastResourceTitle { get; set; }

    [JsonProperty("last_resource_id")]
    public int LastResourceId { get; set; }

    [JsonProperty("allow_local")]
    public bool AllowLocal { get; set; }

    [JsonProperty("allow_external")]
    public bool AllowExternal { get; set; }

    [JsonProperty("allow_commercial_external")]
    public bool AllowCommercialExternal { get; set; }

    [JsonProperty("allow_fileless")]
    public bool AllowFileless { get; set; }

    [JsonProperty("min_tags")]
    public int MinTags { get; set; }

    [JsonProperty("enable_versioning")]
    public bool EnableVersioning { get; set; }

    [JsonProperty("enable_support_url")]
    public bool EnableSupportUrl { get; set; }

    [JsonProperty("parent_category_id")]
    public int ParentCategoryId { get; set; }

    [JsonProperty("display_order")]
    public int DisplayOrder { get; set; }
}

