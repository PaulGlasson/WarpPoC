using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class TriggerInstanceReportStatusTypeMap : EntityTypeConfiguration<TriggerInstanceReportStatusType>
    {
        public TriggerInstanceReportStatusTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.TriggerInstanceReportStatusTypeId);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(250);

            this.Property(t => t.Description)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("TriggerInstanceReportStatusType", "Subscriptions");
            this.Property(t => t.TriggerInstanceReportStatusTypeId).HasColumnName("TriggerInstanceReportStatusTypeId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
        }
    }
}
