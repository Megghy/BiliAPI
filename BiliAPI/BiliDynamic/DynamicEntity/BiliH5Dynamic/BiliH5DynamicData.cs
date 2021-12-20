﻿using BiliAPI.BiliDynamic.DynamicModel;

namespace BiliAPI.BiliDynamic.DynamicEntity.BiliH5Dynamic
{
    public struct BiliH5DynamicData
    {
        public static BiliH5DynamicData Get(string cardJson)
        {
            return Utils.Deserialize<BiliH5DynamicData>(cardJson);
        }
        public int rid { get; set; }
        public BiliDynamicUserInfo user { get; set; }
        public BiliH5DynamicVest vest { get; set; }
        public BiliH5DynamicSketch sketch { get; set; }
    }
}
