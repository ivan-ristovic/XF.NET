using XF.NET;

namespace XF.NET.Endpoints;

public sealed class MediaCategoriesXFEndpoint : XFEndpoint
{

    /// <summary>
    /// GET media-categories/
    /// [Incomplete]
    /// </summary>

    /// <summary>
    /// POST media-categories/
    /// [Incomplete]
    /// </summary>

    /// <summary>
    /// GET media-categories/flattened
    /// [Incomplete]
    /// </summary>

    /// <summary>
    /// GET media-categories/{id}/
    /// [Incomplete]
    /// </summary>

    /// <summary>
    /// POST media-categories/{id}/
    /// [Incomplete]
    /// </summary>

    /// <summary>
    /// DELETE media-categories/{id}/
    /// Deletes the specified category
    /// <param name="delete_children">If true, child nodes will be deleted. Otherwise, they will be connected to this node's parent.</param>
    /// <returns>['success', 'true', '']</returns>
    /// </summary>

    /// <summary>
    /// GET media-categories/{id}/content
    /// Gets a page of content from the specified category.
    /// <returns>['albums', 'XFMG_Album[]', 'If an album category, albums on this page']</returns>
    /// <returns>['media', 'XFMG_Media[]', 'If a media category, media on this page']</returns>
    /// <returns>['pagination', 'pagination', 'Pagination information']</returns>
    /// </summary>
}
