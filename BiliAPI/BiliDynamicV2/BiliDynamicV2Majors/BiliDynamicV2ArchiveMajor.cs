using BiliAPI.BiliDynamicV2.DyncmicV2Model;

namespace BiliAPI.BiliDynamicV2.BiliDynamicV2Majors
{
    public struct BiliDynamicV2ArchiveMajor : IBiliDynamicV2Major
    {
        public string? aid { get; set; }
        public BiliDynamicV2Bagde badge { get; set; }
        public string? bvid { get; set; }
        public string? cover { get; set; }
        public string? desc { get; set; }
        public int disable_preview { get; set; }
        public string? duration_text { get; set; }
        public string? jump_url { get; set; }
        public (string danmaku, string play) stat { get; set; }
        public string? title { get; set; }
        public int type { get; set; }
        //public BiliDynamicV2MajorTypes Type => BiliDynamicV2MajorTypes.MAJOR_TYPE_ARCHIVE;
    }
}
