#nullable disable
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace XF.NET.Models;

public sealed class XFThread
{
    [JsonProperty("username")]
    public string Username { get; set; }

    /// <summary>
    /// If accessing as a user, true if they are watching this thread
    /// </summary>
    [JsonProperty("is_watching")]
    public bool IsWatching { get; set; }

    /// <summary>
    /// If accessing as a user, the number of posts they have made in this thread
    /// </summary>
    [JsonProperty("visitor_post_count")]
    public int VisitorPostCount { get; set; }

    /// <summary>
    /// If accessing as a user, true if this thread is unread
    /// </summary>
    [JsonProperty("is_unread")]
    public bool IsUnread { get; set; }

    /// <summary>
    /// Key-value pairs of custom field values for this thread
    /// </summary>
    [JsonProperty("custom_fields")]
    public object CustomFields { get; set; }

    [JsonProperty("tags")]
    public JArray Tags { get; set; }            // TODO

    /// <summary>
    /// Present if this thread has a prefix. Printable name of the prefix.
    /// </summary>
    [JsonProperty("prefix")]
    public string Prefix { get; set; }

    [JsonProperty("can_edit")]
    public bool CanEdit { get; set; }

    [JsonProperty("can_edit_tags")]
    public bool CanEditTags { get; set; }

    [JsonProperty("can_reply")]
    public bool CanReply { get; set; }

    [JsonProperty("can_soft_delete")]
    public bool CanSoftDelete { get; set; }

    [JsonProperty("can_hard_delete")]
    public bool CanHardDelete { get; set; }

    [JsonProperty("can_view_attachments")]
    public bool CanViewAttachments { get; set; }

    [JsonProperty("view_url")]
    public string ViewUrl { get; set; }

    [JsonProperty("is_first_post_pinned")]
    public bool IsFirstPostPinned { get; set; }

    [JsonProperty("highlighted_post_ids")]
    public JArray HighlightedPostIds { get; set; }      // TODO

    /// <summary>
    /// If requested by context, the forum this thread was posted in.
    /// </summary>
    [JsonProperty("Forum")]
    public XFNode Forum { get; set; }

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

    [JsonProperty("thread_id")]
    public int ThreadId { get; set; }

    [JsonProperty("node_id")]
    public int NodeId { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("reply_count")]
    public int ReplyCount { get; set; }

    [JsonProperty("view_count")]
    public int ViewCount { get; set; }

    [JsonProperty("user_id")]
    public int UserId { get; set; }

    [JsonProperty("post_date")]
    public int PostDate { get; set; }

    [JsonProperty("sticky")]
    public bool Sticky { get; set; }

    [JsonProperty("discussion_state")]
    public string DiscussionState { get; set; }

    [JsonProperty("discussion_open")]
    public bool DiscussionOpen { get; set; }

    [JsonProperty("discussion_type")]
    public string DiscussionType { get; set; }

    [JsonProperty("first_post_id")]
    public int FirstPostId { get; set; }

    [JsonProperty("last_post_date")]
    public int LastPostDate { get; set; }

    [JsonProperty("last_post_id")]
    public int LastPostId { get; set; }

    [JsonProperty("last_post_user_id")]
    public int LastPostUserId { get; set; }

    [JsonProperty("last_post_username")]
    public string LastPostUsername { get; set; }

    [JsonProperty("first_post_reaction_score")]
    public int FirstPostReactionScore { get; set; }

    [JsonProperty("prefix_id")]
    public int PrefixId { get; set; }

    [JsonProperty("User")]
    public XFUser User { get; set; }
}

