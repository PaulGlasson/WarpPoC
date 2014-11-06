using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class IndustrySector
    {
        public IndustrySector()
        {
            this.Brands = new List<Brand>();
        }

        public int IndustrySectorID { get; set; }
        public string SectorName { get; set; }
        public string SectorNameForAssessor { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Brand> Brands { get; set; }
    }
}
