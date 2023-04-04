namespace BiliAPI.BiliDynamicV2.BiliDynamicV2Modules
{
    public struct BiliDynamicV2Module
    {
        public BiliDynamicV2AuthorModule? module_author { get; set; }
        public BiliDynamicV2DynamicModule module_dynamic { get; set; }
        public BiliDynamicV2InteractionModule? module_interaction { get; set; }
        public BiliDynamicV2MoreModule? module_more { get; set; }
        public BiliDynamicV2StatModule? module_stat { get; set; }
    }
}
