using BiliAPI.BiliDynamic.DynamicCard.BiliColumnDynamic;
using BiliAPI.BiliDynamic.DynamicModel;

namespace BiliAPI.BiliInfo.BiliDynamicCardsInfo
{
    [BiliDynamicCardInfo(DynamicType.Column)]
    public record BiliColumnDynamicCardInfo : BiliDynamicCardInfoBase<BiliColumnDynamicCard>
    {
        public BiliColumnDynamicCardInfo(BiliDynamicCardContainer original) : base(original)
        {
        }
        /// <summary>
        /// 不是具体内容
        /// </summary>
        public override string Content => Card.title ?? "null";

        /// <summary>
        /// 专栏标题
        /// </summary>
        public string Title => Card.title ?? "null";

        /// <summary>
        /// 专栏描述
        /// </summary>
        public string Description => Card.summary ?? "null";

        /// <summary>
        /// 专栏id
        /// </summary>
        public long ColunmID => Card.id ?? -1;

        /// <summary>
        /// 字数
        /// </summary>
        public int WordCount => Card.words ?? -1;

        /// <summary>
        /// 头图链接
        /// </summary>
        public string BannerURL => Card.banner_url ?? "null";

        /// <summary>
        /// 所有图片链接
        /// </summary>
        public string[] ImageURLs => Card.image_urls ?? Array.Empty<string>();

        /// <summary>
        /// 源图片链接
        /// </summary>
        public string[] OriginURLs => Card.origin_image_urls ?? Array.Empty<string>();

        /// <summary>
        /// 分区信息
        /// </summary>
        public BiliColumnDynamicCategory[] Categories => Card.categories ?? Array.Empty<BiliColumnDynamicCategory>();

        /// <summary>
        /// 
        /// </summary>
        public BiliColumnDynamicStats Stat => Card.stats;
    }
}
