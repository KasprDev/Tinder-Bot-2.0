using Newtonsoft.Json;

namespace TinderBot2._0.Objects
{
    public class Products
    {
        [JsonProperty("superlike")] public Superlike Superlike { get; set; }

        [JsonProperty("boost")] public Boost Boost { get; set; }
    }
}