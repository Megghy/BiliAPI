using BiliAPI.BiliDynamic.DynamicCard.BiliVideoDynamic;
using BiliAPI.BiliDynamic.DynamicModel;
using BiliAPI.BiliVideo.VideoModel;

namespace BiliAPI.BiliInfo.BiliDynamicCardsInfo
{
    [BiliDynamicCardInfo(DynamicType.Video)]
    public record BiliVideoDynamicCardInfo : BiliDynamicCardInfoBase<BiliVideoDynamicCard>
    {
        public BiliVideoDynamicCardInfo(BiliDynamicCardContainer original) : base(original)
        {
        }

        public override string Content => $"{Card.title}-{Card.desc}";

        /// <summary>
        /// 视频发布时间
        /// </summary>
        public DateTime PublicDate => Card.pubdate.ToDateTime();

        /// <summary>
        /// 视频的avid
        /// </summary>
        public long AVID => Card.aid ?? -1;

        /// <summary>
        /// 视频的bvid
        /// </summary>
        public string BVID => Uri.TryCreate(Card.short_link_v2, UriKind.RelativeOrAbsolute, out var url)
            && url.Segments.FirstOrDefault() is { } id
            ? id
            : "null";

        /// <summary>
        /// 视频第一帧的链接
        /// </summary>
        public string FirstFrameURL => Card.first_frame ?? "null";

        /// <summary>
        /// 视频封面链接
        /// </summary>
        public string CoverURL => Card.pic ?? "null";

        /// <summary>
        /// 视频链接
        /// </summary>
        public string VideoURL => Card.short_link_v2 ?? "null";

        /// <summary>
        /// 视频所属分区的名称
        /// </summary>
        public string VideoZoneName => Card.tname ?? "null";

        /// <summary>
        /// 视频的统计信息
        /// </summary>
        public BiliVideoDynamicStat VideoStat => Card.stat;

        /// <summary>
        /// 视频部分许可(?
        /// </summary>
        public BiliVideoRights VideoRight => Card.rights;
    }
}
