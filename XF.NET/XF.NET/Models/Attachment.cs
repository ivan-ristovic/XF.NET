#nullable disable
using Newtonsoft.Json;

namespace XF.NET.Models;

public sealed class Attachment
{
    [JsonProperty("filename")]
    public string Filename { get; set; }

    [JsonProperty("file_size")]
    public int FileSize { get; set; }

    [JsonProperty("height")]
    public int Height { get; set; }

    [JsonProperty("width")]
    public int Width { get; set; }

    [JsonProperty("thumbnail_url")]
    public string ThumbnailUrl { get; set; }

    [JsonProperty("direct_url")]
    public string DirectUrl { get; set; }

    [JsonProperty("is_video")]
    public bool IsVideo { get; set; }

    [JsonProperty("is_audio")]
    public bool IsAudio { get; set; }

    [JsonProperty("attachment_id")]
    public int AttachmentId { get; set; }

    [JsonProperty("content_type")]
    public string ContentType { get; set; }

    [JsonProperty("content_id")]
    public int ContentId { get; set; }

    [JsonProperty("attach_date")]
    public int AttachDate { get; set; }

    [JsonProperty("view_count")]
    public int ViewCount { get; set; }
}

