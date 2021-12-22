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
        public static async Task<(bool success, BiliUserInfo? userData)> GetUserData(
            long? uid)
        {
            if (uid < 0)
                throw new NullReferenceException("Invalid uid");
            try
            {
                var response = await Utils.RequestStringAsync($"{UserURL}?mid={uid}");

                if (string.IsNullOrEmpty(response))
                    return (false, null);

                var result = new BiliUserInfo(response);
                return (result.Root?.code == 0, result);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Error] {ex}");
                return (false, null);
            }
        }
        /// <summary>
        /// 获取用户发布的视频
        /// </summary>
        /// <param name="uid">用户ID</param>
        /// <returns>
        /// 是否成功及用户视频信息
        /// </returns>
        public static async Task<(bool success, BiliUserVideoInfo? userData)> GetUserVideoData(
            long? uid)
        {
            if (uid < 0)
                throw new NullReferenceException("Invalid uid");
            try
            {
                var response = await Utils.RequestStringAsync($"{UserVideoURL}?mid={uid}");

                if (string.IsNullOrEmpty(response))
                    return (false, null);

                var result = new BiliUserVideoInfo(response);
                return (result.Root?.code == 0, result);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Error] {ex}");
                return (false, null);
            }
        }
        /// <summary>
        /// 从服务器获取用户最新发布的视频
        /// </summary>
        /// <param name="uid">用户ID</param>
        /// <returns>
        /// 是否成功及用户视频信息
        /// </returns>
        public static async Task<(bool success, BiliUserVideoItemInfo? userData)> GetUserLatestVideoData(
            long? uid)
        {
            if (uid < 0)
                throw new NullReferenceException("Invalid uid");
            (var success, var result) = await GetUserVideoData(uid);
            if (success)
                return (success, result?.Videos.FirstOrDefault());
            else
                return (false, null);
        }
    }
}
