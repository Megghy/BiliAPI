namespace BiliAPI.BiliDynamic.DynamicEntity.BiliForwordDynamic
{
    public struct BiliForwordDynamicItem
    {
        public string at_control { get; set; }
        public string category { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// 动态ID
        /// </summary>
        public int id { get; set; }
        public bool is_fav { get; set; }

        /// <summary>
        /// 动态内图片
        /// </summary>
        public BiliPictureItem[] pictures { get; set; }

        /// <summary>
        /// 图片数量
        /// </summary>
        public int pictures_count { get; set; }

        /// <summary>
        /// 回复数量
        /// </summary>
        public int reply { get; set; }

        /// <summary>
        /// ?
        /// </summary>
        public string[]? role { get; set; }

        /// <summary>
        /// 动态设置
        /// </summary>
        public BiliForwordDynamicSettings? settings { get; set; }

        /// <summary>
        /// ?
        /// </summary>
        public string[]? source { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// 发布时间
        /// </summary>
        public long upload_time { get; set; }
    }
}
