#nullable disable
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace XF.NET.Models;

public sealed class Node
{
    /// <summary>
    /// A list of breadcrumbs for this node, including the node_id, title, and node_type_id
    /// </summary>
    [JsonProperty("breadcrumbs")]
    public JArray Breadcrumbs { get; set; }     // TODO

    /// <summary>
    /// Data related to the specific node type this represents. Contents will vary significantly.
    /// </summary>
    [JsonProperty("type_data")]
    public object TypeData { get; set; }

    [JsonProperty("view_url")]
    public string ViewUrl { get; set; }

    [JsonProperty("node_id")]
    public int NodeId { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("node_name")]
    public string NodeName { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("node_type_id")]
    public string NodeTypeId { get; set; }

    [JsonProperty("parent_node_id")]
    public int ParentNodeId { get; set; }

    [JsonProperty("display_order")]
    public int DisplayOrder { get; set; }

    [JsonProperty("display_in_list")]
    public bool DisplayInList { get; set; }
}
