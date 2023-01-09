﻿using Newtonsoft.Json;

namespace TinderBot2._0.Objects
{
    public class LikedUser
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        //[JsonProperty("match")]
        //public LikedUserResponse? Match { get; set; }

        [JsonProperty("likes_remaining")]
        public int LikesRemaining { get; set; }
    }
}
