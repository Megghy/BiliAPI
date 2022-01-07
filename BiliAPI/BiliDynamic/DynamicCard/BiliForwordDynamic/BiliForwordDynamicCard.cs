using BiliAPI.BiliDynamic.DynamicCard.BiliForwordDynamic;
using BiliAPI.BiliDynamic.DynamicModel;
using BiliAPI.BiliInterface;

namespace BiliAPI.BiliDynamic.DynamicCard
{
    [BiliDynamicCard(DynamicType.Forward)]
    public struct BiliForwordDynamicCard : IBiliDynamicCard
    {
        public DynamicType Type => DynamicType.Forward;
        public static BiliForwordDynamicCard? Get(string? cardJson)
        {
            var result = Utils.Deserialize<BiliForwordDynamicCard>(cardJson);
            if (!string.IsNullOrEmpty(result.origin))
                result.originData = BiliUserDynamicsData.Get(result.item?.orig_type, result.origin);
            return result;
        }

        /// <summary>
        /// 序列化之后的origin数据
        /// </summary>
        public IBiliDynamicCard? originData { get; set; }
        public BiliDynamicUserInfo? user { get; set; }
        public BiliForwordDynamicItem? item { get; set; }
        public string? origin { get; set; }
        public string? origin_extend_json { get; set; }
        public BiliDynamicUserProfile? origin_user { get; set; }
    }
}
