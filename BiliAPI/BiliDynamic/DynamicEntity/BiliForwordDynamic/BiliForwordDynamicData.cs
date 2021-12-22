using BiliAPI.BiliDynamic.DynamicEntity.BiliForwordDynamic;
using BiliAPI.BiliDynamic.DynamicModel;

namespace BiliAPI.BiliDynamic.DynamicEntity
{
    public struct BiliForwordDynamicData : IBiliDynamicCard
    {
        public DynamicType Type => DynamicType.Forward;
        public static BiliForwordDynamicData? Get(string cardJson)
        {
            var result = Utils.Deserialize<BiliForwordDynamicData>(cardJson);
            if (!string.IsNullOrEmpty(result.origin))
                result.originData = Utils.Deserialize<BiliForwordDynamicOriginData>(result.origin);
            return result;
        }

        /// <summary>
        /// 序列化之后的origin数据
        /// </summary>
        public BiliForwordDynamicOriginData originData { get; set; }

        public BiliDynamicUserInfo user { get; set; }
        public BiliForwordDynamicItem item { get; set; }
        public string origin { get; set; }
        public string origin_extend_json { get; set; }
        public BiliDynamicUserProfile origin_user { get; set; }
    }
}
