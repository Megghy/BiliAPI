using BiliAPI.BiliDynamic.DynamicModel;
using BiliAPI.BiliInfo.BiliDynamicCardsInfo;
using BiliAPI.BiliInterface;
using System.Reflection;

namespace BiliAPI.BiliInfo
{
    /// <summary>
    /// 封装后的用户动态页信息
    /// </summary>
    public class BiliUserDynamicsInfo : BiliInfoBase<BiliUserDynamicsData>
    {
#pragma warning disable CS8618
        private static Dictionary<DynamicType, Type> dynamicCardDict;
        public BiliUserDynamicsInfo(string originJson) : base(originJson)
#pragma warning restore CS8618
        {
            if (Root == null)
                return;

            Root?.data.DeserializeCard();

            if (Root!.data.cards?.Any() ?? false)
                Cards = ((from card
                         in Root!.data.cards
                          select Get(card)) ?? Array.Empty<BiliDynamicCardInfoBase<IBiliDynamicCard>>()).ToArray();
            else
                Cards = Array.Empty<BiliDynamicCardInfoBase<IBiliDynamicCard>>();
        }

        internal static IBiliDynamicCardInfo? Get(BiliDynamicCardContainer card)
        {
            if (card.cardType is null)
                throw new ArgumentNullException(nameof(card.cardType));
            dynamicCardDict ??= Assembly
                    .GetExecutingAssembly()
                    .GetTypes()
                    .Where(t => t.GetCustomAttribute<BiliDynamicCardInfoAttribute>() != null)
                    .ToDictionary(t => t.GetCustomAttribute<BiliDynamicCardInfoAttribute>()!.TargetType, t => t);
            if (dynamicCardDict.TryGetValue(card.cardType!.Value, out var t))
                return Activator.CreateInstance(t, new object[] { card }) as IBiliDynamicCardInfo;
            else
                return new BiliDefaultDynamicCardInfo(card);
        }

        /// <summary>
        /// 本页所有动态卡片(一般为12个
        /// </summary>
        public IBiliDynamicCardInfo[] Cards { get; private set; }
    }
}
