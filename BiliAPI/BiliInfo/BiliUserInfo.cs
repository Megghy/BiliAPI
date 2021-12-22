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

        /// <summary>
        /// 用户名
        /// </summary>
        public string Name => Data.name;
        /// <summary>
        /// 性别
        /// </summary>
        public BiliSex Sex => Data.sex == "男" ? BiliSex.Male : Data.sex == "女" ? BiliSex.Female : BiliSex.Secret;
        /// <summary>
        /// 签名
        /// </summary>
        public string Sign => Data.sign;
        /// <summary>
        /// 等级
        /// </summary>
        public int Level => Data.level;
    }
}
