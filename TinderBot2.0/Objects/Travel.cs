using Newtonsoft.Json;

namespace TinderBot2._0.Objects
{
    public class Travel
    {
        [JsonProperty("is_traveling")] public bool IsTraveling { get; set; }
    }
}