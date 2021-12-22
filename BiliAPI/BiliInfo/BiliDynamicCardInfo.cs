using BiliAPI.BiliDynamic.DynamicModel;

namespace BiliAPI.BiliInfo
{
    /// <summary>
    /// 封装后的动态卡片
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BiliDynamicCardInfo<T> where T : IBiliDynamicCard
    {
        public BiliDynamicCardInfo(BiliDynamicCardContainer<IBiliDynamicCard>? card)
        {
            Card = card;
        }
        /// <summary>
        /// 卡片序列化后的内容
        /// </summary>
        public BiliDynamicCardContainer<IBiliDynamicCard>? Card { get; private set; }

        /// <summary>
        /// 卡片类型
        /// </summary>
        public DynamicType Type => Card?.cardType ?? DynamicType.Error;

    }
}
