using BiliAPI.BiliUser.UserModel;

namespace BiliAPI.BiliVideo.VideoModel
{
    public struct BiliVideoSubtitleItem
    {
        public long? id { get; set; }
        public string? lan { get; set; }
        public string? lan_doc { get; set; }
        public bool is_lock { get; set; }
        public long? author_mid { get; set; }
        public string? subtitle_url { get; set; }
        public BiliUserData? author { get; set; }
    }
}
