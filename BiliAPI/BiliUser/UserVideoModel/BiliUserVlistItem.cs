namespace BiliAPI.BiliUser.UserVideoModel
{
    public struct BiliUserVlistItem
    {
        public int comment { get; set; }
        public int typeid { get; set; }
        public int play { get; set; }
        public string pic { get; set; }
        public string subtitle { get; set; }
        public string description { get; set; }
        public string copyright { get; set; }
        public string title { get; set; }
        public int review { get; set; }
        public string author { get; set; }
        public int mid { get; set; }
        public long created { get; set; }
        public string length { get; set; }
        public int video_review { get; set; }
        public int aid { get; set; }
        public string bvid { get; set; }
        public bool hide_click { get; set; }
        public bool is_pay { get; set; }
        public bool is_union_video { get; set; }
        public bool is_steins_gate { get; set; }
        public bool is_live_playback { get; set; }
    }
}
