using BiliAPI.BiliInfo;

namespace BiliAPI.BiliVideo.VideoModel
{
    public struct BiliVideoData : IBiliData
    {
        public BiliVideoList? list { get; set; }
        public BiliVideoPage? page { get; set; }
        public BiliEpisodic_button? episodic_button { get; set; }
    }
}
