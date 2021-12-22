using BiliAPI.BiliDynamic.DynamicEntity;
using BiliAPI.BiliDynamic.DynamicEntity.BiliTextDynamic;
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
        //public BiliUserInfo? Author => Card?.desc?.
        /// <summary>
        /// 尝试获取文本格式的内容
        /// </summary>
        public string? Content => Card?.cardData switch {
            BiliTextDynamicCard text => text.item.content,
            BiliForwordDynamicCard forword => forword.item.description, //todo
            _ => null
        };

    }
}
