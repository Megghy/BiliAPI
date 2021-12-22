using BiliAPI.BiliUser.UserVideoModel;

namespace BiliAPI.BiliInfo
{
    /// <summary>
    /// 封装后的视频信息
    /// </summary>
    public class BiliUserVideoInfo : BiliInfoBase<BiliUserVideoData>
    {
#pragma warning disable CS8618
        public BiliUserVideoInfo(string originJson) : base(originJson)
#pragma warning restore CS8618
        {
            if (Root == null)
                return;
            Videos = (from card
                      in Root!.data.list?.vlist
                      select new BiliUserVideoItemInfo(card)).ToArray();
        }

        /// <summary>
        /// 本页的视频列表, 最多30个
        /// </summary>
        public BiliUserVideoItemInfo[] Videos { get; private set; }
    }
}
