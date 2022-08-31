using BiliAPI.BiliInterface;

namespace BiliAPI.BiliDynamic.DynamicModel
{
    public class BiliDynamicCardRoot : IBiliData
    {
        public BiliDynamicCardContainer card { get; set; }
    }
}
