using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class NoteType
    {
        public NoteType()
        {
            this.Notes = new List<Note>();
        }

        public short NoteTypeID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Note> Notes { get; set; }
    }
}
