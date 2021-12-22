namespace BiliAPI.BiliDynamic.DynamicEntity.BiliH5Dynamic
{
    public struct BiliH5DynamicSketch
    {
        public string? title { get; set; }
        public string? desc_text { get; set; }
        public string? cover_url { get; set; }
        public string? target_url { get; set; }
        public long? sketch_id { get; set; }
        public int? biz_type { get; set; }
        public BiliH5DynamicTagsItem[]? tags { get; set; }
    }
}
