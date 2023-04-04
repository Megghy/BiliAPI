using BiliAPI.BiliDynamic.DynamicModel;
using BiliAPI.BiliDynamicV2.DyncmicV2Model;
using BiliAPI.BiliUser.UserModel;

namespace BiliAPI.BiliDynamicV2.BiliDynamicV2Modules
{
    public struct BiliDynamicV2AuthorModule
    {
        public BiliDynamicV2Avatar avatar { get; set; }
        public BiliDynamicDecorateCard decorate { get; set; }
        public string face { get; set; }
        public bool face_nft { get; set; }
        public string? following { get; set; }
        public string jump_url { get; set; }
        public string label { get; set; }
        public int mid { get; set; }
        public string name { get; set; }
        public BiliOfficialVerify official_verify { get; set; }
        public BiliPendant pendant { get; set; }
        public string pub_action { get; set; }
        public string pub_location_text { get; set; }
        public string pub_time { get; set; }
        public long pub_ts { get; set; }
        public string type { get; set; }
        public BiliVip vip { get; set; }
    }
}
