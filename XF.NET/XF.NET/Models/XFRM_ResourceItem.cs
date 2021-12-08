#nullable disable
using Newtonsoft.Json;

namespace XF.NET.Models;

public sealed class XFRM_ResourceItem
{
    [JsonProperty("resource_id")]
    public int ResourceId { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("tag_line")]
    public string TagLine { get; set; }

    [JsonProperty("user_id")]
    public int UserId { get; set; }

    [JsonProperty("resource_state")]
    public string ResourceState { get; set; }

    [JsonProperty("resource_type")]
    public string ResourceType { get; set; }

    [JsonProperty("resource_date")]
    public int ResourceDate { get; set; }

    [JsonProperty("resource_category_id")]
    public int ResourceCategoryId { get; set; }

    [JsonProperty("external_url")]
    public string ExternalUrl { get; set; }

    [JsonProperty("price")]
    public float Price { get; set; }

    [JsonProperty("currency")]
    public string Currency { get; set; }

    [JsonProperty("view_count")]
    public int ViewCount { get; set; }

    [JsonProperty("download_count")]
    public int DownloadCount { get; set; }

    [JsonProperty("rating_count")]
    public int RatingCount { get; set; }

    [JsonProperty("rating_avg")]
    public float RatingAvg { get; set; }

    [JsonProperty("rating_weighted")]
    public float RatingWeighted { get; set; }

    [JsonProperty("last_update")]
    public int LastUpdate { get; set; }

    [JsonProperty("alt_support_url")]
    public string AltSupportUrl { get; set; }

    [JsonProperty("prefix_id")]
    public int PrefixId { get; set; }

    [JsonProperty("Category")]
    public XFRM_Category Category { get; set; }

    [JsonProperty("User")]
    public User User { get; set; }
}

