using BiliAPI.BiliDynamicV2.DyncmicV2Model;

namespace BiliAPI.BiliDynamicV2.BiliDynamicV2Majors
{
    public struct BiliDynamicV2ArticleMajor : IBiliDynamicV2Major
    {
        public string[] covers { get; set; }
        public string? desc { get; set; }
        public long id { get; set; }
        public string? jump_url { get; set; }
        public string? label { get; set; }
        public string? title { get; set; }
        //public BiliDynamicV2MajorTypes Type => BiliDynamicV2MajorTypes.MAJOR_TYPE_ARTICLE;
    }
}
