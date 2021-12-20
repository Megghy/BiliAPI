using BiliAPI.BiliDynamic.DynamicEntity;
using BiliAPI.BiliDynamic.DynamicEntity.BiliH5Dynamic;
using System.Text.Json.Nodes;

namespace BiliAPI.BiliDynamic.DynamicModel
{
    public struct BiliDynamicData
    {
        /// <summary>
        /// 是否还有更多动态
        /// </summary>
        public bool has_more { get; set; }
        public BiliDynamicAttentions? attentions { get; set; }
        public BiliDynamicCardsItem[]? cards { get; set; }
        public long next_offset { get; set; }
        public int _gt_ { get; set; }

        //private static MethodInfo? deserializer = typeof(Utils).GetMethod("Deserialize");
        internal void SerializeCard()
        {
            if (cards is null)
                return;
            for (int i = 0; i < cards.Length; i++)
            {
                var card = cards[i];
                var cardJson = card.card;
                /*if (Condition.dynamicDict.ContainsKey(type))
                    {
                        deserializer?.MakeGenericMethod(Condition.dynamicDict[type]);
                        deserializer?.Invoke(null, new object[] { card.card }) as Condition.dynamicDict[type];
                    }
                        card.cardData(Utils.Deserialize<>());*/
                switch ((DynamicType)(card.desc?.type ?? -1))
                {
                    case DynamicType.Forward:
                        card.cardData = BiliForwordDynamicData.Get(cardJson);
                        break;
                    case DynamicType.H5:
                        card.cardData = BiliH5DynamicData.Get(cardJson);
                        break;
                    default:
                        card.cardData = JsonNode.Parse(cardJson);
                        break;
                }
            }
        }
    }
}
