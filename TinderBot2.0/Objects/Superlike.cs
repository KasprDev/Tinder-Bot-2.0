using Newtonsoft.Json;

namespace TinderBot2._0.Objects
{
    public class Superlike
    {
        [JsonProperty("regular")] public Regular Regular { get; set; }
    }
}