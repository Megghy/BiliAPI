namespace BiliAPI.BiliVideo.VideoModel
{
    public struct BiliVideoPageItem
    {
        public long? cid { get; set; }
        public int? page { get; set; }
        public string? @from { get; set; }
        public string? part { get; set; }
        public int? duration { get; set; }
        public string? vid { get; set; }
        public string? weblink { get; set; }
        public BiliVideoDimision dimension { get; set; }
        public string? first_frame { get; set; }
    }
}
