using BiliAPI.BiliDynamic.DynamicModel;
using BiliAPI.BiliUser.UserModel;

namespace BiliAPI.BiliInfo
{
    /// <summary>
    /// 封装后的用户信息
    /// </summary>
    public class BiliUserInfo : BiliInfoBase<BiliUserData>
    {
        public BiliUserInfo(string originJson) : base(originJson)
        {
        }
        public BiliUserInfo(BiliDynamicUserProfile? data) : base(null)
        {
            Root = new() { code = 0, ttl = 1, data = new(data) };
        }
        #region 基础信息
        /// <summary>
        /// 用户mid
        /// </summary>
        public int ID => Data.mid ?? -1;
        /// <summary>
        /// 用户名
        /// </summary>
        public string Name => Data.name ?? "null";

        /// <summary>
        /// 性别
        /// </summary>
        public BiliSex Sex => Data.sex == "男" ? BiliSex.Male : Data.sex == "女" ? BiliSex.Female : BiliSex.Secret;

        /// <summary>
        /// 签名
        /// </summary>
        public string Sign => Data.sign ?? "null";

        /// <summary>
        /// 生日
        /// </summary>
        public string Birthday => Data.birthday ?? "null";

        /// <summary>
        /// 等级
        /// </summary>
        public int Level => Data.level ?? -1;


        public string AvatarURL => Data.face ?? "null";

        /// <summary>
        /// 标签
        /// </summary>
        public string[] Tags => Data.tags ?? Array.Empty<string>();
        #endregion

        #region 直播间信息
        /// <summary>
        /// 直播间id
        /// </summary>
        public long LiveRoomID => Data.live_room?.roomid ?? -1;

        /// <summary>
        /// 直播间标题
        /// </summary>
        public string LivrRoomTitle => Data.live_room?.title ?? "null";

        /// <summary>
        /// 直播间地址
        /// </summary>
        public string LiveRoomURL => Data.live_room?.url ?? "null";

        /// <summary>
        /// 直播间封面地址
        /// </summary>
        public string LiveRoomCoverURL => Data.live_room?.cover ?? "null";

        /// <summary>
        /// 直播间人气
        /// </summary>
        public int LiveRoomOnlineCount => Data.live_room?.online ?? -1;

        /// <summary>
        /// 是否直播中
        /// </summary>
        public bool IsLiving => Data.live_room?.liveStatus == 1;

        /// <summary>
        /// 是否轮播中
        /// </summary>
        public bool IsLiveRound => Data.live_room?.roundStatus == 1;
        #endregion

        #region 大会员信息
        /// <summary>
        /// 大会员过期时间
        /// </summary>
        public DateTime VIPDueDate => Data.vip?.due_date.ToDateTime() ?? DateTime.MinValue;

        /// <summary>
        /// 是否是大会员
        /// </summary>
        public bool IsHaveVIP => Data.vip?.status == 1;

        /// <summary>
        /// 大会员类型
        /// </summary>
        public BiliVIPType VIPType => (BiliVIPType)(Data.vip?.type ?? 0);
        #endregion

        #region 粉丝勋章
        /// <summary>
        /// 粉丝勋章所属用户
        /// </summary>
        public long BadgeTarget => Data.fans_medal?.medal?.target_id ?? -1;

        /// <summary>
        /// 勋章id
        /// </summary>
        public int BadgeID => Data.fans_medal?.medal?.medal_id ?? -1;

        /// <summary>
        /// 粉丝勋章等级
        /// </summary>
        public int BadgeLevel => Data.fans_medal?.medal?.level ?? -1;

        /// <summary>
        /// 粉丝勋章显示名称
        /// </summary>
        public string BadgeName => Data.fans_medal?.medal?.medal_name ?? "null";

        /// <summary>
        /// 粉丝勋章当前亲密度
        /// </summary>
        public int BadgeCurrentIntimacy => Data.fans_medal?.medal?.intimacy ?? -1;

        /// <summary>
        /// 粉丝勋章升级所需亲密度
        /// </summary>
        public int BadgeNextIntimacy => Data.fans_medal?.medal?.next_intimacy ?? -1;

        /// <summary>
        /// 粉丝勋章每日亲密度限制
        /// </summary>
        public int BadgeInitmacyDayLimit => Data.fans_medal?.medal?.day_limit ?? -1;

        /// <summary>
        /// 粉丝勋章总亲密度
        /// </summary>
        public int BadgeTotalIntimacy => Data.fans_medal?.medal?.score ?? -1;

        /// <summary>
        /// 是否拥有粉丝勋章
        /// </summary>
        public bool IsHaveBadge => Data.fans_badge;

        /// <summary>
        /// 是否在佩戴粉丝勋章
        /// </summary>
        public bool IsWearingBadge => Data.fans_medal?.wear ?? false;

        /// <summary>
        /// 是否点亮粉丝勋章
        /// </summary>
        public bool IsBadgeLighted => Data.fans_medal?.medal?.is_lighted ?? false;
        #endregion
    }
}
