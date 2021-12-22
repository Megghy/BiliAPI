using BiliAPI.BiliVideo.VideoModel;

namespace BiliAPI.BiliInfo
{
    public class BiliVideoInfo : BiliInfoBase<BiliVideoData>
    {
        public BiliVideoInfo(string originJson) : base(originJson)
        {
        }
    }
}
