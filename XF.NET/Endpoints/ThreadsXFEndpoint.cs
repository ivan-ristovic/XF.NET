using XF.NET;

namespace XF.NET.Endpoints;

public sealed class ThreadsXFEndpoint : XFEndpoint
{

    /// <summary>
    /// GET threads/
    /// Gets a list of threads
    /// <param name="page"></param>
    /// <param name="prefix_id">Filters to only threads with the specified prefix.</param>
    /// <param name="starter_id">Filters to only threads started by the specified user ID.</param>
    /// <param name="last_days">Filters to threads that have had a reply in the last X days.</param>
    /// <param name="unread">Filters to unread threads only. Ignored for guests.</param>
    /// <param name="thread_type">Filters to threads of the specified thread type.</param>
    /// <param name="order">Method of ordering: last_post_date, post_date. When in a specific forum context: title, reply_count, view_count, vote_score, first_post_reaction_score.</param>
    /// <param name="direction">Either "asc" or "desc" for ascending or descending. Applies only if an order is provided.</param>
    /// <returns>['threads', 'Thread[]', '']</returns>
    /// <returns>['pagination', 'pagination', '']</returns>
    /// </summary>

    /// <summary>
    /// POST threads/
    /// Creates a thread. Thread type data can be set using additional input specific to the target thread type.
    /// <param name="node_id">ID of the forum to create the thread in.</param>
    /// <param name="title">Title of the thread.</param>
    /// <param name="message">Body of the first post in the thread.</param>
    /// <param name="discussion_type">The type of thread to create. Specific types may require additional input.</param>
    /// <param name="prefix_id">ID of the prefix to apply to the thread. If not valid in the selected forum, will be ignored.</param>
    /// <param name="tags">Array of tag names to apply to the thread.</param>
    /// <param name="custom_fields[<name>]">Value to apply to the custom field with the specified name.</param>
    /// <param name="discussion_open"></param>
    /// <param name="sticky"></param>
    /// <param name="attachment_key">API attachment key to upload files. Attachment key context type must be post with context[node_id] set to the ID of the forum this is being posted in.</param>
    /// <returns>['success', 'true', '']</returns>
    /// <returns>['thread', 'Thread', '']</returns>
    /// <returns>['Errors', '']</returns>
    /// <returns>['Error key', 'Description', '']</returns>
    /// <returns>['no_permission', 'No permission error.', '']</returns>
    /// </summary>

    /// <summary>
    /// GET threads/{id}/
    /// Gets information about the specified thread.
    /// <param name="with_posts">If specified, the response will include a page of posts.</param>
    /// <param name="page">The page of posts to include</param>
    /// <param name="with_first_post">If specified, the response will contain the first post in the thread.</param>
    /// <param name="with_last_post">If specified, the response will contain the last post in the thread.</param>
    /// <param name="order">Request a particular sort order for posts from the available options for the thread type</param>
    /// <returns>['thread', 'Thread', '']</returns>
    /// <returns>['first_unread', 'Post', 'If the thread is unread, information about the first unread post.']</returns>
    /// <returns>['first_post', 'Post', 'If requested, information about the first post in the thread.']</returns>
    /// <returns>['last_post', 'Post', 'If requested, information about the last post in the thread.']</returns>
    /// <returns>['pinned_post', 'Post', 'The pinned first post of the thread, if specified by the thread type.']</returns>
    /// <returns>['highlighted_posts', 'Post[]', 'A list of highlighted posts, if relevant to the thread type. The reason for highlighting depends on thread type.']</returns>
    /// <returns>['posts', 'Post[]', 'List of posts on the requested page. Note that even if the first post is pinned, it will be included here.']</returns>
    /// <returns>['pagination', 'pagination', 'Pagination details']</returns>
    /// </summary>

    /// <summary>
    /// POST threads/{id}/
    /// Updates the specified thread
    /// <param name="prefix_id"></param>
    /// <param name="title"></param>
    /// <param name="discussion_open"></param>
    /// <param name="sticky"></param>
    /// <param name="custom_fields[<name>]"></param>
    /// <param name="add_tags"></param>
    /// <param name="remove_tags"></param>
    /// <returns>['success', 'true', '']</returns>
    /// <returns>['thread', 'Thread', '']</returns>
    /// </summary>

    /// <summary>
    /// DELETE threads/{id}/
    /// Deletes the specified thread. Default to soft deletion.
    /// <param name="hard_delete"></param>
    /// <param name="reason"></param>
    /// <param name="starter_alert"></param>
    /// <param name="starter_alert_reason"></param>
    /// <returns>['success', 'true', '']</returns>
    /// </summary>

    /// <summary>
    /// POST threads/{id}/change-type
    /// Converts a thread to the specified type. Additional thread type data can be set using input specific to the new thread type.
    /// <param name="new_thread_type_id"></param>
    /// <returns>['success', 'true', '']</returns>
    /// <returns>['thread', 'Thread', '']</returns>
    /// </summary>

    /// <summary>
    /// POST threads/{id}/mark-read
    /// Marks the thread as read up until the specified time. This cannot mark a thread as unread or
    /// <param name="date">Unix timestamp to mark the thread read to. If not specified, defaults to the current time.</param>
    /// <returns>['success', 'true', '']</returns>
    /// </summary>

    /// <summary>
    /// POST threads/{id}/move
    /// Moves the specified thread to a different forum. Only simple title/prefix updates are supported at the same time
    /// <param name="target_node_id"></param>
    /// <param name="prefix_id">If set, will update the thread's prefix. Prefix must be valid in the target forum.</param>
    /// <param name="title">If set, updates the thread's title</param>
    /// <param name="notify_watchers">If true, users watching the target forum will receive a notification as if this thread were created in the target forum</param>
    /// <param name="starter_alert">If true, the thread starter will receive an alert notifying them of the move</param>
    /// <param name="starter_alert_reason">The reason for the move to include with the thread starter alert</param>
    /// <returns>['success', 'true', '']</returns>
    /// <returns>['thread', 'Thread', '']</returns>
    /// </summary>

    /// <summary>
    /// GET threads/{id}/posts
    /// Gets a page of posts in the specified conversation.
    /// <param name="page"></param>
    /// <param name="order">Request a particular sort order for posts from the available options for the thread type</param>
    /// <returns>['pinned_post', 'Post', 'The pinned first post of the thread, if specified by the thread type.']</returns>
    /// <returns>['highlighted_posts', 'Post[]', 'A list of highlighted posts, if relevant to the thread type. The reason for highlighting depends on thread type.']</returns>
    /// <returns>['posts', 'Post[]', 'List of posts on the requested page. Note that even if the first post is pinned, it will be included here.']</returns>
    /// <returns>['pagination', 'pagination', 'Pagination details']</returns>
    /// </summary>

    /// <summary>
    /// POST threads/{id}/vote
    /// Votes on the specified thread (if applicable)
    /// <param name="type">Type of vote, "up" or "down". Use the current type to undo.</param>
    /// <returns>['success', 'true', '']</returns>
    /// <returns>['action', 'string', '"insert" or "delete" based on whether the reaction was added or removed.']</returns>
    /// </summary>
}
