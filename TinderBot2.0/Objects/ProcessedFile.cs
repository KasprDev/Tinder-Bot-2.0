using Newtonsoft.Json;

namespace TinderBot2._0.Objects
{
    public class ProcessedFile
    {
        [JsonProperty("width")] public int Width { get; set; }

        [JsonProperty("url")] public string Url { get; set; }

        [JsonProperty("height")] public int Height { get; set; }
    }
}