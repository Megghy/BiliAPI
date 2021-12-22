using BiliAPI.BiliInfo;
using BiliAPI.BiliUser.UserModel;

namespace BiliAPI.BiliVideo.VideoModel
{
    public struct BiliVideoData : IBiliData
    {
        public string? bvid { get; set; }
        public long? aid { get; set; }
        public int? videos { get; set; }
        public long? tid { get; set; }
        public string? tname { get; set; }
        public bool copyright { get; set; }
        public string? pic { get; set; }
        public string? title { get; set; }
        public long? pubdate { get; set; }
        public long? ctime { get; set; }
        public string? desc { get; set; }
        public BiliVideoDescV2[] desc_v2 { get; set; }
        public int? state { get; set; }
        public int? duration { get; set; }
        public BiliVideoRights rights { get; set; }
        public BiliVideoOwner owner { get; set; }
        public BiliVideoStat stat { get; set; }
        public string? @dynamic { get; set; }
        public long? cid { get; set; }
        public BiliVideoDimision dimension { get; set; }
        public bool no_cache { get; set; }
        public BiliVideoPageItem[]? pages { get; set; }
        public BiliVideoSubtitle subtitle { get; set; }
        public BiliUserGarb user_garb { get; set; }
        public BiliUserData[]? stuff { get; set; }
    }
}
