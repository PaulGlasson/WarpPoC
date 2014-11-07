using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class SimpleVisitTemplateBranch
    {
        public int SimpleVisitTemplateBranchID { get; set; }
        public int SimpleVisitTemplateID { get; set; }
        public int BranchID { get; set; }
        public bool Active { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
    }
}
