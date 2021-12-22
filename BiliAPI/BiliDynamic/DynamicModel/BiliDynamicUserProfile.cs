using BiliAPI.BiliSharedEntity;

namespace BiliAPI.BiliDynamic.DynamicModel
{
    public struct BiliDynamicUserProfile
    {
        public BiliDynamicUserInfo? info { get; set; }
        public BiliCard? card { get; set; }
        public BiliVip? vip { get; set; }
        public BiliDynamicPendant? pendant { get; set; }
        public BiliDynamicDecorateCard? decorate_card { get; set; }
        public string rank { get; set; }
        public string sign { get; set; }
        public BiliDynamicLevelInfo? level_info { get; set; }
    }
}
