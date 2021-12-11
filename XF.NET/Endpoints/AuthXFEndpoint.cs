using XF.NET;

namespace XF.NET.Endpoints;

public sealed class AuthXFEndpoint : XFEndpoint
{

    /// <summary>
    /// POST auth/
    /// Tests a login and password for validity. Only available to super user keys. We strongly recommend the login and password parameters are passed into the request body rather than the query string.
    /// <param name="login">The username or email address of the user to test</param>
    /// <param name="password">The password of the user</param>
    /// <param name="limit_ip">The IP that should be considered to be making the request. If provided, this will be used to prevent brute force attempts.</param>
    /// <returns>['user', 'User', 'If successful, the user record of the matching user']</returns>
    /// </summary>

    /// <summary>
    /// POST auth/from-session
    /// Looks up the active XenForo user based on session ID or remember cookie value. This can be used to help with seamless SSO with XF, assuming the session or remember cookies are available to your page. At least one of session_id and remember_cookie must be provided. Only available to super user keys.
    /// <param name="session_id">If provided, checks for an active session with that ID.</param>
    /// <param name="remember_cookie">If provided, checks to see if this is an active "remember me" cookie value.</param>
    /// <returns>['success', 'bool', 'If false, no session or remember cookie could be found']</returns>
    /// <returns>['user', 'User', 'If successful, the user record of the matching user. May be a guest.']</returns>
    /// </summary>

    /// <summary>
    /// POST auth/login-token
    /// Generates a token that can automatically log into a specific XenForo user when the login URL is visited. If the visitor is already logged into a XenForo account, they will not be logged into the specified account. Only available to super user keys.
    /// <param name="user_id"></param>
    /// <param name="limit_ip">If provided, locks the token to the specified IP for additional security</param>
    /// <param name="return_url">If provided, after logging the user will be returned to this URL. Otherwise they'll go to the XenForo index.</param>
    /// <param name="force">If provided, the login URL will forcibly replace the currently logged in user if a user is already logged in and different to the currently logged in user. Defaults to false.</param>
    /// <param name="remember">Controls whether the a "remember me" cookie will be set when the user logs in. Defaults to true.</param>
    /// <returns>['login_token', 'string', '']</returns>
    /// <returns>['login_url', 'string', 'Direct user to this URL to trigger a login']</returns>
    /// <returns>['expiry_date', 'integer', 'Unix timestamp of when the token expires. An error will be displayed if the token is expired or invalid']</returns>
    /// </summary>
}
