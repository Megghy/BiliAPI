using BiliAPI.BiliDynamic.DynamicModel;
using BiliAPI.BiliInterface;

namespace BiliAPI.BiliDynamic.DynamicCard.BiliTextDynamic
{
    [BiliDynamicCard(DynamicType.Text)]
    public struct BiliTextDynamicCard : IBiliDynamicCard
    {
        public static BiliTextDynamicCard Get(string? cardJson)
        {
            return Utils.Deserialize<BiliTextDynamicCard>(cardJson);
        }
        public DynamicType Type => DynamicType.Text;
        public BiliDynamicUserInfo user { get; set; }
        public BiliTextDynamicItem item { get; set; }
    }
}
