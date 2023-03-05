using Newtonsoft.Json;

namespace TinderBot2._0.Objects
{
    public class TinderMatches
    {
        [JsonProperty("data")] public MatchData Data { get; set; }
    }
}