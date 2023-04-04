using System.Reflection;
using BiliAPI.BiliInterface;

namespace BiliAPI.BiliDynamic.DynamicModel
{
    public struct BiliUserDynamicsData : IBiliData
    {
        private static Dictionary<DynamicType, MethodInfo>? dynamicDict;
        internal void DeserializeCard()
        {
            if (cards is null)
                return;
            for (int i = 0; i < cards.Length; i++)
            {
                cards[i].cardData = Get((DynamicType)(cards[i].desc?.type ?? -1), cards[i].card);
            }
        }
        internal static IBiliDynamicCard? Get(DynamicType? dynamicType, string? cardJson)
        {
            if (dynamicType is null)
                throw new ArgumentNullException(nameof(dynamicType));
            dynamicDict ??= Assembly
                    .GetExecutingAssembly()
                    .GetTypes()
                    .Where(t => t.GetCustomAttribute<BiliDynamicCardAttribute>() != null)
                    .ToDictionary(t => t.GetCustomAttribute<BiliDynamicCardAttribute>()!.TargetType, t => t.GetMethod("Get", BindingFlags.Static | BindingFlags.Public)!);
            if (dynamicDict.TryGetValue(dynamicType!.Value, out var method))
                return method.Invoke(null, new object[] { cardJson! }) as IBiliDynamicCard;
            return null;
        }

        public bool has_more { get; set; }
        public BiliDynamicAttentions? attentions { get; set; }
        public BiliDynamicCardContainer[]? cards { get; set; }
        public long? next_offset { get; set; }
        public int? _gt_ { get; set; }
    }
}
