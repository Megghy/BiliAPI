using BiliAPI.BiliDynamicV2.DyncmicV2Model;

namespace BiliAPI.BiliInfo
{
    /// <summary>
    /// 封装后的用户动态页信息
    /// </summary>
    public class BiliUserDynamicsV2Info : BiliInfoBase<BiliDynamicV2Data>
    {
        public BiliUserDynamicsV2Info(string originJson) : base(originJson)
        {
        }
    }
}
