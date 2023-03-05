using Newtonsoft.Json;

namespace TinderBot2._0.Objects
{
    public class CategoryList
    {
        [JsonProperty("id")] public string Id { get; set; }

        [JsonProperty("name")] public string Name { get; set; }
    }
}