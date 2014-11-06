using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class TerminologyBrand
    {
        public int TerminologyBrandID { get; set; }
        public short TerminologyID { get; set; }
        public int BrandID { get; set; }
        public string BrandTerm { get; set; }
        public bool Active { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual Terminology Terminology { get; set; }
    }
}
