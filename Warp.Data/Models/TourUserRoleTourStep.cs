using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class TourUserRoleTourStep
    {
        public int TourUserRoleTourStepID { get; set; }
        public int TourUserRoleID { get; set; }
        public int TourStepID { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual TourStep TourStep { get; set; }
        public virtual TourUserRole TourUserRole { get; set; }
    }
}
