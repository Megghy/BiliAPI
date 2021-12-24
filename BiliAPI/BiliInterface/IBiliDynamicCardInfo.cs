using BiliAPI.BiliDynamic.DynamicModel;
using BiliAPI.BiliInfo;

namespace BiliAPI.BiliInterface
{
    public interface IBiliDynamicCardInfo
    {
        public BiliDynamicCardContainer? CardContainer { get; }
        public IBiliDynamicCard? Card { get; }
        public DynamicType Type { get; }
        public BiliUserInfo Author { get; }
        public long ID { get; }
        public int ReplyCount { get; }
        public int RepostCount { get; }
        public int LikeCount { get; }
        public string Content { get; }
        public DateTime CreateDate { get; }
    }
}
