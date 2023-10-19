using BiliAPI.BiliInfo;

namespace BiliAPI.BiliUser
{
    public static class UserAPI
    {
        public const string? UserURL = "https://api.bilibili.com/x/space/acc/info";
        public const string? UserVideoURL = "https://api.bilibili.com/x/space/arc/search";
        /// <summary>
        /// 获取用户数据
        /// </summary>
        /// <param name="uid">用户ID</param>
        /// <returns>
        /// 是否成功及用户信息
        /// </returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="NotSupportedException"></exception>
        /// <exception cref="JsonException"></exception>
        public static async Task<(bool success, BiliUserInfo? userData)> GetUserData(
            string uid, HttpClient? client = null)
        {
            if (long.TryParse(uid, out var _uid))
                return await GetUserData(_uid, client);
            else
                throw new ArgumentException("Invalid uid");
        }
        /// <summary>
        /// 获取用户数据
        /// </summary>
        /// <param name="uid">用户ID</param>
        /// <returns>
        /// 是否成功及用户信息
        /// </returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="NotSupportedException"></exception>
        /// <exception cref="JsonException"></exception>
        public static async Task<(bool success, BiliUserInfo? userData)> GetUserData(
            long uid, HttpClient? client = null)
        {
            if (uid < 0)
                throw new NullReferenceException("Invalid uid");
            var response = await Utils.RequestStringAsync($"{UserURL}?mid={uid}", null, client);

            if (response?.StartsWith("{\"code\":-509,\"message\":\"请求过于频繁，请稍后再试\",\"ttl\":1}{") == true)
            {
                response = response?.Replace("{\"code\":-509,\"message\":\"请求过于频繁，请稍后再试\",\"ttl\":1}", ""); // ???这东西到底是怎么存在的
            }

            var result = new BiliUserInfo(response);
            return (result.Root?.code == 0, result);
        }
        /// <summary>
        /// 获取用户发布的视频
        /// </summary>
        /// <param name="uid">用户ID</param>
        /// <returns>
        /// 是否成功及用户视频信息
        /// </returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="NotSupportedException"></exception>
        /// <exception cref="JsonException"></exception>
        public static async Task<(bool success, BiliUserVideosInfo? userData)> GetUserVideoData(
            long uid, HttpClient? client = null)
        {
            if (uid < 0)
                throw new NullReferenceException("Invalid uid");
            var response = await Utils.RequestStringAsync($"{UserVideoURL}?mid={uid}", null, client);

            if (string.IsNullOrEmpty(response))
                return (false, null);

            var result = new BiliUserVideosInfo(response);
            return (result.Root?.code == 0, result);
        }
        /// <summary>
        /// 从服务器获取用户最新发布的视频
        /// </summary>
        /// <param name="uid">用户ID</param>
        /// <returns>
        /// 是否成功及用户视频信息
        /// </returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="NotSupportedException"></exception>
        /// <exception cref="JsonException"></exception>
        public static async Task<(bool success, BiliUserVideoItemInfo? userData)> GetUserLatestVideoData(
            long uid, HttpClient? client = null)
        {
            if (uid < 0)
                throw new NullReferenceException("Invalid uid");
            (var success, var result) = await GetUserVideoData(uid, client);
            if (success)
                return (success, result?.Videos.FirstOrDefault());
            else
                return (false, null);
        }
    }
}
