using BiliAPI.BiliDynamic.DynamicCard.BiliTextDynamic;
using BiliAPI.BiliDynamic.DynamicModel;

namespace BiliAPI.BiliInfo.BiliDynamicCardsInfo
{
    [BiliDynamicCardInfo(DynamicType.Text)]
    public record BiliTextDynamicCardInfo : BiliDynamicCardInfoBase<BiliTextDynamicCard>
    {
        public BiliTextDynamicCardInfo(BiliDynamicCardContainer original) : base(original)
        {
        }

        public override string Content => Card.item.content ?? "null";
    }
}
