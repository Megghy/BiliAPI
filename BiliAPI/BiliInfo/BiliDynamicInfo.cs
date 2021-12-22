using BiliAPI.BiliDynamic.DynamicModel;

namespace BiliAPI.BiliInfo
{
    /// <summary>
    /// 封装后的动态页信息
    /// </summary>
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

        /// <summary>
        /// 本页所有动态卡片(一般为12个
        /// </summary>
        public BiliDynamicCardInfo<IBiliDynamicCard>[] Cards { get; private set; }
    }
}
