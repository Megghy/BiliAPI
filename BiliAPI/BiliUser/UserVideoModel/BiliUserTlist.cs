using System.Text.Json.Serialization;
using BiliAPI.BiliUser.UserModel;

namespace BiliAPI.BiliUser.UserVideoModel
{
    /// <summary>
    /// 分区 写的很怪
    /// 待添加
    /// </summary>
    public struct BiliUserTlist
    {
        [JsonPropertyName("1")]
        public BiliZone? Animation { get; set; }
        [JsonPropertyName("4")]
        public BiliZone? Game { get; set; }
        [JsonPropertyName("36")]
        public BiliZone? Knowladge { get; set; }
        [JsonPropertyName("160")]
        public BiliZone? Life { get; set; }
        [JsonPropertyName("167")]
        public BiliZone? NationalCreation { get; set; }
        [JsonPropertyName("181")]
        public BiliZone? Video { get; set; }
    }
}
