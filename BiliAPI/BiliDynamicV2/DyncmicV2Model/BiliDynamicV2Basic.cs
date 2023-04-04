namespace BiliAPI.BiliDynamicV2.DyncmicV2Model
{
    public struct BiliDynamicV2Basic
    {
        public string comment_id_str { get; set; }
        public int comment_type { get; set; }
        public BiliDynamicV2LickIcon like_icon { get; set; }
        public string rid_str { get; set; }
    }
    public struct BiliDynamicV2LickIcon
    {
        public string action_url { get; set; }
        public string end_url { get; set; }
        public int id { get; set; }
        public string start_url { get; set; }
    }
}
