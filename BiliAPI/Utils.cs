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
        public static readonly HttpClient httpClient = new(new HttpClientHandler()
        {
            AutomaticDecompression = System.Net.DecompressionMethods.All
        });
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
            try
            {
                return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(json);
            }
            catch
            {
                if (Settings.WriteJsonWhenError)
                {
                    Console.WriteLine(json);
                }
                throw;
            }
        }
        public static string? Serialize(object o, JsonSerializerOptions? option = null)
        {
            if (o == null)
                throw new ArgumentNullException(nameof(o));
            return Newtonsoft.Json.JsonConvert.SerializeObject(o);
        }

        public static HttpResponseMessage? Request(string url) => RequestAsync(url).Result;
        public static async Task<HttpResponseMessage?> RequestAsync(string url, IEnumerable<KeyValuePair<string, string>>? headers = null, HttpClient? client = null)
        {
            if (url == null)
                throw new ArgumentNullException(nameof(url));
            var uri = new Uri(Settings.UseFetcher ? $"{Settings.FetcherUrl}{url}" : url);
            var request = new HttpRequestMessage(HttpMethod.Get, uri);
            if (headers?.Any() == true)
            {
                foreach (var header in headers)
                {
                    request.Headers.TryAddWithoutValidation(header.Key, header.Value);
                }
            }
            if (!string.IsNullOrEmpty(Settings.Cookie) && !request.Headers.Contains("cookie"))
                request.Headers.TryAddWithoutValidation("cookie", Settings.Cookie);
            if (!string.IsNullOrEmpty(Settings.User_Agent) && !request.Headers.Contains("User-Agent"))
                request.Headers.TryAddWithoutValidation("User-Agent", Settings.User_Agent);
            return await (client ?? httpClient).SendAsync(request);
        }
        public static async Task<string?> RequestStringAsync(string url, IEnumerable<KeyValuePair<string, string>>? headers = null, HttpClient? client = null)
        {
            return await (await RequestAsync(url, headers, client))?.Content?.ReadAsStringAsync();
        }
        public static string? RequestString(string url, HttpClient? client = null) => RequestStringAsync(url, null, client).Result;
    }
}
