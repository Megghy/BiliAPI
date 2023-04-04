using BiliAPI.BiliDynamicV2.BiliDynamicV2Majors;

namespace BiliAPI.BiliDynamicV2.BiliDynamicV2Modules
{
    public struct BiliDynamicV2DynamicModule
    {
        //public string? additional { get; set; }
        public BiliDynamicV2DynamicModuleDesc? desc { get; set; }
        public BiliDynamicV2Major? major { get; set; }
        public BiliDynamicV2DynamicModuleTopic? topic { get; set; }
    }
    public struct BiliDynamicV2DynamicModuleTopic
    {
        public string jump_url { get; set; }
        public string name { get; set; }
        public int id { get; set; }
    }
    public struct BiliDynamicV2DynamicModuleDesc
    {
        public string text { get; set; }
        public BiliDynamicV2DynamicModuleDescTextNode[] rich_text_nodes { get; set; }
    }
    public struct BiliDynamicV2DynamicModuleDescTextNode
    {
        public string orig_text { get; set; }
        public string rid { get; set; }
        public string text { get; set; }
        public string type { get; set; }
    }
}
