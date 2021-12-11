using XF.NET;

namespace XF.NET.Endpoints;

public sealed class ForumsXFEndpoint : XFEndpoint
{

    /// <summary>
    /// GET forums/{id}/
    /// Gets information about the specified forum
    /// <param name="with_threads">If true, gets a page of threads in this forum</param>
    /// <param name="page"></param>
    /// <param name="prefix_id">Filters to only threads with the specified prefix.</param>
    /// <param name="starter_id">Filters to only threads started by the specified user ID.</param>
    /// <param name="last_days">Filters to threads that have had a reply in the last X days.</param>
    /// <param name="unread">Filters to unread threads only. Ignored for guests.</param>
    /// <param name="thread_type">Filters to threads of the specified thread type.</param>
    /// <param name="order">Method of ordering: last_post_date, post_date. When in a specific forum context: title, reply_count, view_count, vote_score, first_post_reaction_score.</param>
    /// <param name="direction">Either "asc" or "desc" for ascending or descending. Applies only if an order is provided.</param>
    /// <returns>['forum', 'Forum', '']</returns>
    /// <returns>['threads', 'Thread[]', 'Threads on this page']</returns>
    /// <returns>['pagination', 'pagination', 'Pagination information']</returns>
    /// <returns>['sticky', 'Thread[]', 'If on page 1, a list of sticky threads in this forum. Does not count towards the per page limit.']</returns>
    /// </summary>

    /// <summary>
    /// POST forums/{id}/mark-read
    /// Marks the forum as read up until the specified time. This cannot mark a forum as unread or
    /// <param name="date">Unix timestamp to mark the forum read to. If not specified, defaults to the current time.</param>
    /// <returns>['success', 'true', '']</returns>
    /// </summary>

    /// <summary>
    /// GET forums/{id}/threads
    /// Gets a page of threads from the specified forum.
    /// <param name="prefix_id">Filters to only threads with the specified prefix.</param>
    /// <param name="starter_id">Filters to only threads started by the specified user ID.</param>
    /// <param name="last_days">Filters to threads that have had a reply in the last X days.</param>
    /// <param name="unread">Filters to unread threads only. Ignored for guests.</param>
    /// <param name="thread_type">Filters to threads of the specified thread type.</param>
    /// <param name="order">Method of ordering: last_post_date, post_date. When in a specific forum context: title, reply_count, view_count, vote_score, first_post_reaction_score.</param>
    /// <param name="direction">Either "asc" or "desc" for ascending or descending. Applies only if an order is provided.</param>
    /// <returns>['threads', 'Thread[]', 'Threads on this page']</returns>
    /// <returns>['pagination', 'pagination', 'Pagination information']</returns>
    /// <returns>['sticky', 'Thread[]', 'If on page 1, a list of sticky threads in this forum. Does not count towards the per page limit.']</returns>
    /// </summary>
}
