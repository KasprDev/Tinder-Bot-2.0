using Newtonsoft.Json;

namespace TinderBot2._0.Objects
{
    public class Teaser
    {
        [JsonProperty("string")] public string String { get; set; }

        [JsonProperty("type")] public string Type { get; set; }
    }
}