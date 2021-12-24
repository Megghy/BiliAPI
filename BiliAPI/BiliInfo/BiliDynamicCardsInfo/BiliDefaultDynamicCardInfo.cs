using BiliAPI.BiliDynamic.DynamicModel;
using BiliAPI.BiliInterface;

namespace BiliAPI.BiliInfo.BiliDynamicCardsInfo
{
    public record BiliDefaultDynamicCardInfo : BiliDynamicCardInfoBase<IBiliDynamicCard>
    {
        public BiliDefaultDynamicCardInfo(BiliDynamicCardContainer? card) : base(card)
        {
        }

        public override string Content => CardContainer?.card ?? "null";
    }
}
