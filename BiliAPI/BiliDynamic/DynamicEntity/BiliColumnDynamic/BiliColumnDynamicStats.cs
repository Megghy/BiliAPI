using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiliAPI.BiliDynamic.DynamicEntity.BiliColumnDynamic
{
    public struct BiliColumnDynamicStats
    {
        public int? view { get; set; }
        public int? favorite { get; set; }
        public int? like { get; set; }
        public int? dislike { get; set; }
        public int? reply { get; set; }
        public int? share { get; set; }
        public int? coin { get; set; }
        public int? @dynamic { get; set; }
    }
}
