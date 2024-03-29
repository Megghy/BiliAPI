﻿namespace BiliAPI.BiliDynamic.DynamicModel
{
    public struct BiliDynamicOrigin
    {
        public long? uid { get; set; }
        public int? type { get; set; }
        public long? rid { get; set; }
        public long? acl { get; set; }
        public int? view { get; set; }
        public int? repost { get; set; }
        public long? dynamic_id { get; set; }
        public long? timestamp { get; set; }
        public int? uid_type { get; set; }
        public int? r_type { get; set; }
        public int? status { get; set; }
        public string? dynamic_id_str { get; set; }
        public string? pre_dy_id_str { get; set; }
        public string? orig_dy_id_str { get; set; }
        public string? rid_str { get; set; }
    }
}
