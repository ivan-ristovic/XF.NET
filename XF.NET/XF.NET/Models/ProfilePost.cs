#nullable disable
using Newtonsoft.Json;

namespace XF.NET.Models;

public sealed class ProfilePost
{
    [JsonProperty("username")]
    public string Username { get; set; }

    /// <summary>
    /// HTML parsed version of the message contents.
    /// </summary>
    [JsonProperty("message_parsed")]
    public string MessageParsed { get; set; }

    [JsonProperty("can_edit")]
    public bool CanEdit { get; set; }

    [JsonProperty("can_soft_delete")]
    public bool CanSoftDelete { get; set; }

    [JsonProperty("can_hard_delete")]
    public bool CanHardDelete { get; set; }

    [JsonProperty("can_react")]
    public bool CanReact { get; set; }

    [JsonProperty("can_view_attachments")]
    public bool CanViewAttachments { get; set; }

    [JsonProperty("view_url")]
    public string ViewUrl { get; set; }

    /// <summary>
    /// If requested by context, the user this profile post was left for.
    /// </summary>
    [JsonProperty("ProfileUser")]
    public User Profileuser { get; set; }

    /// <summary>
    /// Attachments to this profile post, if it has any.
    /// </summary>
    [JsonProperty("Attachments")]
    public Attachment[] Attachments { get; set; }

    /// <summary>
    /// If requested, the most recent comments on this profile post.
    /// </summary>
    [JsonProperty("LatestComments")]
    public ProfilePostComment[] Latestcomments { get; set; }

    /// <summary>
    /// True if the viewing user has reacted to this content
    /// </summary>
    [JsonProperty("is_reacted_to")]
    public bool IsReactedTo { get; set; }

    /// <summary>
    /// If the viewer reacted, the ID of the reaction they used
    /// </summary>
    [JsonProperty("visitor_reaction_id")]
    public int VisitorReactionId { get; set; }

    [JsonProperty("profile_post_id")]
    public int ProfilePostId { get; set; }

    [JsonProperty("profile_user_id")]
    public int ProfileUserId { get; set; }

    [JsonProperty("user_id")]
    public int UserId { get; set; }

    [JsonProperty("post_date")]
    public int PostDate { get; set; }

    [JsonProperty("message")]
    public string Message { get; set; }

    [JsonProperty("message_state")]
    public string MessageState { get; set; }

    [JsonProperty("warning_message")]
    public string WarningMessage { get; set; }

    [JsonProperty("comment_count")]
    public int CommentCount { get; set; }

    [JsonProperty("first_comment_date")]
    public int FirstCommentDate { get; set; }

    [JsonProperty("last_comment_date")]
    public int LastCommentDate { get; set; }

    [JsonProperty("reaction_score")]
    public int ReactionScore { get; set; }

    [JsonProperty("User")]
    public User User { get; set; }
}

