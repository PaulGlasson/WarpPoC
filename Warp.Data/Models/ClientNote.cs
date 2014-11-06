using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ClientNote
    {
        public int ClientNoteID { get; set; }
        public int ClientID { get; set; }
        public int NoteID { get; set; }
        public virtual Client Client { get; set; }
        public virtual Note Note { get; set; }
    }
}
