using Newtonsoft.Json;

namespace TinderBot2._0.Objects
{
    public class Regular
    {
        [JsonProperty("skus")] public IList<Sku> Skus { get; set; }
    }
}