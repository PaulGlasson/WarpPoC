using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class RegionGroup
    {
        public RegionGroup()
        {
            this.Regions = new List<Region>();
        }

        public int RegionGroupID { get; set; }
        public string Name { get; set; }
        public System.DateTime Created { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Region> Regions { get; set; }
    }
}
