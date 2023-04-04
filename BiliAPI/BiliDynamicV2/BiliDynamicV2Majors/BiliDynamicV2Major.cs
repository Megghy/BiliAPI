using BiliAPI.BiliDynamicV2.DyncmicV2Model;

namespace BiliAPI.BiliDynamicV2.BiliDynamicV2Majors
{
    public struct BiliDynamicV2Major
    {
        public BiliDynamicV2DrawMajor? draw { get; set; }
        public BiliDynamicV2PgcMajor? pgc { get; set; }
        public BiliDynamicV2UgcSeasonMajor? ugc_season { get; set; }
        public BiliDynamicV2ArticleMajor? article { get; set; }
        public BiliDynamicV2ArchiveMajor? archive { get; set; }
        public BiliDynamicV2LiveRcmdMajor? live_rcmd { get; set; }
        public BiliDynamicV2LiveMajor? live { get; set; }
        public BiliDynamicV2CommonMajor? common { get; set; }
        public BiliDynamicV2CoursesMajor? courses { get; set; }
        public BiliDynamicV2MusicMajor? music { get; set; }
        public BiliDynamicV2NoneMajor? none { get; set; }

        public BiliDynamicV2MajorTypes type { get; set; }
    }
}
