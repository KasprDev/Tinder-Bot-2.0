using Newtonsoft.Json;

namespace TinderBot2._0.Objects
{
    public class MatchSeen
    {
        [JsonProperty("match_seen")] public bool Seen { get; set; }
    }
}