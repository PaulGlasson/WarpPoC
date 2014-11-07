using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class VisitStatusHistory
    {
        public int VisitStatusHistoryID { get; set; }
        public int VisitID { get; set; }
        public short VisitStatusID { get; set; }
        public short AdminID { get; set; }
        public System.DateTime DateValidFrom { get; set; }
        public System.DateTime DateValidTo { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual Visit Visit { get; set; }
        public virtual VisitStatu VisitStatu { get; set; }
        public virtual VisitStatu VisitStatu1 { get; set; }
    }
}
