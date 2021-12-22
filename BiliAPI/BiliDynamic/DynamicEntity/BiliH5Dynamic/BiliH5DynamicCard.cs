using BiliAPI.BiliDynamic.DynamicModel;

namespace BiliAPI.BiliDynamic.DynamicEntity.BiliH5Dynamic
{
    public struct BiliH5DynamicCard : IBiliDynamicCard
    {
        public DynamicType Type => DynamicType.H5;
        public static BiliH5DynamicCard Get(string? cardJson)
        {
            return Utils.Deserialize<BiliH5DynamicCard>(cardJson);
        }
        public long? rid { get; set; }
        public BiliDynamicUserInfo user { get; set; }
        public BiliH5DynamicVest vest { get; set; }
        public BiliH5DynamicSketch sketch { get; set; }
    }
}
