namespace BiliAPI.BiliDynamicV2.BiliDynamicV2Majors
{
    public struct BiliDynamicV2DrawMajor
    {
        public long id { get; set; }
        public BiliDynamicV2DrawMajorItem[]? items { get; set; }
    }
    public struct BiliDynamicV2DrawMajorItem
    {
        public int height { get; set; }
        public int width { get; set; }
        public double size { get; set; }
        public string? src { get; set; }
        public BiliDynamicV2DrawMajorTag[]? tags { get; set; }
    }
    public struct BiliDynamicV2DrawMajorTag
    {
        public int item_id { get; set; }
        public string? jump_url { get; set; }
        public int mid { get; set; }
        public int orientation { get; set; }
        public string? poi { get; set; }
        public string? schema_url { get; set; }
        public int source { get; set; }
        public string? text { get; set; }
        public int tid { get; set; }
        public int type { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }
}
