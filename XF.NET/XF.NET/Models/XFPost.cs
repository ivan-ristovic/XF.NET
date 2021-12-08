#nullable disable
using Newtonsoft.Json;

namespace XF.NET.Models;

public sealed class XFPost
{
    [JsonProperty("username")]
    public string Username { get; set; }

    [JsonProperty("is_first_post")]
    public bool IsFirstPost { get; set; }

    [JsonProperty("is_last_post")]
    public bool IsLastPost { get; set; }

    /// <summary>
    /// If accessing as a user, true if this post is unread
    /// </summary>
    [JsonProperty("is_unread")]
    public bool IsUnread { get; set; }

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
    /// If requested by context, the thread this post is part of.
    /// </summary>
    [JsonProperty("Thread")]
    public XFThread Thread { get; set; }

    /// <summary>
    /// Attachments to this post, if it has any.
    /// </summary>
    [JsonProperty("Attachments")]
    public XFAttachment[] Attachments { get; set; }

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

    /// <summary>
    /// The content's vote score (if supported)
    /// </summary>
    [JsonProperty("vote_score")]
    public int VoteScore { get; set; }

    /// <summary>
    /// True if the viewing user can vote on this content
    /// </summary>
    [JsonProperty("can_content_vote")]
    public bool CanContentVote { get; set; }

    /// <summary>
    /// List of content vote types allowed on this content
    /// </summary>
    [JsonProperty("allowed_content_vote_types")]
    public string[] AllowedContentVoteTypes { get; set; }

    /// <summary>
    /// True if the viewing user has voted on this content
    /// </summary>
    [JsonProperty("is_content_voted")]
    public bool IsContentVoted { get; set; }

    /// <summary>
    /// If the viewer reacted, the vote they case (up/down)
    /// </summary>
    [JsonProperty("visitor_content_vote")]
    public string VisitorContentVote { get; set; }

    [JsonProperty("post_id")]
    public int PostId { get; set; }

    [JsonProperty("thread_id")]
    public int ThreadId { get; set; }

    [JsonProperty("user_id")]
    public int UserId { get; set; }

    [JsonProperty("post_date")]
    public int PostDate { get; set; }

    [JsonProperty("message")]
    public string Message { get; set; }

    [JsonProperty("message_state")]
    public string MessageState { get; set; }

    [JsonProperty("attach_count")]
    public int AttachCount { get; set; }

    [JsonProperty("warning_message")]
    public string WarningMessage { get; set; }

    [JsonProperty("position")]
    public int Position { get; set; }

    [JsonProperty("last_edit_date")]
    public int LastEditDate { get; set; }

    [JsonProperty("reaction_score")]
    public int ReactionScore { get; set; }

    [JsonProperty("User")]
    public XFUser User { get; set; }
}

