#nullable disable
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace XF.NET.Models;

public sealed class XFMG_Category
{
    [JsonProperty("category_id")]
    public int CategoryId { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("category_type")]
    public string CategoryType { get; set; }

    [JsonProperty("media_count")]
    public int MediaCount { get; set; }

    [JsonProperty("album_count")]
    public int AlbumCount { get; set; }

    [JsonProperty("comment_count")]
    public int CommentCount { get; set; }

    [JsonProperty("allowed_types")]
    public JArray AllowedTypes { get; set; }        // TODO

    [JsonProperty("min_tags")]
    public int MinTags { get; set; }

    [JsonProperty("category_index_limit")]
    public int CategoryIndexLimit { get; set; }

    [JsonProperty("parent_category_id")]
    public int ParentCategoryId { get; set; }

    [JsonProperty("display_order")]
    public int DisplayOrder { get; set; }
}

