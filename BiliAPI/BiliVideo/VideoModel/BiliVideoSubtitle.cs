namespace BiliAPI.BiliVideo.VideoModel
{
    public struct BiliVideoSubtitle
    {
        public bool allow_submit { get; set; }
        public BiliVideoSubtitleItem[]? list { get; set; }
    }
}
