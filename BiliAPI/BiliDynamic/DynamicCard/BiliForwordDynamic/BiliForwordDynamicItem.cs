using BiliAPI.BiliDynamic.DynamicModel;

namespace BiliAPI.BiliDynamic.DynamicCard.BiliForwordDynamic
{
    public struct BiliForwordDynamicItem
    {
        public long? rp_id { get; set; }
        public int uid { get; set; }
        public string? content { get; set; }
        public string? ctrl { get; set; }
        public long? orig_dy_id { get; set; }
        public long? pre_dy_id { get; set; }
        public long? timestamp { get; set; }
        public int[]? at_uids { get; set; }
        public int? reply { get; set; }
        public DynamicType orig_type { get; set; }
    }
}
