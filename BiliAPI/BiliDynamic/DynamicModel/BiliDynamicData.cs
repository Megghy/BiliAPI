using BiliAPI.BiliDynamic.DynamicEntity;
using BiliAPI.BiliDynamic.DynamicEntity.BiliH5Dynamic;
using BiliAPI.BiliDynamic.DynamicEntity.BiliVideoDynamic;
using BiliAPI.BiliInfo;

namespace BiliAPI.BiliDynamic.DynamicModel
{
    public struct BiliDynamicData : IBiliData
    {
        /// <summary>
        /// 是否还有更多动态
        /// </summary>
        public bool has_more { get; set; }
        public BiliDynamicAttentions? attentions { get; set; }
        public BiliDynamicCardContainer<IBiliDynamicCard>[]? cards { get; set; }
        public long next_offset { get; set; }
        public int _gt_ { get; set; }

        //private static MethodInfo? deserializer = typeof(Utils).GetMethod("Deserialize");
        internal void DeserializeCard()
        {
            if (cards is null)
                return;
            for (int i = 0; i < cards.Length; i++)
            {
                var cardJson = cards[i].card;
                /*if (Condition.dynamicDict.ContainsKey(type))
                    {
                        deserializer?.MakeGenericMethod(Condition.dynamicDict[type]);
                        deserializer?.Invoke(null, new object[] { card.card }) as Condition.dynamicDict[type];
                    }
                        card.cardData(Utils.Deserialize<>());*/
                cards[i].cardData = (DynamicType)(cards[i].desc?.type ?? -1) switch
                {
                    DynamicType.Forward => BiliForwordDynamicData.Get(cardJson),
                    DynamicType.H5 => BiliH5DynamicData.Get(cardJson),
                    DynamicType.Video => BiliVideoDynamicData.Get(cardJson),
                    _ => null,
                };
            }
        }
    }
}
