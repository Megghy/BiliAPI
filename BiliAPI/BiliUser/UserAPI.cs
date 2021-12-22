using BiliAPI.BiliInfo;

namespace BiliAPI.BiliUser
{
    public static class UserAPI
    {
        public const string API_URL = "https://api.bilibili.com/x/space/acc/info";
        /// <summary>
        /// 从服务器获取用户数据
        /// </summary>
        /// <param name="uid">用户ID</param>
        /// <returns>
        /// 是否成功及用户信息
        /// </returns>
        public static async Task<(bool success, BiliUserInfo? userData)> GetUserData(
            long uid)
        {
            if (uid < 0)
                throw new NullReferenceException("Invalid uid");
            try
            {
                var response = await Utils.RequestStringAsync($"{API_URL}?mid={uid}");

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
    }
}
