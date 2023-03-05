using Newtonsoft.Json;

namespace TinderBot2._0.Objects
{
    public class CommonConnection
    {
        [JsonProperty("id")] public string Id { get; set; }

        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("photo")] public FacebookPhoto Photo { get; set; }

        [JsonProperty("degree")] public int Degree { get; set; }
    }
}