using Newtonsoft.Json;

namespace TinderBot2._0.Objects
{
    public class Versions
    {
        [JsonProperty("trending")] public string Trending { get; set; }

        [JsonProperty("matchmaker")] public string Matchmaker { get; set; }

        [JsonProperty("trending_active_text")] public string TrendingActiveText { get; set; }

        [JsonProperty("age_filter")] public string AgeFilter { get; set; }

        [JsonProperty("active_text")] public string ActiveText { get; set; }
    }
}