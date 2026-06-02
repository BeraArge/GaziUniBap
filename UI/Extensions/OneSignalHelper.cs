using System.Net.Http.Headers;
using System.Text;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace UI.Extensions
{
    public static class OneSignalHelper
    {
        private static readonly HttpClient _client = new HttpClient();

        public static async Task<(bool ok, string? errorBody, string sentJson)> SendToSubscriptionAsync(
            string subscriptionId,
            IConfiguration configuration,
            string title,
            string message,
            object? data = null)
        {
            if (string.IsNullOrWhiteSpace(subscriptionId))
                return (false, "subscriptionId empty", "");

            var appId = configuration["OneSignal:AppId"];
            var apiKey = configuration["OneSignal:RestApiKey"];

            if (string.IsNullOrWhiteSpace(appId) || string.IsNullOrWhiteSpace(apiKey))
                return (false, "OneSignal AppId / RestApiKey missing", "");

            title = string.IsNullOrWhiteSpace(title) ? "Bildirim" : title.Trim();
            message = string.IsNullOrWhiteSpace(message) ? "Yeni bildiriminiz var." : message.Trim();

            var headings = new Dictionary<string, string>
            {
                ["tr"] = title,
                ["en"] = title
            };

            var contents = new Dictionary<string, string>
            {
                ["tr"] = message,
                ["en"] = message
            };

            var payload = new
            {
                app_id = appId,
                target_channel = "push",
                include_subscription_ids = new[] { subscriptionId },
                headings,
                contents,
                data
            };

            var json = JsonConvert.SerializeObject(payload);

            try
            {
                using var req = new HttpRequestMessage(
                    HttpMethod.Post,
                    "https://api.onesignal.com/notifications?c=push"
                );

                req.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                req.Headers.Authorization = new AuthenticationHeaderValue("Key", apiKey);
                req.Content = new StringContent(json, Encoding.UTF8, "application/json");

                var resp = await _client.SendAsync(req);
                var body = await resp.Content.ReadAsStringAsync();

                //return (resp.IsSuccessStatusCode, body, json);
                return (resp.IsSuccessStatusCode, resp.IsSuccessStatusCode ? null : body, json);
            }
            catch (Exception ex)
            {
                return (false, ex.Message, json);
            }
        }
    }
}