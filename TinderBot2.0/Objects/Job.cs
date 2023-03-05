using Newtonsoft.Json;

namespace TinderBot2._0.Objects
{
    public class Job
    {
        [JsonProperty("company")] public Company? Company { get; set; }

        [JsonProperty("title")] public Title? Title { get; set; }
    }
}