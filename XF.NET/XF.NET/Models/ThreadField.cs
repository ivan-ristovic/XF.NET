#nullable disable
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace XF.NET.Models;

public sealed class ThreadField
{
    [JsonProperty("field_id")]
    public string FieldId { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("display_order")]
    public int DisplayOrder { get; set; }

    [JsonProperty("field_type")]
    public string FieldType { get; set; }

    /// <summary>
    /// For choice types, an ordered list of choices, with "option" and "name" keys for each.
    /// </summary>
    [JsonProperty("field_choices")]
    public object FieldChoices { get; set; }

    [JsonProperty("match_type")]
    public string MatchType { get; set; }

    [JsonProperty("match_params")]
    public JArray MatchParams { get; set; }         // TODO

    [JsonProperty("max_length")]
    public int MaxLength { get; set; }

    [JsonProperty("required")]
    public bool Required { get; set; }

    /// <summary>
    /// If this field type supports grouping, the group this field belongs to.
    /// </summary>
    [JsonProperty("display_group")]
    public string DisplayGroup { get; set; }
}

