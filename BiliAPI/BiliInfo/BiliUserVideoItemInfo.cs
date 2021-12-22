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
        /// 标题
        /// </summary>
        public string? Title => Video.title;
        /// <summary>
        /// 描述
        /// </summary>
        public string? Description => Video.description;
        /// <summary>
        /// 评论数
        /// </summary>
        public int? CommentCount => Video.comment;
        /// <summary>
        /// 弹幕数
        /// </summary>
        public int? DanmakuCount => Video.video_review;
        /// <summary>
        /// 播放次数
        /// </summary>
        public int? PlayCount => Video.play;
        #endregion
    }
}
