using BiliAPI.BiliDynamic.DynamicCard.BiliAudioDynamic;
using BiliAPI.BiliDynamic.DynamicModel;

namespace BiliAPI.BiliInfo.BiliDynamicCardsInfo
{
    [BiliDynamicCardInfo(DynamicType.Audio)]
    public record BiliAudioDynamicCardInfo : BiliDynamicCardInfoBase<BiliAudioDynamicCard>
    {
        public BiliAudioDynamicCardInfo(BiliDynamicCardContainer original) : base(original)
        {
        }

        public override string Content => $"{Card.title}-{Card.intro}";

        /// <summary>
        /// 标题
        /// </summary>
        public string Title => Card.title ?? "null";

        /// <summary>
        /// 描述
        /// </summary>
        public string Description => Card.intro ?? "null";

        /// <summary>
        /// 音频的发布时间
        /// </summary>
        public DateTime AudioCreateDate => Card.ctime.ToDateTime();

        /// <summary>
        /// 封面链接
        /// </summary>
        public string CoverURL => Card.cover ?? "null";

        /// <summary>
        /// 音频id
        /// </summary>
        public int AudioID => Card.id ?? -1;


        /// <summary>
        /// 播放次数
        /// </summary>
        public int PlayCount => Card.playCnt ?? -1;
    }
}
