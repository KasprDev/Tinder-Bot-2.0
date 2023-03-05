using Newtonsoft.Json;

namespace TinderBot2._0.Objects
{
    public class ProfileJob
    {
        [JsonProperty("company")] public ProfileCompany Company { get; set; }
    }
}