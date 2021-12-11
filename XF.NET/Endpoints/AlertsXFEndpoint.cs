using XF.NET;

namespace XF.NET.Endpoints;

public sealed class AlertsXFEndpoint : XFEndpoint
{

    /// <summary>
    /// GET alerts/
    /// Gets the API user's list of alerts
    /// <param name="page"></param>
    /// <param name="cutoff">Unix timestamp of oldest alert to include. Note that unread or unviewed alerts are always included.</param>
    /// <param name="unviewed">If true, gets only unviewed alerts. Unviewed alerts have not been seen (in the standard UI).</param>
    /// <param name="unread">If true, gets only unread alerts. Unread alerts may have been seen but the content they relate to has not been viewed.</param>
    /// <returns>['alerts', 'UserAlert[]', '']</returns>
    /// <returns>['pagination', 'pagination', '']</returns>
    /// </summary>

    /// <summary>
    /// POST alerts/
    /// Sends an alert to the specified user. Only available to super user keys.
    /// <param name="to_user_id">ID of the user to receive the alert</param>
    /// <param name="alert">Text of the alert. May use the placeholder "{link}" to have the link automatically inserted.</param>
    /// <param name="from_user_id">If provided, the user to send the alert from. Otherwise, uses the current API user. May be 0 for an anonymous alert.</param>
    /// <param name="link_url">URL user will be taken to when the alert is clicked.</param>
    /// <param name="link_title">Text of the link URL that will be displayed. If no placeholder is present in the alert, will be automatically appended.</param>
    /// <returns>['success', 'true', '']</returns>
    /// </summary>

    /// <summary>
    /// POST alerts/mark-all
    /// Marks all of the API user's alerts as read or viewed. Must specify "read" or "viewed" parameters.
    /// <param name="read">If specified, marks all alerts as read.</param>
    /// <param name="viewed">If specified, marks all alerts as viewed. This will remove the alert counter but keep unactioned alerts highlighted.</param>
    /// <returns>['success', 'true', '']</returns>
    /// </summary>

    /// <summary>
    /// GET alerts/{id}/
    /// Gets information about the specified alert
    /// <returns>['alert', 'UserAlert', '']</returns>
    /// </summary>

    /// <summary>
    /// POST alerts/{id}/mark
    /// Marks the alert as viewed/read/unread. (Marking as unviewed is not supported.)
    /// <param name="read">If specified, marks the alert as read.</param>
    /// <param name="unread">If specified, marks the alert as unread.</param>
    /// <param name="viewed">If specified, marks all alerts as viewed.</param>
    /// <returns>['success', 'true', '']</returns>
    /// </summary>
}
