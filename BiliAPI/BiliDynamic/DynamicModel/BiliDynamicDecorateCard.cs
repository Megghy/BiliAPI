namespace BiliAPI.BiliDynamic.DynamicModel
{
    public struct BiliDynamicDecorateCard
    {
        public int? mid { get; set; }
        public int? id { get; set; }
        public string? card_url { get; set; }
        public int? card_type { get; set; }
        public string? name { get; set; }
        public long? expire_time { get; set; }
        public string? card_type_name { get; set; }
        public int? uid { get; set; }
        public int? item_id { get; set; }
        public int? item_type { get; set; }
        public string? big_card_url { get; set; }
        public string? jump_url { get; set; }
        public BiliDynamicFan? fan { get; set; }
        public string? image_enhance { get; set; }
    }
}
