using BiliAPI.BiliDynamicV2.DyncmicV2Model;

namespace BiliAPI.BiliDynamicV2.BiliDynamicV2Majors
{
    public struct BiliDynamicV2CommonMajor : IBiliDynamicV2Major
    {
        public BiliDynamicV2Bagde badge { get; set; }
        public int biz_type { get; set; }
        public string? cover { get; set; }
        public string? desc { get; set; }
        public string? id { get; set; }
        public string? jump_url { get; set; }
        public string? label { get; set; }
        public string? sketch_id { get; set; }
        public int style { get; set; }
        public string? title { get; set; }
        //public BiliDynamicV2MajorTypes Type => BiliDynamicV2MajorTypes.MAJOR_TYPE_COMMON;
    }
}
