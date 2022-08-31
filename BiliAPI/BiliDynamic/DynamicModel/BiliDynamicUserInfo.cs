using BiliAPI.BiliUser.UserModel;

namespace BiliAPI.BiliDynamic.DynamicModel
{
    public struct BiliDynamicUserInfo
    {
        public long? uid { get; set; }
        public string? uname { get; set; }
        public string? face { get; set; }
        public int? face_nft { get; set; }
        public BiliVip? vip { get; set; }
    }
}
