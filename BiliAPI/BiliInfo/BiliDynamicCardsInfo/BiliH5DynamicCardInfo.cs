using BiliAPI.BiliDynamic.DynamicCard.BiliH5Dynamic;
using BiliAPI.BiliDynamic.DynamicModel;

namespace BiliAPI.BiliInfo.BiliDynamicCardsInfo
{
    [BiliDynamicCardInfo(DynamicType.H5)]
    public record BiliH5DynamicCardInfo : BiliDynamicCardInfoBase<BiliH5DynamicCard>
    {

        public BiliH5DynamicCardInfo(BiliDynamicCardContainer original) : base(original)
        {
        }
        public override string Content => Card.vest.content ?? "null";
    }
}
