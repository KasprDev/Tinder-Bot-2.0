using Newtonsoft.Json;

namespace TinderBot2._0.Objects
{
    public class RateCard
    {
        [JsonProperty("carousel")] public IList<Carousel> Carousel { get; set; }
    }
}