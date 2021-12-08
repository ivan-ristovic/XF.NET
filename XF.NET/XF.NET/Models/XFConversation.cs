#nullable disable
using Newtonsoft.Json;

namespace XF.NET.Models;

public sealed class XFConversation
{
    /// <summary>
    /// Name of the user that started the conversation
    /// </summary>
    [JsonProperty("username")]
    public string Username { get; set; }

    /// <summary>
    /// Key-value pair of recipient user IDs and names
    /// </summary>
    [JsonProperty("recipients")]
    public object Recipients { get; set; }

    /// <summary>
    /// True if the viewing user starred the conversation
    /// </summary>
    [JsonProperty("is_starred")]
    public bool IsStarred { get; set; }

    /// <summary>
    /// If accessing as a user, true if this conversation is unread
    /// </summary>
    [JsonProperty("is_unread")]
    public bool IsUnread { get; set; }

    [JsonProperty("can_edit")]
    public bool CanEdit { get; set; }

    [JsonProperty("can_reply")]
    public bool CanReply { get; set; }

    [JsonProperty("can_invite")]
    public bool CanInvite { get; set; }

    [JsonProperty("can_upload_attachment")]
    public bool CanUploadAttachment { get; set; }

    [JsonProperty("view_url")]
    public string ViewUrl { get; set; }

    [JsonProperty("conversation_id")]
    public int ConversationId { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("user_id")]
    public int UserId { get; set; }

    [JsonProperty("start_date")]
    public int StartDate { get; set; }

    [JsonProperty("open_invite")]
    public bool OpenInvite { get; set; }

    [JsonProperty("conversation_open")]
    public bool ConversationOpen { get; set; }

    [JsonProperty("reply_count")]
    public int ReplyCount { get; set; }

    [JsonProperty("recipient_count")]
    public int RecipientCount { get; set; }

    [JsonProperty("first_message_id")]
    public int FirstMessageId { get; set; }

    [JsonProperty("last_message_date")]
    public int LastMessageDate { get; set; }

    [JsonProperty("last_message_id")]
    public int LastMessageId { get; set; }

    [JsonProperty("last_message_user_id")]
    public int LastMessageUserId { get; set; }

    [JsonProperty("Starter")]
    public XFUser Starter { get; set; }
}

