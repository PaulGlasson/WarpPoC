using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class AssessorAttributeOption
    {
        public AssessorAttributeOption()
        {
            this.AssessorAttributes = new List<AssessorAttribute>();
        }

        public short AssessorAttributeOptionID { get; set; }
        public short AssessorAttributeItemID { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<AssessorAttribute> AssessorAttributes { get; set; }
        public virtual AssessorAttributeItem AssessorAttributeItem { get; set; }
    }
}
