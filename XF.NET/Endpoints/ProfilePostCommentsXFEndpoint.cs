using XF.NET;

namespace XF.NET.Endpoints;

public sealed class ProfilePostCommentsXFEndpoint : XFEndpoint
{

    /// <summary>
    /// POST profile-post-comments/
    /// Creates a new profile post comment.
    /// <param name="profile_post_id">The ID of the profile post this comment will be attached to.</param>
    /// <param name="message"></param>
    /// <param name="attachment_key">API attachment key to upload files. Attachment key context type must be profile_post_comment with context[profile_post_id] set to this profile post ID.</param>
    /// <returns>['success', 'true', '']</returns>
    /// <returns>['comment', 'ProfilePostComment', '']</returns>
    /// </summary>

    /// <summary>
    /// GET profile-post-comments/{id}/
    /// Gets information about the specified profile post comment.
    /// <returns>['comment', 'ProfilePostComment', '']</returns>
    /// </summary>

    /// <summary>
    /// POST profile-post-comments/{id}/
    /// Updates the specified profile post comment.
    /// <param name="message"></param>
    /// <param name="author_alert"></param>
    /// <param name="author_alert_reason"></param>
    /// <param name="attachment_key">API attachment key to upload files. Attachment key context type must be profile_post_comment with context[profile_post_comment_id] set to this profile post comment ID.</param>
    /// <returns>['success', 'true', '']</returns>
    /// <returns>['comment', 'ProfilePostComment', '']</returns>
    /// </summary>

    /// <summary>
    /// DELETE profile-post-comments/{id}/
    /// Deletes the specified profile post comment. Default to soft deletion.
    /// <param name="hard_delete"></param>
    /// <param name="reason"></param>
    /// <param name="author_alert"></param>
    /// <param name="author_alert_reason"></param>
    /// <returns>['success', 'true', '']</returns>
    /// </summary>

    /// <summary>
    /// POST profile-post-comments/{id}/react
    /// Reacts to the specified profile post comment
    /// <param name="reaction_id">ID of the reaction to use. Use the current reaction ID to undo.</param>
    /// <returns>['success', 'true', '']</returns>
    /// <returns>['action', 'string', '"insert" or "delete" based on whether the reaction was added or removed.']</returns>
    /// </summary>
}
