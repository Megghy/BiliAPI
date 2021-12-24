namespace BiliAPI.BiliDynamic.DynamicModel
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public class BiliDynamicCardAttribute : Attribute
    {
        public BiliDynamicCardAttribute(DynamicType type)
        {
            TargetType = type;
        }
        /// <summary>
        /// 目标类型
        /// </summary>
        public DynamicType TargetType { get; set; }
    }
}
