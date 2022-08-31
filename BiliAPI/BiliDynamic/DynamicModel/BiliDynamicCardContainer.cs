using BiliAPI.BiliInterface;
using System.Text.Json.Serialization;

namespace BiliAPI.BiliDynamic.DynamicModel
{
    /// <summary>
    /// 动态卡片详细内容的容器
    /// </summary>
    public struct BiliDynamicCardContainer : IBiliData
    {
        /// <summary>
        /// card内的动态详细内容, 具体类型根据desc的type区分
        /// </summary>
        [JsonIgnore]
        public IBiliDynamicCard? cardData { get; set; }
        /// <summary>
        /// 卡片类型
        /// </summary>
        [JsonIgnore]
        public DynamicType? cardType => (DynamicType)(desc?.type ?? -1);


        public BiliDynamicDesc? desc { get; set; }
        public string? card { get; set; }
        public string? extend_json { get; set; }
        public BiliDynamicExtra? extra { get; set; }
        public BiliDynamicDisplay? display { get; set; }
    }
}
