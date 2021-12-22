namespace BiliAPI.BiliUser.UserModel
{
    public struct BiliVip
    {
        public int type { get; set; }
        public int status { get; set; }
        public long due_date { get; set; }
        public int vip_pay_type { get; set; }
        public int theme_type { get; set; }
        public BiliLabel label { get; set; }
        public int avatar_subscript { get; set; }
        public string nickname_color { get; set; }
        public int role { get; set; }
        public string avatar_subscript_url { get; set; }
    }
}
