namespace BiliAPI.BiliDynamicV2.BiliDynamicV2Majors
{
    public struct BiliDynamicV2LiveRcmdMajor : IBiliDynamicV2Major
    {
        public string? content { get; set; }
        public int reserve_type { get; set; }
        //public BiliDynamicV2MajorTypes Type => BiliDynamicV2MajorTypes.MAJOR_TYPE_LIVE_RCMD;
    }
}
