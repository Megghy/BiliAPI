namespace BiliAPI.BiliUser.UserModel
{
    public struct BiliMedal
    {
        public long? uid { get; set; }
        public long? target_id { get; set; }
        public int? medal_id { get; set; }
        public int? level { get; set; }
        public string? medal_name { get; set; }
        public int? medal_color { get; set; }
        public int? intimacy { get; set; }
        public int? next_intimacy { get; set; }
        public int? day_limit { get; set; }
        public int? medal_color_start { get; set; }
        public int? medal_color_end { get; set; }
        public int? medal_color_border { get; set; }
        public bool is_lighted { get; set; }
        public int? light_status { get; set; }
        public int? wearing_status { get; set; }
        public int? score { get; set; }
    }
}
