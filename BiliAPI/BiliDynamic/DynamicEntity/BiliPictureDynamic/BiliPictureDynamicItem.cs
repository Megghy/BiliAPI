namespace BiliAPI.BiliDynamic.DynamicEntity.BiliPictureDynamic
{
    public struct BiliPictureDynamicItem
    {
        public string? at_control { get; set; }
        public string? category { get; set; }
        public string? description { get; set; }
        public long? id { get; set; }
        public bool is_fav { get; set; }
        public BiliPictureDynamicPics[]? pictures { get; set; }
        public int? pictures_count { get; set; }
        public int? reply { get; set; }
        public BiliDynamicSettings? settings { get; set; }
        public string? title { get; set; }
        public long? upload_time { get; set; }
    }
}
