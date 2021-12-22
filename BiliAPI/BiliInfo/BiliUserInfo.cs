using BiliAPI.BiliUser.UserModel;

namespace BiliAPI.BiliInfo
{
    public class BiliUserInfo : BiliInfoBase<BiliUserData>
    {
        public BiliUserInfo(string originJson) : base(originJson)
        {
        }
    }
}
