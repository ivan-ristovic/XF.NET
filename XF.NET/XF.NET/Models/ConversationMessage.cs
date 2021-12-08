#nullable disable
using Newtonsoft.Json;

namespace XF.NET.Models;

public sealed class ConversationMessage
{
    [JsonProperty("username")]
    public string Username { get; set; }

    /// <summary>
    /// If accessing as a user, true if this conversation message is unread
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

    [JsonProperty("can_react")]
    public bool CanReact { get; set; }

    [JsonProperty("view_url")]
    public string ViewUrl { get; set; }

    /// <summary>
    /// If requested by context, the conversation this message is part of.
    /// </summary>
    [JsonProperty("Conversation")]
    public Conversation Conversation { get; set; }

    /// <summary>
    /// If there are attachments to this message, a list of attachments.
    /// </summary>
    [JsonProperty("Attachments")]
    public Attachment[] Attachments { get; set; }

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

    [JsonProperty("message_id")]
    public int MessageId { get; set; }

    [JsonProperty("conversation_id")]
    public int ConversationId { get; set; }

    [JsonProperty("message_date")]
    public int MessageDate { get; set; }

    [JsonProperty("user_id")]
    public int UserId { get; set; }

    [JsonProperty("message")]
    public string Message { get; set; }

    [JsonProperty("attach_count")]
    public int AttachCount { get; set; }

    [JsonProperty("reaction_score")]
    public int ReactionScore { get; set; }

    [JsonProperty("User")]
    public User User { get; set; }
}

