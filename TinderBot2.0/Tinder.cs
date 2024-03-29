﻿using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using System.Text;
using TinderBot2._0.Objects;
using System.IO;
using ProtoBuf;
using System;
using System.Net;

namespace TinderBot2._0
{
    public class Tinder
    {
        public static List<Tinder> Instances = new();

        private const string _appVersion = "1035601";
        private const string _tinderVersion = "3.56.1";

        private const string _userAgent =
            "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/108.0.0.0 Safari/537.36 Edg/108.0.1462.76";

        private string _deviceId { get; set; }
        private ProxyType? _proxy { get; set; }
        public string _authToken { get; set; }
        private HttpClient _client { get; set; }
        private readonly string _apiUrl = "https://api.gotinder.com/";

        public Tinder(string authToken, ProxyType? proxy)
        {
            _authToken = authToken;
            _client = new HttpClient();
            _proxy = proxy;

            if (_proxy == null) return;

            var p = new WebProxy
            {
                Address = new Uri($"http://{_proxy.Ip}:{_proxy.Port}"),
                BypassProxyOnLocal = false,
                UseDefaultCredentials = false,

                Credentials = new NetworkCredential(
                    userName: _proxy.Username,
                    password: _proxy.Password)
            };

            var httpClientHandler = new HttpClientHandler();
            httpClientHandler.Proxy = p;

            httpClientHandler.ServerCertificateCustomValidationCallback =
                HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;
            _client = new HttpClient(handler: httpClientHandler, disposeHandler: true);
        }

        public static void RegisterInstance(Tinder instance)
        {
            Instances.Add(instance);
        }

        public async Task<MatchData?> GetMatches(bool hasSentMessage = false)
        {
            var data = await SendGet(
                $"v2/matches?locale=en&count=60&message={(hasSentMessage ? 1 : 0)}&is_tinder_u=false");
            return string.IsNullOrEmpty(data) ? new MatchData() : JsonConvert.DeserializeObject<MatchData>(data);
        }

        public async Task<TinderRecommendation?> GetMatchCards()
        {
            var data = await SendGet("v2/recs/core?locale=en");
            return string.IsNullOrEmpty(data)
                ? new TinderRecommendation()
                : JsonConvert.DeserializeObject<TinderRecommendation>(data);
        }

        public async Task<LikedUser?> LikeUser(string userId)
        {
            var data = await SendGet($"like/{userId}?locale=en");
            return JsonConvert.DeserializeObject<LikedUser>(data);
        }

        public async Task SendMessage(string userId, string message)
        {
            var currentUser = await GetUser();

            await SendPost($"user/matches/{userId}?locale=en", new
            {
                userId,
                matchId = $"{userId}{currentUser.Id}",
                otherId = currentUser.Id,
                message
            });
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

            request.Headers.Add("app_version", _appVersion);
            request.Headers.Add("tinder-version", _tinderVersion);
            request.Headers.Add("User-agent", _userAgent);
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