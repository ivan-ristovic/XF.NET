using XF.NET;

namespace XF.NET.Endpoints;

public sealed class SearchForumsXFEndpoint : XFEndpoint
{

    /// <summary>
    /// GET search-forums/{id}/
    /// Gets information about the specified search forum
    /// <param name="with_threads">If true, gets a page of threads in this search forum</param>
    /// <param name="page"></param>
    /// <returns>['search_forum', 'SearchForum', '']</returns>
    /// <returns>['threads', 'Thread[]', 'Threads on this page. Note: this will always respect viewing user permissions regardless of whether the API is set to bypass permissions.']</returns>
    /// <returns>['pagination', 'pagination', 'Pagination information']</returns>
    /// <returns>['sticky', 'Thread[]', 'If on page 1, a list of sticky threads in this forum. Does not count towards the per page limit.']</returns>
    /// </summary>

    /// <summary>
    /// GET search-forums/{id}/threads
    /// Gets a page of threads from the specified search forum.
    /// <returns>['threads', 'Thread[]', 'Threads on this page. Note: this will always respect viewing user permissions regardless of whether the API is set to bypass permissions.']</returns>
    /// <returns>['pagination', 'pagination', 'Pagination information']</returns>
    /// <returns>['sticky', 'Thread[]', 'If on page 1, a list of sticky threads in this forum. Does not count towards the per page limit.']</returns>
    /// </summary>
}
