using BiliAPI.BiliDynamic.DynamicCard.BiliPictureDynamic;
using BiliAPI.BiliDynamic.DynamicModel;

namespace BiliAPI.BiliInfo.BiliDynamicCardsInfo
{
    [BiliDynamicCardInfo(DynamicType.Picture)]
    public record BiliPictureDynamicCardInfo : BiliDynamicCardInfoBase<BiliPictureDynamicCard>
    {
        public BiliPictureDynamicCardInfo(BiliDynamicCardContainer original) : base(original)
        {
        }

        public override string Content => Card.item?.description ?? "null";

        /// <summary>
        /// 标题, 不确定有没有
        /// </summary>
        public string Title => Card.item?.title ?? "null";

        /// <summary>
        /// 所属分类名
        /// </summary>
        public string Category => Card.item?.category ?? "null";

        /// <summary>
        /// 所有图片的详细信息
        /// </summary>
        public BiliPictureDynamicPics[] Pictures => Card.item?.pictures ?? Array.Empty<BiliPictureDynamicPics>();

        /// <summary>
        /// 所有图片的链接
        /// </summary>
        public string[] PicturesURL => Card.item?.pictures?.Select(p => p.img_src ?? "null").ToArray() ?? Array.Empty<string>();

        /// <summary>
        /// 图片数量
        /// </summary>
        public int PictureCount => (int)(Card.item?.pictures_count ?? -1);
    }
}
