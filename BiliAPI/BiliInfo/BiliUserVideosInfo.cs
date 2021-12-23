using BiliAPI.BiliUser.UserVideoModel;

namespace BiliAPI.BiliInfo
{
    /// <summary>
    /// 封装后的视频信息
    /// </summary>
    public class BiliUserVideosInfo : BiliInfoBase<BiliUserVideoData>
    {
#pragma warning disable CS8618
        public BiliUserVideosInfo(string originJson) : base(originJson)
#pragma warning restore CS8618
        {
            if (Root == null)
                return;
            if (Root!.data.list?.vlist?.Any() ?? false)
                Videos = ((from card
                          in Root!.data.list?.vlist
                           select new BiliUserVideoItemInfo(card)) ?? Array.Empty<BiliUserVideoItemInfo>()).ToArray();
            else
                Videos = Array.Empty<BiliUserVideoItemInfo>();
        }

        /// <summary>
        /// 本页的视频列表, 最多30个
        /// </summary>
        public BiliUserVideoItemInfo[] Videos { get; private set; }
    }
}
