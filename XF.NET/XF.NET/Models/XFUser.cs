#nullable disable
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace XF.NET.Models;

/// <summary>
/// Information about the user. Different information will be included based on permissions and verbosity.
/// </summary>
public sealed class XFUser
{
    [JsonProperty("about")]
    public string About { get; set; }

    [JsonProperty("activity_visible")]
    public bool ActivityVisible { get; set; }

    /// <summary>
    /// The user's current age. Only included if available.
    /// </summary>
    [JsonProperty("age")]
    public int Age { get; set; }

    [JsonProperty("alert_optout")]
    public JArray AlertOptout { get; set; }         // TODO

    [JsonProperty("allow_post_profile")]
    public string AllowPostProfile { get; set; }

    [JsonProperty("allow_receive_news_feed")]
    public string AllowReceiveNewsFeed { get; set; }

    [JsonProperty("allow_send_personal_conversation")]
    public string AllowSendPersonalConversation { get; set; }

    [JsonProperty("allow_view_identities")]
    public string AllowViewIdentities { get; set; }

    [JsonProperty("allow_view_profile")]
    public string AllowViewProfile { get; set; }

    /// <summary>
    /// Maps from size types to URL.
    /// </summary>
    [JsonProperty("avatar_urls")]
    public JObject AvatarUrls { get; set; }         // TODO

    /// <summary>
    /// Maps from size types to URL.
    /// </summary>
    [JsonProperty("profile_banner_urls")]
    public JObject ProfileBannerUrls { get; set; }          // TODO

    [JsonProperty("can_ban")]
    public bool CanBan { get; set; }

    [JsonProperty("can_converse")]
    public bool CanConverse { get; set; }

    [JsonProperty("can_edit")]
    public bool CanEdit { get; set; }

    [JsonProperty("can_follow")]
    public bool CanFollow { get; set; }

    [JsonProperty("can_ignore")]
    public bool CanIgnore { get; set; }

    [JsonProperty("can_post_profile")]
    public bool CanPostProfile { get; set; }

    [JsonProperty("can_view_profile")]
    public bool CanViewProfile { get; set; }

    [JsonProperty("can_view_profile_posts")]
    public bool CanViewProfilePosts { get; set; }

    [JsonProperty("can_warn")]
    public bool CanWarn { get; set; }

    [JsonProperty("content_show_signature")]
    public bool ContentShowSignature { get; set; }

    [JsonProperty("creation_watch_state")]
    public string CreationWatchState { get; set; }

    /// <summary>
    /// Map of custom field keys and values.
    /// </summary>
    [JsonProperty("custom_fields")]
    public JObject CustomFields { get; set; }           // TODO

    /// <summary>
    /// Will have a value if a custom title has been specifically set; prefer user_title instead.
    /// </summary>
    [JsonProperty("custom_title")]
    public string CustomTitle { get; set; }

    /// <summary>
    /// Date of birth with year, month and day keys.
    /// </summary>
    [JsonProperty("dob")]
    public JObject Dob { get; set; }            // TODO

    [JsonProperty("email")]
    public string Email { get; set; }

    [JsonProperty("email_on_conversation")]
    public bool EmailOnConversation { get; set; }

    [JsonProperty("gravatar")]
    public string Gravatar { get; set; }

    [JsonProperty("interaction_watch_state")]
    public bool InteractionWatchState { get; set; }

    [JsonProperty("is_admin")]
    public bool IsAdmin { get; set; }

    [JsonProperty("is_banned")]
    public bool IsBanned { get; set; }

    [JsonProperty("is_discouraged")]
    public bool IsDiscouraged { get; set; }

    /// <summary>
    /// True if the visitor is following this user. Only included if visitor is not a guest.
    /// </summary>
    [JsonProperty("is_followed")]
    public bool IsFollowed { get; set; }

    /// <summary>
    /// True if the visitor is ignoring this user. Only included if visitor is not a guest.
    /// </summary>
    [JsonProperty("is_ignored")]
    public bool IsIgnored { get; set; }

    [JsonProperty("is_moderator")]
    public bool IsModerator { get; set; }

    [JsonProperty("is_super_admin")]
    public bool IsSuperAdmin { get; set; }

    /// <summary>
    /// Unix timestamp of user's last activity, if available.
    /// </summary>
    [JsonProperty("last_activity")]
    public int LastActivity { get; set; }

    [JsonProperty("location")]
    public string Location { get; set; }

    [JsonProperty("push_on_conversation")]
    public bool PushOnConversation { get; set; }

    [JsonProperty("push_optout")]
    public JArray PushOptout { get; set; }          // TODO

    [JsonProperty("receive_admin_email")]
    public bool ReceiveAdminEmail { get; set; }

    [JsonProperty("secondary_group_ids")]
    public JArray SecondaryGroupIds { get; set; }           // TODO

    [JsonProperty("show_dob_date")]
    public bool ShowDobDate { get; set; }

    [JsonProperty("show_dob_year")]
    public bool ShowDobYear { get; set; }

    [JsonProperty("signature")]
    public string Signature { get; set; }

    [JsonProperty("timezone")]
    public string Timezone { get; set; }

    [JsonProperty("use_tfa")]
    public JArray UseTfa { get; set; }          // TODO

    [JsonProperty("user_group_id")]
    public int UserGroupId { get; set; }

    [JsonProperty("user_state")]
    public string UserState { get; set; }

    [JsonProperty("user_title")]
    public string UserTitle { get; set; }

    [JsonProperty("visible")]
    public bool Visible { get; set; }

    /// <summary>
    /// Current warning points.
    /// </summary>
    [JsonProperty("warning_points")]
    public int WarningPoints { get; set; }

    [JsonProperty("website")]
    public string Website { get; set; }

    [JsonProperty("view_url")]
    public string ViewUrl { get; set; }

    [JsonProperty("user_id")]
    public int UserId { get; set; }

    [JsonProperty("username")]
    public string Username { get; set; }

    [JsonProperty("message_count")]
    public int MessageCount { get; set; }

    [JsonProperty("question_solution_count")]
    public int QuestionSolutionCount { get; set; }

    [JsonProperty("register_date")]
    public int RegisterDate { get; set; }

    [JsonProperty("trophy_points")]
    public int TrophyPoints { get; set; }

    [JsonProperty("is_staff")]
    public bool IsStaff { get; set; }

    [JsonProperty("reaction_score")]
    public int ReactionScore { get; set; }

    [JsonProperty("vote_score")]
    public int VoteScore { get; set; }

}

