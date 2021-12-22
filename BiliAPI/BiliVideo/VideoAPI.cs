using BiliAPI.BiliInfo;

namespace BiliAPI.BiliVideo
{
    public static class VideoAPI
    {
        public const string? VideoURL = "http://api.bilibili.com/x/web-interface/view";
        /// <summary>
        /// 获取指定视频基本信息
        /// </summary>
        /// <param name="bvid">视频bvid</param>
        /// <returns>
        /// 是否成功及视频信息
        /// </returns>
        public static async Task<(bool success, BiliVideoInfo? userData)> GetVideoData(
            string? bvid)
        {
            if (bvid == null)
                throw new NullReferenceException("Invalid bvid");
            try
            {
                var response = await Utils.RequestStringAsync($"{VideoURL}?bvid={bvid}");

                if (string.IsNullOrEmpty(response))
                    return (false, null);

                var result = new BiliVideoInfo(response);
                return (result.Root?.code == 0, result);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Error] {ex}");
                return (false, null);
            }
        }
        /// <summary>
        /// 获取指定视频基本信息
        /// </summary>
        /// <param name="avid">视频avid</param>
        /// <returns>
        /// 是否成功及视频信息
        /// </returns>
        public static async Task<(bool success, BiliVideoInfo? userData)> GetVideoData(
            long? avid)
        {
            if (avid < 0)
                throw new NullReferenceException("Invalid uid");
            try
            {
                var response = await Utils.RequestStringAsync($"{VideoURL}?aid={avid}");

                if (string.IsNullOrEmpty(response))
                    return (false, null);

                var result = new BiliVideoInfo(response);
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
