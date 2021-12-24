using BiliAPI.BiliDynamic.DynamicModel;

namespace BiliAPI.BiliInfo.BiliDynamicCardsInfo
{
    [AttributeUsage(AttributeTargets.Class)]
    public class BiliDynamicCardInfoAttribute : Attribute
    {
        public BiliDynamicCardInfoAttribute(DynamicType type)
        {
            TargetType = type;
        }
        /// <summary>
        /// 目标类型
        /// </summary>
        public DynamicType TargetType { get; set; }
    }
}
