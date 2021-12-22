namespace BiliAPI.BiliDynamic.DynamicEntity.BiliForwordDynamic
{
    public struct BiliForwordDynamicItem
    {
        public string at_control { get; set; }
        public string category { get; set; }
        public string description { get; set; }
        public int id { get; set; }
        public bool is_fav { get; set; }
        public BiliPictureItem[] pictures { get; set; }
        public int pictures_count { get; set; }
        public int reply { get; set; }
        public string[]? role { get; set; }
        public BiliForwordDynamicSettings? settings { get; set; }
        public string[]? source { get; set; }
        public string title { get; set; }
        public long upload_time { get; set; }
    }
}
