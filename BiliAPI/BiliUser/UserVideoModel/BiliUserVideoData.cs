using BiliAPI.BiliInterface;

namespace BiliAPI.BiliUser.UserVideoModel
{
    public struct BiliUserVideoData : IBiliData
    {
        public BiliUserVideoList? list { get; set; }
        public BiliUserVideoPage? page { get; set; }
        public BiliEpisodic_button? episodic_button { get; set; }
    }
}
