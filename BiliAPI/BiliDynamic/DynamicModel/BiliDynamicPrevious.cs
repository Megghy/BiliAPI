namespace BiliAPI.BiliDynamic.DynamicModel
{
    public struct BiliDynamicPrevious
    {
        public int uid { get; set; }
        public int type { get; set; }
        public long rid { get; set; }
        public int acl { get; set; }
        public int view { get; set; }
        public int repost { get; set; }
        public long dynamic_id { get; set; }
        public long timestamp { get; set; }
        public long pre_dy_id { get; set; }
        public long orig_dy_id { get; set; }
        public int uid_type { get; set; }
        public int r_type { get; set; }
        public int status { get; set; }
        public string dynamic_id_str { get; set; }
        public string pre_dy_id_str { get; set; }
        public string orig_dy_id_str { get; set; }
        public string rid_str { get; set; }
    }
}
