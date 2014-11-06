using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class BriefConfigurationBranch
    {
        public int BriefConfigurationBranchID { get; set; }
        public int BriefConfigurationID { get; set; }
        public int BranchID { get; set; }
        public bool Permission { get; set; }
        public bool Active { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual BriefConfiguration BriefConfiguration { get; set; }
    }
}
