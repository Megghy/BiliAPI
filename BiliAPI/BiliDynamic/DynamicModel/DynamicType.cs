using System.ComponentModel;

namespace BiliAPI.BiliDynamic.DynamicModel
{
    /// <summary>
    /// 动态类型
    /// </summary>
    [DefaultValue(Unkonwn)]
    public enum DynamicType
    {
        /// <summary>
        /// 错误
        /// </summary>
        Error = -1,

        /// <summary>
        /// 未知类型
        /// </summary>
        Unkonwn = 0,

        /// <summary>
        /// 未知类型1
        /// </summary>
        Unkonwn1 = 268435455,

        /// <summary>
        /// 转发动态
        /// </summary>
        Forward = 1,

        /// <summary>
        /// 图片动态
        /// </summary>
        Picture = 2,

        /// <summary>
        /// 文本动态
        /// </summary>
        Text = 4,

        /// <summary>
        /// 视频动态
        /// </summary>
        Video = 8,

        /// <summary>
        /// 小视频动态
        /// </summary>
        ShortVideo = 16,

        /// <summary>
        /// 或许是戏剧
        /// </summary>
        Drama = 32,

        /// <summary>
        /// 专栏动态
        /// </summary>
        Column = 64,

        /// <summary>
        /// 音频动态
        /// </summary>
        Audio = 256,

        /// <summary>
        /// 番剧动态
        /// </summary>
        Bangumi = 512,

        /// <summary>
        /// 未知2
        /// </summary>
        UnKnown2 = 1024,

        /// <summary>
        /// H5动态(活动
        /// </summary>
        H5 = 2048,

        /// <summary>
        /// 漫画分享
        /// </summary>
        Comics = 2049,

        /// <summary>
        /// PGC番剧分享
        /// </summary>
        PGC = 4097,

        /// <summary>
        /// 电影动态
        /// </summary>
        Movie = 4098,

        /// <summary>
        /// 电视剧动态
        /// </summary>
        TVSeries = 4099,

        /// <summary>
        /// 国创动漫
        /// </summary>
        NationalCreationAnimation = 4100,

        /// <summary>
        /// 纪录片动态
        /// </summary>
        Documentary = 4101,

        /// <summary>
        /// 直播1
        /// </summary>
        Live1 = 4200,

        /// <summary>
        /// 直播2
        /// </summary>
        Live2 = 4201,

        /// <summary>
        /// 收藏夹
        /// </summary>
        Favorites = 4300,

        /// <summary>
        /// 付费课程1
        /// </summary>
        PaidCourses1 = 4302,

        /// <summary>
        /// 付费课程2
        /// </summary>
        PaidCourses2 = 4303,

        /// <summary>
        /// 直播3
        /// </summary>
        Live3 = 4308,

        /// <summary>
        /// 合集
        /// </summary>
        Collect = 4310,

        /// <summary>
        /// 未知3
        /// </summary>
        Unkown3 = 4311,

        /// <summary>
        /// 未知4
        /// </summary>
        Unkown4 = 1001,
    }
}
