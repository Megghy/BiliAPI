using BiliAPI.BiliDynamicV2.DyncmicV2Model;

namespace BiliAPI.BiliDynamicV2.BiliDynamicV2Majors
{
    public struct BiliDynamicV2LiveMajor : IBiliDynamicV2Major
    {
        public BiliDynamicV2Bagde badge { get; set; }
        public string? cover { get; set; }
        public string? desc_first { get; set; }
        public string? desc_second { get; set; }
        public long id { get; set; }
        public string? jump_url { get; set; }
        public int live_state { get; set; }
        public int reserve_type { get; set; }
        public string? title { get; set; }
    }
}
