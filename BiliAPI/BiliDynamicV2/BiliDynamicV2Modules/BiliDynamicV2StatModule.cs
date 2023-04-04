namespace BiliAPI.BiliDynamicV2.BiliDynamicV2Modules
{
    public struct BiliDynamicV2StatModule
    {
        public (int count, bool forbidden) comment { get; set; }
        public (int count, bool forbidden) forword { get; set; }
        public (int count, bool forbidden, bool status) like { get; set; }
    }
}
