using XF.NET;

namespace XF.NET.Endpoints;

public sealed class PostsXFEndpoint : XFEndpoint
{

    /// <summary>
    /// POST posts/
    /// Adds a new reply to a thread.
    /// <param name="thread_id">ID of the thread to reply to.</param>
    /// <param name="message"></param>
    /// <param name="attachment_key">API attachment key to upload files. Attachment key context type must be post with context[thread_id] set to this thread ID.</param>
    /// </summary>

    /// <summary>
    /// GET posts/{id}/
    /// Gets information about the specified post
    /// <returns>['post', 'Post', '']</returns>
    /// </summary>

    /// <summary>
    /// POST posts/{id}/
    /// Updates the specified post
    /// <param name="message"></param>
    /// <param name="silent">If true and permissions allow, this edit will not be updated with a "last edited" indication</param>
    /// <param name="clear_edit">If true and permissions allow, any "last edited" indication will be removed. Requires "silent".</param>
    /// <param name="author_alert"></param>
    /// <param name="author_alert_reason"></param>
    /// <param name="attachment_key">API attachment key to upload files. Attachment key context type must be post with context[post_id] set to this post ID.</param>
    /// <returns>['success', 'true', '']</returns>
    /// <returns>['post', 'Post', '']</returns>
    /// </summary>

    /// <summary>
    /// DELETE posts/{id}/
    /// Deletes the specified post. Default to soft deletion.
    /// <param name="hard_delete"></param>
    /// <param name="reason"></param>
    /// <param name="author_alert"></param>
    /// <param name="author_alert_reason"></param>
    /// <returns>['success', 'true', '']</returns>
    /// </summary>

    /// <summary>
    /// POST posts/{id}/mark-solution
    /// Toggle the specified post as the solution to its containing thread. If a post is marked as a solution when another is already marked, the existing solution will be unmarked.
    /// <returns>['true', 'mixed', 'Success']</returns>
    /// <returns>['new_solution_post', 'Post|null', 'A post that was marked as the solution']</returns>
    /// <returns>['old_solution_post', 'Post|null', 'A post that was un-marked as the solution']</returns>
    /// </summary>

    /// <summary>
    /// POST posts/{id}/react
    /// Reacts to the specified post
    /// <param name="reaction_id">ID of the reaction to use. Use the current reaction ID to undo.</param>
    /// <returns>['success', 'true', '']</returns>
    /// <returns>['action', 'string', '"insert" or "delete" based on whether the reaction was added or removed.']</returns>
    /// </summary>

    /// <summary>
    /// POST posts/{id}/vote
    /// Votes on the specified post (if applicable)
    /// <param name="type">Type of vote, "up" or "down". Use the current type to undo.</param>
    /// <returns>['success', 'true', '']</returns>
    /// <returns>['action', 'string', '"insert" or "delete" based on whether the reaction was added or removed.']</returns>
    /// </summary>
}
