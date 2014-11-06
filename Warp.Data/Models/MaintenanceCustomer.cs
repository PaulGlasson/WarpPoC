using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class MaintenanceCustomer
    {
        public int MaintenanceCustomerID { get; set; }
        public int CustomerID { get; set; }
        public int MaintenanceID { get; set; }
        public System.DateTime Created { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Maintenance Maintenance { get; set; }
    }
}
