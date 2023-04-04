using BiliAPI.BiliDynamicV2.DyncmicV2Model;

namespace BiliAPI.BiliDynamicV2.BiliDynamicV2Majors
{
    public struct BiliDynamicV2PgcMajor
    {
        public BiliDynamicV2Bagde badge { get; set; }
        public string? cover { get; set; }
        public int epid { get; set; }
        public string? jump_url { get; set; }
        public int season_id { get; set; }
        public (string danmaku, string play) stat { get; set; }
        public int sub_type { get; set; }
        public string? title { get; set; }
        public int type { get; set; }
    }
}
