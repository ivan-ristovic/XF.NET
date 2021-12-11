using XF.NET;

namespace XF.NET.Endpoints;

public sealed class IndexXFEndpoint : XFEndpoint
{

    /// <summary>
    /// GET index/
    /// Gets general information about the site and the API
    /// <returns>['version_id', 'integer', 'XenForo version ID']</returns>
    /// <returns>['site_title', 'string', 'Title of the site this API relates to']</returns>
    /// <returns>['base_url', 'string', 'The base URL of the XenForo install this API relates to']</returns>
    /// <returns>['api_url', 'string', 'The base API URL']</returns>
    /// <returns>['key[type]', 'string', 'Type of the API key accessing the API (guest, user or super)']</returns>
    /// <returns>['key[user_id]', 'integer|null', 'If a user key, the ID of the user the key is for; null otherwise']</returns>
    /// <returns>['key[allow_all_scopes]', 'bool', 'If true, all scopes can be accessed']</returns>
    /// <returns>['key[scopes]', 'string[]', 'A list of scopes this key can access (if not allowed to access all scopes)']</returns>
    /// </summary>
}
