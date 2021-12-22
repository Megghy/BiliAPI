using BiliAPI.BiliDynamic.DynamicModel;

namespace BiliAPI.BiliDynamic.DynamicEntity.BiliTextDynamic
{
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
