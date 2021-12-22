using BiliAPI.BiliDynamic.DynamicModel;

namespace BiliAPI.BiliDynamic.DynamicEntity.BiliAudioDynamic
{
    public struct BiliAudioDynamicCard : IBiliDynamicCard
    {
        public static BiliAudioDynamicCard Get(string? cardJson)
        {
            return Utils.Deserialize<BiliAudioDynamicCard>(cardJson);
        }
        public DynamicType Type => DynamicType.Audio;
        public int? id { get; set; }
        public int? upId { get; set; }
        public string? title { get; set; }
        public string? upper { get; set; }
        public string? cover { get; set; }
        public string? author { get; set; }
        public long? ctime { get; set; }
        public int? replyCnt { get; set; }
        public int? playCnt { get; set; }
        public string? intro { get; set; }
        public string? schema { get; set; }
        public string? typeInfo { get; set; }
        public string? upperAvatar { get; set; }
    }
}
