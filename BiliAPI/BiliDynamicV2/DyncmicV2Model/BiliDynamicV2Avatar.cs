namespace BiliAPI.BiliDynamicV2.DyncmicV2Model
{
    public struct BiliDynamicV2Avatar
    {
        public (double width, double height) container_size { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public BiliDynamicV2FallbackLayers fallback_layers { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string mid { get; set; }
    }
}
