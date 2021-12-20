namespace BiliAPI.BiliUser.UserModel
{
    public struct BiliLiveRoom
    {
        /// <summary>
        /// 房间状态
        /// </summary>
        public int roomStatus { get; set; }
        /// <summary>
        /// 直播状态, 1为开启
        /// </summary>
        public int liveStatus { get; set; }
        public string url { get; set; }
        public string title { get; set; }
        public string cover { get; set; }
        public int online { get; set; }
        public int roomid { get; set; }
        /// <summary>
        /// 轮播状态
        /// </summary>
        public int roundStatus { get; set; }
        public int broadcast_type { get; set; }
    }
}
