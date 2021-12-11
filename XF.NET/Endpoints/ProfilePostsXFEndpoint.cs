using XF.NET;

namespace XF.NET.Endpoints;

public sealed class ProfilePostsXFEndpoint : XFEndpoint
{

    /// <summary>
    /// POST profile-posts/
    /// Creates a new profile post.
    /// <param name="user_id">The ID of the user whose profile this will be posted on.</param>
    /// <param name="message"></param>
    /// <param name="attachment_key">API attachment key to upload files. Attachment key context type must be profile_post with context[profile_user_id] set to this user ID.</param>
    /// <returns>['success', 'true', '']</returns>
    /// <returns>['profile_post', 'ProfilePost', '']</returns>
    /// </summary>

    /// <summary>
    /// GET profile-posts/{id}/
    /// Gets information about the specified profile post.
    /// <param name="with_comments">If specified, the response will include a page of comments.</param>
    /// <param name="page">The page of comments to include</param>
    /// <param name="direction">Request a particular sort order for comments - default 'desc' (newest first) also allows 'asc' (oldest first)</param>
    /// <returns>['profile_post', 'ProfilePost', '']</returns>
    /// <returns>['comments', 'ProfilePostComment[]', 'List of comments on the requested page']</returns>
    /// <returns>['pagination', 'pagination', 'Pagination details']</returns>
    /// </summary>

    /// <summary>
    /// POST profile-posts/{id}/
    /// Updates the specified profile post.
    /// <param name="message"></param>
    /// <param name="author_alert"></param>
    /// <param name="author_alert_reason"></param>
    /// <param name="attachment_key">API attachment key to upload files. Attachment key context type must be profile_post with context[profile_post_id] set to this profile post ID.</param>
    /// <returns>['success', 'true', '']</returns>
    /// <returns>['profile_post', 'ProfilePost', '']</returns>
    /// </summary>

    /// <summary>
    /// DELETE profile-posts/{id}/
    /// Deletes the specified profile post. Default to soft deletion.
    /// <param name="hard_delete"></param>
    /// <param name="reason"></param>
    /// <param name="author_alert"></param>
    /// <param name="author_alert_reason"></param>
    /// <returns>['success', 'true', '']</returns>
    /// </summary>

    /// <summary>
    /// GET profile-posts/{id}/comments
    /// Gets a page of comments on the specified profile post.
    /// <param name="page"></param>
    /// <param name="direction">Request a particular sort order for comments - default 'desc' (newest first) also allows 'asc' (oldest first)</param>
    /// <returns>['comments', 'ProfilePostComment[]', 'List of comments on the requested page']</returns>
    /// <returns>['pagination', 'pagination', 'Pagination details']</returns>
    /// </summary>

    /// <summary>
    /// POST profile-posts/{id}/react
    /// Reacts to the specified profile post
    /// <param name="reaction_id">ID of the reaction to use. Use the current reaction ID to undo.</param>
    /// <returns>['success', 'true', '']</returns>
    /// <returns>['action', 'string', '"insert" or "delete" based on whether the reaction was added or removed.']</returns>
    /// </summary>
}
