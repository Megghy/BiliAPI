using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Unicode;

namespace BiliAPI
{
    public static class Utils
    {
        private class BoolConverter : JsonConverter<bool>
        {
            public override void Write(Utf8JsonWriter writer, bool value, JsonSerializerOptions options) =>
                writer.WriteBooleanValue(value);

            public override bool Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
                reader.TokenType switch
                {
                    JsonTokenType.True => true,
                    JsonTokenType.False => false,
                    JsonTokenType.String => bool.TryParse(reader.GetString(), out var b) ? b : throw new JsonException($"Unable parse \"{reader.GetString()}\" to Boolean"),
                    JsonTokenType.Number => reader.TryGetInt64(out long l) ? Convert.ToBoolean(l) : reader.TryGetDouble(out double d) && Convert.ToBoolean(d),
                    _ => throw new JsonException(),
                };
        }
        public static DateTime ToDateTime(this long unix)
        {
            var dataTime = new DateTime(1970, 1, 1, 8, 0, 0);
            return dataTime.AddSeconds(unix);
        }
        public static readonly HttpClient httpClient = new()
        {
            Timeout = new(0, 0, 30)
        };
        public static readonly JsonSerializerOptions jsonOption = new()
        {
            PropertyNameCaseInsensitive = true,
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
            Converters = { new BoolConverter() }
        };
        public static T? Deserialize<T>(string? json)
        {
            if (json == null)
                throw new ArgumentNullException(nameof(json));
            try
            {
                return JsonSerializer.Deserialize<T>(json, jsonOption);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Error] {ex}");
                return default;
            }
        }
        public static string Serialize(object o, JsonSerializerOptions? option = null)
        {
            if (o == null)
                throw new ArgumentNullException(nameof(o));
            return JsonSerializer.Serialize(o, option ?? jsonOption);
        }

        public static HttpResponseMessage? Request(string url) => RequestAsync(url).Result;
        public static async Task<HttpResponseMessage?> RequestAsync(string url)
        {
            if (url == null)
                throw new ArgumentNullException(nameof(url));
            try
            {
                var uri = new Uri(url);
                var request = new HttpRequestMessage(HttpMethod.Get, uri);
                return await httpClient.SendAsync(request);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Error] {ex}");
                return null;
            }
        }
        public static async Task<string?> RequestStringAsync(string url, params KeyValuePair<string, string>[] param)
        {
            return await (await httpClient.GetAsync(url)).Content.ReadAsStringAsync();
        }
        public static string? RequestString(string url) => RequestStringAsync(url).Result;
    }
}
