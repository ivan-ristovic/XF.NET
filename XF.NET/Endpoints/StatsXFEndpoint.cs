using XF.NET;

namespace XF.NET.Endpoints;

public sealed class StatsXFEndpoint : XFEndpoint
{

    /// <summary>
    /// GET stats/
    /// Gets site statistics and general activity information
    /// <returns>['totals[threads]', 'integer', '']</returns>
    /// <returns>['totals[messages]', 'integer', '']</returns>
    /// <returns>['totals[users]', 'integer', '']</returns>
    /// <returns>['latest_user[user_id]', 'integer', '']</returns>
    /// <returns>['latest_user[username]', 'string', '']</returns>
    /// <returns>['latest_user[register_date]', 'integer', '']</returns>
    /// <returns>['online[total]', 'integer', '']</returns>
    /// <returns>['online[members]', 'integer', '']</returns>
    /// <returns>['online[guests]', 'integer', '']</returns>
    /// </summary>
}
