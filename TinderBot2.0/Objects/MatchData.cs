using Newtonsoft.Json;

namespace TinderBot2._0.Objects
{
    public class MatchData
    {
        [JsonProperty("data")] public MatchesData Data { get; set; }
    }

    public class MatchesData
    {
        [JsonProperty("matches")] public IList<Match>? Matches { get; set; }
    }
}