using BiliAPI.BiliDynamic.DynamicModel;
using BiliAPI.BiliInterface;

namespace BiliAPI.BiliDynamic.DynamicCard.BiliPictureDynamic
{
    [BiliDynamicCard(DynamicType.Picture)]
    public struct BiliPictureDynamicCard : IBiliDynamicCard
    {
        public static BiliPictureDynamicCard Get(string? cardJson)
        {
            return Utils.Deserialize<BiliPictureDynamicCard>(cardJson);
        }
        public DynamicType Type => DynamicType.Picture;
        public BiliDynamicUserInfo? user { get; set; }
        public BiliPictureDynamicItem? item { get; set; }
    }
}
