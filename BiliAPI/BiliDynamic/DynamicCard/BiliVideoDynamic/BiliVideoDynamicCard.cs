using BiliAPI.BiliDynamic.DynamicModel;
using BiliAPI.BiliInterface;
using BiliAPI.BiliVideo.VideoModel;

namespace BiliAPI.BiliDynamic.DynamicCard.BiliVideoDynamic
{
    [BiliDynamicCard(DynamicType.Video)]
    public struct BiliVideoDynamicCard : IBiliDynamicCard
    {
        public static BiliVideoDynamicCard Get(string? cardJson)
        {
            return Utils.Deserialize<BiliVideoDynamicCard>(cardJson);
        }

        public DynamicType Type => DynamicType.Video;
        public long? aid { get; set; }
        public int? attribute { get; set; }
        public long? cid { get; set; }
        public int? copyright { get; set; }
        public long? ctime { get; set; }
        public string? desc { get; set; }
        public BiliVideoDynamicDimension dimension { get; set; }
        public int? duration { get; set; }
        public string? @dynamic { get; set; }
        public string? first_frame { get; set; }
        public string? jump_url { get; set; }
        public BiliDynamicUserInfo owner { get; set; }
        public string? pic { get; set; }
        public string? player_info { get; set; }
        public long? pubdate { get; set; }
        public BiliVideoRights rights { get; set; }
        public string? short_link { get; set; }
        public string? short_link_v2 { get; set; }
        public BiliVideoDynamicStat stat { get; set; }
        public int? state { get; set; }
        public int? tid { get; set; }
        public string? title { get; set; }
        public string? tname { get; set; }
        public int? videos { get; set; }
    }
}
