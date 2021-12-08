#nullable disable
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace XF.NET.Models;

public sealed class Poll
{
    [JsonProperty("can_vote")]
    public bool CanVote { get; set; }

    [JsonProperty("has_voted")]
    public bool HasVoted { get; set; }

    /// <summary>
    /// List of possible responses with text, vote count (if visible) and whether the API user has voted for each
    /// </summary>
    [JsonProperty("responses")]
    public JArray Responses { get; set; }   // TODO

    [JsonProperty("poll_id")]
    public int PollId { get; set; }

    [JsonProperty("question")]
    public string Question { get; set; }

    [JsonProperty("voter_count")]
    public int VoterCount { get; set; }

    [JsonProperty("public_votes")]
    public bool PublicVotes { get; set; }

    [JsonProperty("max_votes")]
    public int MaxVotes { get; set; }

    [JsonProperty("close_date")]
    public int CloseDate { get; set; }

    [JsonProperty("change_vote")]
    public bool ChangeVote { get; set; }

    [JsonProperty("view_results_unvoted")]
    public bool ViewResultsUnvoted { get; set; }
}

