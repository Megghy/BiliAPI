namespace BiliAPI.BiliDynamic.DynamicModel
{
    /// <summary>
    /// 动态相关信息
    /// </summary>
    public struct BiliDynamicDesc
    {
        public int? uid { get; set; }
        public int? type { get; set; }
        public long? rid { get; set; }
        public int? acl { get; set; }
        public int? view { get; set; }
        public int? repost { get; set; }
        public int? comment { get; set; }
        public int? like { get; set; }
        public bool is_liked { get; set; }
        public long? dynamic_id { get; set; }
        public long? timestamp { get; set; }
        public long? pre_dy_id { get; set; }
        public long? orig_dy_id { get; set; }
        public int? orig_type { get; set; }
        public BiliDynamicUserProfile? user_profile { get; set; }
        public int? uid_type { get; set; }
        public int? stype { get; set; }
        public int? r_type { get; set; }
        public int? inner_id { get; set; }
        public int? status { get; set; }
        public string? dynamic_id_str { get; set; }
        public string? pre_dy_id_str { get; set; }
        public string? orig_dy_id_str { get; set; }
        public string? rid_str { get; set; }
        public BiliDynamicOrigin? origin { get; set; }
        public BiliDynamicPrevious? previous { get; set; }
    }
}
