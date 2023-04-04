namespace BiliAPI.BiliDynamicV2.DyncmicV2Model
{
    public struct BiliDynamicV2FallbackLayers
    {
        public bool is_critical_group { get; set; }
        public List<BiliDynamicV2LayersItem> layers { get; set; }
    }
    public struct BiliDynamicV2LayersItem
    {
        public BiliDynamicV2GeneralSpec general_spec { get; set; }
        //public Layer_config layer_config { get; set; }
        //public Resource resource { get; set; } TODO: 感觉没啥用啊
        public bool visible { get; set; }
    }
    public struct BiliDynamicV2GeneralSpec
    {
        public (double axis_x, double axis_y, int coordinate_pos) pos_spec { get; set; }
        public BiliDynamicV2RenderSpec render_spec { get; set; }
        public (double height, double width) size_spec { get; set; }
    }
    public struct BiliDynamicV2RenderSpec
    {
        public double opacity { get; set; }
    }
}
