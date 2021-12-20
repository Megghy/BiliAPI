using System.Text.Json.Serialization;

namespace BiliAPI.BiliDynamic.DynamicModel
{
    /// <summary>
    /// 动态卡片详细内容
    /// </summary>
    public struct BiliDynamicCardsItem
    {
        /// <summary>
        /// item内的动态详细内容, 具体类型根据desc的type区分
        /// </summary>
        [JsonIgnore]
        public dynamic? cardData { get; set; }
        public BiliDynamicDesc? desc { get; set; }
        /// <summary>
        /// 卡片原始内容
        /// </summary>
        public string card { get; set; }
        public string extend_json { get; set; }
        public BiliDynamicExtra? extra { get; set; }
        public BiliDynamicDisplay? display { get; set; }
    }
}
