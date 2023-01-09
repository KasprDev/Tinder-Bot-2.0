using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using System.Text;
using SharpTinder;
using TinderBot2._0.Objects;
using TinderClient.Tinder;

namespace TinderBot2._0
{
    public class Tinder
    {
        public static List<Tinder> Instances = new List<Tinder>();

        private readonly string _appVersion = "1035200";
        private readonly string _tinderVersion = "3.52.0";
        private readonly string _userAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:53.0) Gecko/20100101 Firefox/53.0";
        private  string _authToken { get; set; }
        private HttpClient _client { get; set; }
        private readonly string _apiUrl = "https://api.gotinder.com/";

        public Tinder(string authToken)
        {
            _authToken = authToken;
            _client = new HttpClient();
        }

        public static void RegisterInstance(Tinder instance)
        {
            Instances.Add(instance);
        }

        public async Task<TinderRecommendation?> GetMatchCards()
        {
            var data = await SendGet("v2/recs/core");
            Console.WriteLine(data);
            return string.IsNullOrEmpty(data) ? new TinderRecommendation() : JsonConvert.DeserializeObject<TinderRecommendation>(data);
        }

        public async Task<LikedUser?> LikeUser(string userId)
        {
            var data = await SendGet($"like/{userId}?locale=en");

            return JsonConvert.DeserializeObject<LikedUser>(data);
        }

        public async Task<LikedUser?> PassUser(string userId, long sNumber)
        {
            var data = await SendGet($"pass/{userId}?locale=en&s_number={sNumber}");

            return JsonConvert.DeserializeObject<LikedUser>(data);
        }

        public async Task<TinderUser?> GetUser()
        {
            var data = await SendGet("profile");
            return string.IsNullOrEmpty(data) ? new TinderUser() : JsonConvert.DeserializeObject<TinderUser>(data);
        }

        public async Task<string> SendPost(string path, object data, bool gZip = false)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, $"{_apiUrl}{path}")
            {
                Content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json")
            };

            request.Headers.Add( "app_version", _appVersion );
            request.Headers.Add("tinder-version", _tinderVersion);
            request.Headers.Add("User-agent", _userAgent);
            request.Headers.Add("content-type", "application/json");
            request.Headers.Add("vary", "Accept-Encoding");
            request.Headers.Add("X-Auth-Token", _authToken);

            if (!gZip)
            {
                request.Headers.Add("accept", "application/json");
                request.Headers.Add("accept-encoding", "gzip, deflate, br");
                request.Headers.Add("accept-language", "en-US,en;q=0.9,la;q=0.8");
            }

            var resp = await _client.SendAsync(request);

            var reader = new StreamReader(await resp.Content.ReadAsStreamAsync());

            return await reader.ReadToEndAsync();
        }

        public async Task<string> SendGet(string path)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"{_apiUrl}{path}");

            request.Headers.Add("app_version", _appVersion);
            request.Headers.Add("tinder-version", _tinderVersion);
            request.Headers.Add("User-agent", _userAgent);
            request.Headers.Add("vary", "Accept-Encoding");
            request.Headers.Add("X-Auth-Token", _authToken);

            var resp = await _client.SendAsync(request);

            var reader = new StreamReader(await resp.Content.ReadAsStreamAsync());

            return await reader.ReadToEndAsync();
        }
    }
}
