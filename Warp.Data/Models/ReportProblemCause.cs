using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ReportProblemCause
    {
        public ReportProblemCause()
        {
            this.ReportProblemTrackings = new List<ReportProblemTracking>();
        }

        public short ReportProblemCauseID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<ReportProblemTracking> ReportProblemTrackings { get; set; }
    }
}
