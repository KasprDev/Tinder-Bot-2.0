﻿using Newtonsoft.Json;

namespace TinderBot2._0.Objects
{
    public class ProfileSchool
    {
        [JsonProperty("displayed")] public bool Displayed { get; set; }

        [JsonProperty("id")] public string Id { get; set; }

        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("year")] public string Year { get; set; }

        [JsonProperty("type")] public string Type { get; set; }
    }
}