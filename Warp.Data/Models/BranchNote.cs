using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class BranchNote
    {
        public int BranchNoteID { get; set; }
        public int BranchID { get; set; }
        public int NoteID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual Note Note { get; set; }
    }
}
