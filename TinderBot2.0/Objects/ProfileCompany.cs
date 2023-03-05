using Newtonsoft.Json;

namespace TinderBot2._0.Objects
{
    public class ProfileCompany
    {
        [JsonProperty("id")] public string Id { get; set; }

        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("displayed")] public bool Displayed { get; set; }
    }
}