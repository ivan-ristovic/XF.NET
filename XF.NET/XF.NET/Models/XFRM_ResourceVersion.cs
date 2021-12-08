#nullable disable
using Newtonsoft.Json;

namespace XF.NET.Models;

public sealed class XFRM_ResourceVersion
{
    [JsonProperty("resource_version_id")]
    public int ResourceVersionId { get; set; }

    [JsonProperty("resource_id")]
    public int ResourceId { get; set; }

    [JsonProperty("version_string")]
    public string VersionString { get; set; }

    [JsonProperty("release_date")]
    public int ReleaseDate { get; set; }

    [JsonProperty("download_count")]
    public int DownloadCount { get; set; }

    [JsonProperty("rating_count")]
    public int RatingCount { get; set; }

    [JsonProperty("version_state")]
    public string VersionState { get; set; }
}

