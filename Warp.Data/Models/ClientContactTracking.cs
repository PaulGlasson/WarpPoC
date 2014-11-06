using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ClientContactTracking
    {
        public ClientContactTracking()
        {
            this.AdminClientContactTrackings = new List<AdminClientContactTracking>();
            this.CCTFurtherNotes = new List<CCTFurtherNote>();
            this.ManagerClientContactTrackings = new List<ManagerClientContactTracking>();
            this.PersonClientContactTrackings = new List<PersonClientContactTracking>();
        }

        public int ClientContactTrackingID { get; set; }
        public int ClientID { get; set; }
        public short ContactTypeID { get; set; }
        public short ClientContactStatusID { get; set; }
        public System.DateTime Date { get; set; }
        public string Notes { get; set; }
        public string AddedByAdminID { get; set; }
        public virtual Client Client { get; set; }
        public virtual ClientContactStatu ClientContactStatu { get; set; }
        public virtual ICollection<AdminClientContactTracking> AdminClientContactTrackings { get; set; }
        public virtual ICollection<CCTFurtherNote> CCTFurtherNotes { get; set; }
        public virtual ICollection<ManagerClientContactTracking> ManagerClientContactTrackings { get; set; }
        public virtual ICollection<PersonClientContactTracking> PersonClientContactTrackings { get; set; }
    }
}
