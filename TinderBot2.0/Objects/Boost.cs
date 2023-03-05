using Newtonsoft.Json;

namespace TinderBot2._0.Objects
{
    public class Boost
    {
        [JsonProperty("regular")] public Regular Regular { get; set; }
    }
}