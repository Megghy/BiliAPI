using BiliAPI.BiliDynamic.DynamicModel;

namespace BiliAPI.BiliInfo
{
    /// <summary>
    /// 封装后的动态页信息
    /// </summary>
    public class BiliDynamicsInfo : BiliInfoBase<BiliDynamicData>
    {
#pragma warning disable CS8618
        public BiliDynamicsInfo(string originJson) : base(originJson)
#pragma warning restore CS8618
        {
            if (Root == null)
                return;

            Root?.data.DeserializeCard();

            if (Root!.data.cards?.Any() ?? false)
                Cards = ((from card
                         in Root!.data.cards
                         select new BiliDynamicCardInfo<IBiliDynamicCard>(card)) ?? Array.Empty<BiliDynamicCardInfo<IBiliDynamicCard>>()).ToArray();
            else
                Cards = Array.Empty<BiliDynamicCardInfo<IBiliDynamicCard>>();
        }

        /// <summary>
        /// 本页所有动态卡片(一般为12个
        /// </summary>
        public BiliDynamicCardInfo<IBiliDynamicCard>[] Cards { get; private set; }
    }
}
