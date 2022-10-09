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
        public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }
            if (action == null)
            {
                throw new ArgumentNullException(nameof(action));
            }
            foreach (T obj in source)
            {
                action(obj);
            }
        }
        public static DateTime ToDateTime(this long? unix)
        {
            if (unix == null)
                return DateTime.MinValue;
            return unix.Value.ToDateTime();
        }
        public static DateTime ToDateTime(this long unix)
        {
            if (unix > 10000000000)
                unix /= 1000; //b站api有些日期加了个000
            var dataTime = new DateTime(1970, 1, 1, 8, 0, 0);
            return dataTime.AddSeconds(unix);
        }
        public static readonly HttpClient httpClient = new();
        public static readonly JsonSerializerOptions jsonOption = new()
        {
            PropertyNameCaseInsensitive = true,
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
            Converters = { new BoolConverter() }
        };
        /// <summary>
        /// 反序列化
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="json"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static T? Deserialize<T>(string? json)
        {
            if (json == null)
                throw new ArgumentNullException(nameof(json));
            return JsonSerializer.Deserialize<T>(json, jsonOption);
        }
        public static string? Serialize(object o, JsonSerializerOptions? option = null)
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
            var uri = new Uri(url);
            var request = new HttpRequestMessage(HttpMethod.Get, uri);
            request.Headers.Add("User-Agent", Settings.User_Agent);
            request.Headers.Add("cookie", Settings.Cookie);
            return await httpClient.SendAsync(request);
        }
        public static async Task<string?> RequestStringAsync(string url)
        {
            return await (await RequestAsync(url))?.Content?.ReadAsStringAsync();
        }
        public static string? RequestString(string url) => RequestStringAsync(url).Result;
    }
}
