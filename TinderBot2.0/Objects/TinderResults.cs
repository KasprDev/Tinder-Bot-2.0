using Newtonsoft.Json;

namespace TinderBot2._0.Objects
{
    class TinderResults
    {
        [JsonProperty("type")] public string Type { get; set; }

        [JsonProperty("user")] public string User { get; set; }
    }
}