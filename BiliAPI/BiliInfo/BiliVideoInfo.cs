using BiliAPI.BiliVideo.VideoModel;

namespace BiliAPI.BiliInfo
{
    public class BiliVideoInfo : BiliInfoBase<BiliVideoData>
    {
#pragma warning disable CS8618
        public BiliVideoInfo(string originJson) : base(originJson)
#pragma warning restore CS8618
        {
            if (Root == null)
                return;
            Videos = (from card
                      in Root!.data.list?.vlist
                      select new BiliVideoItemInfo(card)).ToArray();
        }
        public BiliVideoItemInfo[] Videos { get; private set; }
    }
}
