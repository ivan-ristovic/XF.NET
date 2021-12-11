using XF.NET;

namespace XF.NET.Endpoints;

public sealed class UsersXFEndpoint : XFEndpoint
{

    /// <summary>
    /// GET users/
    /// Gets a list of users (alphabetically)
    /// <param name="page"></param>
    /// <returns>['users', 'User[]', '']</returns>
    /// <returns>['pagination', 'pagination', '']</returns>
    /// </summary>

    /// <summary>
    /// POST users/
    /// Creates a user.
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
    /// <param name="option[is_discouraged]"></param>
    /// <param name="username"></param>
    /// <param name="email"></param>
    /// <param name="user_group_id"></param>
    /// <param name="secondary_group_ids"></param>
    /// <param name="user_state"></param>
    /// <param name="is_staff"></param>
    /// <param name="message_count"></param>
    /// <param name="reaction_score"></param>
    /// <param name="trophy_points"></param>
    /// <param name="username_change_visible">If true and the username is changed, the change will be visible (shown in the public list of previous usernames).</param>
    /// <param name="password"></param>
    /// <param name="dob[day]"></param>
    /// <param name="dob[month]"></param>
    /// <param name="dob[year]"></param>
    /// <param name="custom_fields[<name>]"></param>
    /// <returns>['success', 'true', '']</returns>
    /// <returns>['user', 'User', '']</returns>
    /// </summary>

    /// <summary>
    /// GET users/find-email
    /// Finds users by their email. Only available to admin users (or when bypassing permissions).
    /// <param name="email">[required]</param>
    /// <returns>['user', 'User|null', 'The user that matched the given email exactly']</returns>
    /// </summary>

    /// <summary>
    /// GET users/find-name
    /// Finds users by a prefix of their user name.
    /// <param name="username">[required]</param>
    /// <returns>['exact', 'User|null', 'The user that matched the given username exactly']</returns>
    /// <returns>['recommendations', 'User[]', 'A list of users that match the prefix of the username (but not exactly)']</returns>
    /// </summary>

    /// <summary>
    /// GET users/{id}/
    /// Gets information about the specified user.
    /// <param name="with_posts">If specified, the response will include a page of profile posts.</param>
    /// <param name="page">The page of comments to include</param>
    /// <returns>['user', 'User', '']</returns>
    /// <returns>['profile_posts', 'ProfilePost[]', 'List of profile posts on the requested page']</returns>
    /// <returns>['pagination', 'pagination', 'Pagination details']</returns>
    /// </summary>

    /// <summary>
    /// POST users/{id}/
    /// Updates an existing user.
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
    /// <param name="option[is_discouraged]"></param>
    /// <param name="username"></param>
    /// <param name="email"></param>
    /// <param name="user_group_id"></param>
    /// <param name="secondary_group_ids"></param>
    /// <param name="user_state"></param>
    /// <param name="is_staff"></param>
    /// <param name="message_count"></param>
    /// <param name="reaction_score"></param>
    /// <param name="trophy_points"></param>
    /// <param name="username_change_visible">If true and the username is changed, the change will be visible (shown in the public list of previous usernames).</param>
    /// <param name="password"></param>
    /// <param name="dob[day]"></param>
    /// <param name="dob[month]"></param>
    /// <param name="dob[year]"></param>
    /// <param name="custom_fields[<name>]"></param>
    /// <returns>['success', 'true', '']</returns>
    /// <returns>['user', 'User', '']</returns>
    /// </summary>

    /// <summary>
    /// DELETE users/{id}/
    /// Deletes the specified user
    /// <param name="rename_to">If specified, the user will be renamed before deletion</param>
    /// <returns>['success', 'true', '']</returns>
    /// </summary>

    /// <summary>
    /// POST users/{id}/avatar
    /// Updates the specified user's avatar
    /// <param name="avatar">The uploaded new avatar</param>
    /// <returns>['success', 'true', '']</returns>
    /// </summary>

    /// <summary>
    /// DELETE users/{id}/avatar
    /// Deletes the specified user's avatar
    /// <returns>['success', 'true', '']</returns>
    /// </summary>

    /// <summary>
    /// GET users/{id}/profile-posts
    /// Gets a page of profile posts on the specified user's profile.
    /// <param name="page"></param>
    /// <returns>['profile_posts', 'ProfilePost[]', 'List of profile posts on the requested page']</returns>
    /// <returns>['pagination', 'pagination', 'Pagination details']</returns>
    /// </summary>
}
