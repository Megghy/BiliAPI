using BiliAPI.BiliUser.UserVideoModel;

namespace BiliAPI.BiliInfo
{
    /// <summary>
    /// 封装的单个视频信息
    /// </summary>
    public class BiliUserVideoItemInfo
    {
        public BiliUserVideoItemInfo(BiliUserVlistItem video)
        {
            Video = video;
        }
        /// <summary>
        /// 反序列化后的视频信息
        /// </summary>
        public BiliUserVlistItem Video { get; private set; }
        #region 常用信息
        /// <summary>
        /// bv号
        /// </summary>
        public string BVID => Video.bvid ?? "null";

        /// <summary>
        /// 标题
        /// </summary>
        public string Title => Video.title ?? "null";

        /// <summary>
        /// 描述
        /// </summary>
        public string Description => Video.description ?? "null";

        /// <summary>
        /// 封面地址
        /// </summary>
        public string CoverURL => Video.pic ?? "null";

        /// <summary>
        /// 时长
        /// </summary>
        public TimeSpan Length => (Video.length?.Contains(':') ?? false)
            && Video.length?.Split(':').Select(s => int.Parse(s)).ToArray() is { } tempLength 
            ? new TimeSpan(0, tempLength[0], tempLength[1])
            : TimeSpan.MinValue;

        /// <summary>
        /// 字符串形式的视频时长 (00:00)
        /// </summary>
        public string LengthText => Video.length ?? "null";

        /// <summary>
        /// 视频创建时间
        /// </summary>
        public DateTime CreateDate => Video.created.ToDateTime();

        /// <summary>
        /// 评论数
        /// </summary>
        public int CommentCount => Video.comment ?? -1;

        /// <summary>
        /// 弹幕数
        /// </summary>
        public int DanmakuCount => Video.video_review ?? -1;

        /// <summary>
        /// 播放次数
        /// </summary>
        public int PlayCount => Video.play ?? -1;
        #endregion
    }
}
