using BiliAPI.BiliDynamic.DynamicModel;
using BiliAPI.BiliInterface;

namespace BiliAPI.BiliUser.UserModel
{
    public record BiliUserData : IBiliData
    {
#pragma warning disable CS8618
        public BiliUserData() { }
        /// <summary>
        /// 从动态的用户信息转换为空间用户信息, 部分字段不存在
        /// </summary>
        /// <param name="dynamicUser"></param>
        public BiliUserData(BiliDynamicUserProfile? dynamicUser)
#pragma warning restore CS8618
        {
            if (dynamicUser is null)
                return;
            pendant = dynamicUser?.pendant;
            vip = dynamicUser?.info?.vip;
            mid = dynamicUser?.info?.uid;
            name = dynamicUser?.info?.uname;
            face = dynamicUser?.info?.face;
            face_nft = dynamicUser?.info?.face_nft;
            rank = int.Parse(dynamicUser?.rank ?? "-1");
            sign = dynamicUser?.sign;
        }
        public long? mid { get; set; }
        public string? name { get; set; }
        public string? sex { get; set; }
        public string? face { get; set; }
        public int? face_nft { get; set; }
        public string? sign { get; set; }
        public int? rank { get; set; }
        public int? level { get; set; }
        public int? jointime { get; set; }
        public int? moral { get; set; }
        public int? silence { get; set; }
        public int? coins { get; set; }
        public bool fans_badge { get; set; }
        public BiliMedalInfo? fans_medal { get; set; }
        public BiliOfficialVerify? official { get; set; }
        public BiliVip? vip { get; set; }
        public BiliPendant? pendant { get; set; }
        public BiliNameplate? nameplate { get; set; }
        public BiliUserHonourInfo? user_honour_info { get; set; }
        public bool is_followed { get; set; }
        public string? top_photo { get; set; }
        public BiliLiveRoom? live_room { get; set; }
        public string? birthday { get; set; }
        public BiliSchool? school { get; set; }
        public BiliProfession? profession { get; set; }
        public string[] tags { get; set; }
        public BiliSeries? series { get; set; }

        public bool? is_fake_account { get; set; }
        public bool? is_deleted { get; set; }
    }
}
