﻿using BiliAPI.BiliDynamicV2.BiliDynamicV2Modules;
using BiliAPI.BiliInterface;

namespace BiliAPI.BiliDynamicV2.DyncmicV2Model
{
    public class BiliDynamicV2ItemContainer : IBiliData
    {
        public BiliDynamicV2Item? item { get; set; }
    }
    public class BiliDynamicV2Item
    {
        public BiliDynamicV2Basic basic { get; set; }
        public string id_str { get; set; }
        public BiliDynamicV2Module modules { get; set; }
        public BiliDynamicV2Item? orig { get; set; }
        public BiliDynamicV2Types type { get; set; }
        public bool visible { get; set; }
    }
}
