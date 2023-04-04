using BiliAPI.BiliInterface;

namespace BiliAPI.BiliDynamicV2.DyncmicV2Model
{
    public class BiliDynamicV2Data : IBiliData
    {
#pragma warning disable CS8618 // 在退出构造函数时，不可为 null 的字段必须包含非 null 值。请考虑声明为可以为 null。
        public bool has_more { get; set; }
        public BiliDynamicV2Item[] items { get; set; }
        public string offset { get; set; }
        public string update_baseline { get; set; }
        public int update_num { get; set; }
#pragma warning restore CS8618 // 在退出构造函数时，不可为 null 的字段必须包含非 null 值。请考虑声明为可以为 null。
    }
}
