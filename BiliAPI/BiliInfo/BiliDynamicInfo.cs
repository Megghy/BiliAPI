using BiliAPI.BiliDynamic.DynamicModel;

namespace BiliAPI.BiliInfo
{
    public class BiliDynamicInfo : BiliInfoBase<BiliDynamicData>
    {
#pragma warning disable CS8618
        public BiliDynamicInfo(string originJson) : base(originJson)
#pragma warning restore CS8618
        {
            if (Root == null)
                return;

            Root?.data.DeserializeCard();
            Cards = (from card
                     in Root!.data.cards
                     select new BiliDynamicCardInfo<IBiliDynamicCard>(card)).ToArray();
        }

        public BiliDynamicCardInfo<IBiliDynamicCard>[] Cards { get; private set; }
    }
}
