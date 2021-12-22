using BiliAPI.BiliDynamic.DynamicModel;

namespace BiliAPI.BiliDynamic.DynamicEntity.BiliPictureDynamic
{
    public struct BiliPictureDynamicCard : IBiliDynamicCard
    {
        public static BiliPictureDynamicCard Get(string? cardJson)
        {
            return Utils.Deserialize<BiliPictureDynamicCard>(cardJson);
        }
        public DynamicType Type => DynamicType.Picture;
        public BiliDynamicUserInfo user { get; set; }
        public BiliPictureDynamicPics[] item { get; set; }
    }
}
