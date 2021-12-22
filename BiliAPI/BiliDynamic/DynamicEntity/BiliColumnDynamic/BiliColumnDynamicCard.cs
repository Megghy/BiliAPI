using BiliAPI.BiliDynamic.DynamicModel;
using BiliAPI.BiliUser.UserModel;

namespace BiliAPI.BiliDynamic.DynamicEntity.BiliColumnDynamic
{
    public struct BiliColumnDynamicCard : IBiliDynamicCard
    {
        public static BiliColumnDynamicCard Get(string? cardJson)
        {
            return Utils.Deserialize<BiliColumnDynamicCard>(cardJson);
        }
        public DynamicType Type => DynamicType.Column;
        public int? id { get; set; }
        public BiliColumnDynamicCategory category { get; set; }
        public BiliColumnDynamicCategory[]? categories { get; set; }
        public string? title { get; set; }
        public string? summary { get; set; }
        public string? banner_url { get; set; }
        public int? template_id { get; set; }
        public int? state { get; set; }
        public BiliUserData author { get; set; }
        public int? reprint { get; set; }
        public string[]? image_urls { get; set; }
        public long? publish_time { get; set; }
        public long? ctime { get; set; }
        public BiliColumnDynamicStats stats { get; set; }
        public int? words { get; set; }
        public string[]? origin_image_urls { get; set; }
        public string? list { get; set; }
        public string? is_like { get; set; }
        public BiliColumnDynamicMedia media { get; set; }
        public string? apply_time { get; set; }
        public string? check_time { get; set; }
        public int? original { get; set; }
        public int? act_id { get; set; }
        public string? dispute { get; set; }
        public string? authenMark { get; set; }
        public int? cover_avid { get; set; }
        public string? top_video_info { get; set; }
        public int? type { get; set; }
    }
}
