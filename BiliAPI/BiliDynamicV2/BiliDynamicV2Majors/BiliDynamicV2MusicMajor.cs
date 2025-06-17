namespace BiliAPI.BiliDynamicV2.BiliDynamicV2Majors
{
    public struct BiliDynamicV2MusicMajor : IBiliDynamicV2Major
    {
        public string? cover { get; set; }
        public long id { get; set; }
        public string? jump_url { get; set; }
        public string? label { get; set; }
        public string? title { get; set; }
        //public BiliDynamicV2MajorTypes Type => BiliDynamicV2MajorTypes.MAJOR_TYPE_MUSIC;
    }
}
