using BiliAPI.BiliVideo.VideoModel;

namespace BiliAPI.BiliInfo
{
    public class BiliVideoItemInfo
    {
        public BiliVideoItemInfo(BiliVlistItem video)
        {
            Video = video;
        }
        public BiliVlistItem Video { get; private set; }
    }
}
