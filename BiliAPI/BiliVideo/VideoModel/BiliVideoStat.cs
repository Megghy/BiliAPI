namespace BiliAPI.BiliVideo.VideoModel
{
    public struct BiliVideoStat
    {
        public long? aid { get; set; }
        public int? view { get; set; }
        public int? danmaku { get; set; }
        public int? reply { get; set; }
        public int? favorite { get; set; }
        public int? coin { get; set; }
        public int? share { get; set; }
        public int? now_rank { get; set; }
        public int? his_rank { get; set; }
        public int? like { get; set; }
        public int? dislike { get; set; }
        public string? evaluation { get; set; }
        public string? argue_msg { get; set; }
    }
}
