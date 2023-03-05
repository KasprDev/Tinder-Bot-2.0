using Newtonsoft.Json;

namespace TinderBot2._0.Objects
{
    public class Company
    {
        [JsonProperty("name")] public string Name { get; set; }
    }
}