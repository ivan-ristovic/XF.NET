#nullable disable
using Newtonsoft.Json;

namespace XF.NET.Models;

public sealed class XFMG_MediaItem
{
    [JsonProperty("media_id")]
    public int MediaId { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("media_date")]
    public int MediaDate { get; set; }

    [JsonProperty("last_edit_date")]
    public int LastEditDate { get; set; }

    [JsonProperty("media_type")]
    public string MediaType { get; set; }

    [JsonProperty("media_state")]
    public string MediaState { get; set; }

    [JsonProperty("album_id")]
    public int AlbumId { get; set; }

    [JsonProperty("category_id")]
    public int CategoryId { get; set; }

    [JsonProperty("user_id")]
    public int UserId { get; set; }

    [JsonProperty("view_count")]
    public int ViewCount { get; set; }

    [JsonProperty("warning_message")]
    public string WarningMessage { get; set; }

    [JsonProperty("last_comment_date")]
    public int LastCommentDate { get; set; }

    [JsonProperty("last_comment_id")]
    public int LastCommentId { get; set; }

    [JsonProperty("last_comment_user_id")]
    public int LastCommentUserId { get; set; }

    [JsonProperty("last_comment_username")]
    public string LastCommentUsername { get; set; }

    [JsonProperty("comment_count")]
    public int CommentCount { get; set; }

    [JsonProperty("rating_count")]
    public int RatingCount { get; set; }

    [JsonProperty("rating_avg")]
    public float RatingAvg { get; set; }

    [JsonProperty("rating_weighted")]
    public float RatingWeighted { get; set; }

    [JsonProperty("reaction_score")]
    public int ReactionScore { get; set; }

    [JsonProperty("User")]
    public User User { get; set; }
}

