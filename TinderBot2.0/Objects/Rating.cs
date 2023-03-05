using Newtonsoft.Json;

namespace TinderBot2._0.Objects
{
    public class Rating
    {
        [JsonProperty("likes_remaining")] public int LikesRemaining { get; set; }

        [JsonProperty("super_likes")] public SuperLikes SuperLikes { get; set; }
    }
}