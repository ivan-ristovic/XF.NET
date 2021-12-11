using XF.NET;

namespace XF.NET.Endpoints;

public sealed class MeXFEndpoint : XFEndpoint
{

    /// <summary>
    /// GET me/
    /// Gets information about the current API user
    /// <returns>['me', 'User', '']</returns>
    /// </summary>

    /// <summary>
    /// POST me/
    /// Updates information about the current user
    /// <param name="option[creation_watch_state]"></param>
    /// <param name="option[interaction_watch_state]"></param>
    /// <param name="option[content_show_signature]"></param>
    /// <param name="option[email_on_conversation]"></param>
    /// <param name="option[push_on_conversation]"></param>
    /// <param name="option[receive_admin_email]"></param>
    /// <param name="option[show_dob_year]"></param>
    /// <param name="option[show_dob_date]"></param>
    /// <param name="profile[location]"></param>
    /// <param name="profile[website]"></param>
    /// <param name="profile[about]"></param>
    /// <param name="profile[signature]"></param>
    /// <param name="privacy[allow_view_profile]"></param>
    /// <param name="privacy[allow_post_profile]"></param>
    /// <param name="privacy[allow_receive_news_feed]"></param>
    /// <param name="privacy[allow_send_personal_conversation]"></param>
    /// <param name="privacy[allow_view_identities]"></param>
    /// <param name="visible"></param>
    /// <param name="activity_visible"></param>
    /// <param name="timezone"></param>
    /// <param name="custom_title"></param>
    /// <param name="custom_fields[<name>]"></param>
    /// <returns>['success', 'true', '']</returns>
    /// </summary>

    /// <summary>
    /// POST me/avatar
    /// Updates the current user's avatar
    /// <param name="avatar">The uploaded new avatar</param>
    /// <returns>['success', 'true', '']</returns>
    /// </summary>

    /// <summary>
    /// DELETE me/avatar
    /// Deletes the current user's avatar
    /// <returns>['success', 'true', '']</returns>
    /// </summary>

    /// <summary>
    /// POST me/email
    /// Updates the current user's email address
    /// <param name="current_password"></param>
    /// <param name="email"></param>
    /// <returns>['success', 'true', '']</returns>
    /// <returns>['confirmation_required', 'bool', 'True if email confirmation is required for this change']</returns>
    /// </summary>

    /// <summary>
    /// POST me/password
    /// Updates the current user's password
    /// <param name="current_password"></param>
    /// <param name="new_password"></param>
    /// <returns>['success', 'true', '']</returns>
    /// </summary>
}
