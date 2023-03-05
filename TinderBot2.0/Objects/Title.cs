using Newtonsoft.Json;

namespace TinderBot2._0.Objects
{
    public class Title
    {
        [JsonProperty("name")] public string Name { get; set; }
    }
}