using Newtonsoft.Json;

namespace TinderBot2._0.Objects
{
    public class School
    {
        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("id")] public string Id { get; set; }
    }
}