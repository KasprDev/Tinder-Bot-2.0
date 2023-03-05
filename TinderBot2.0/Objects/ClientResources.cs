using Newtonsoft.Json;

namespace TinderBot2._0.Objects
{
    public class ClientResources
    {
        [JsonProperty("rate_card")] public RateCard RateCard { get; set; }

        [JsonProperty("plus_screen")] public IList<string> PlusScreen { get; set; }
    }
}