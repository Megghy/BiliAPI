using BiliAPI.BiliDynamic.DynamicModel;
using BiliAPI.BiliInterface;

namespace BiliAPI.BiliInfo.BiliDynamicCardsInfo
{
    /// <summary>
    /// 封装后的动态卡片信息
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract record BiliDynamicCardInfoBase<T> : IBiliDynamicCardInfo where T : IBiliDynamicCard
    {
        public BiliDynamicCardInfoBase(BiliDynamicCardContainer? card)
        {
            CardContainer = card;
        }
        /// <summary>
        /// 卡片序列化后的所有内容
        /// </summary>
        public BiliDynamicCardContainer? CardContainer { get; init; }

        /// <summary>
        /// 动态卡片具体内容
        /// </summary>
        public T? Card => CardContainer?.cardData is null ? default : (T?)CardContainer?.cardData;

        /// <summary>
        /// 卡片类型
        /// </summary>
        public DynamicType Type => CardContainer?.cardType ?? DynamicType.Error;

        /// <summary>
        /// 动态的作者, 部分字段可能不存在
        /// </summary>
        public virtual BiliUserInfo Author => new(CardContainer?.desc?.user_profile);
        /// <summary>
        /// 动态的id
        /// </summary>
        public long ID => CardContainer?.desc?.dynamic_id ?? -1;

        /// <summary>
        /// 回复数量
        /// </summary>
        public int ReplyCount => CardContainer?.desc?.comment ?? -1;

        /// <summary>
        /// 转发数量
        /// </summary>
        public int RepostCount => CardContainer?.desc?.repost ?? -1;

        /// <summary>
        /// 点赞数量
        /// </summary>
        public int LikeCount => CardContainer?.desc?.like ?? -1;

        /// <summary>
        /// 内容(部分
        /// </summary>
        public abstract string Content { get; }

        /// <summary>
        /// 上传日期
        /// </summary>
        public virtual DateTime CreateDate => CardContainer?.desc?.timestamp.ToDateTime() ?? DateTime.MinValue;

        IBiliDynamicCard? IBiliDynamicCardInfo.Card => Card;
    }
}
