using BiliAPI.BiliDynamic.DynamicCard;
using BiliAPI.BiliDynamic.DynamicModel;
using BiliAPI.BiliInterface;

namespace BiliAPI.BiliInfo.BiliDynamicCardsInfo
{
    [BiliDynamicCardInfo(DynamicType.Forward)]
    public record BiliForwordDynamicCardInfo : BiliDynamicCardInfoBase<BiliForwordDynamicCard>
    {
        public BiliForwordDynamicCardInfo(BiliDynamicCardContainer original) : base(original)
        {
        }
        /// <summary>
        /// 转发时的内容, 形如 => 好//@蒙古上单: 柠檬什么时候酸啊//Cherry: 你所热爱的, 就是你的生活
        /// </summary>
        public override string Content => Card.item?.content ?? "null";

        /// <summary>
        /// 原动态的内容
        /// </summary>
        public IBiliDynamicCard? OriginCard => Card.originData;

        /// <summary>
        /// 原动态类型
        /// </summary>

        public DynamicType? OriginCardType => Card.originData?.Type;

        /// <summary>
        /// 原动态作者信息
        /// </summary>

        public BiliUserInfo OriginAuthor => new(Card.origin_user);

        /// <summary>
        /// content里回复到的用户id
        /// </summary>
        public int[] Ats => Card.item?.at_uids ?? Array.Empty<int>();
    }
}
