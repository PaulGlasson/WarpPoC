using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class VisitCallInLogMap : EntityTypeConfiguration<VisitCallInLog>
    {
        public VisitCallInLogMap()
        {
            // Primary Key
            this.HasKey(t => t.VisitCallInLogID);

            // Properties
            this.Property(t => t.VisitCallInLogID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("VisitCallInLog");
            this.Property(t => t.VisitCallInLogID).HasColumnName("VisitCallInLogID");
            this.Property(t => t.VisitID).HasColumnName("VisitID");
            this.Property(t => t.CallInLogID).HasColumnName("CallInLogID");

            // Relationships
            this.HasRequired(t => t.CallInLog)
                .WithMany(t => t.VisitCallInLogs)
                .HasForeignKey(d => d.CallInLogID);
            this.HasRequired(t => t.Visit)
                .WithMany(t => t.VisitCallInLogs)
                .HasForeignKey(d => d.VisitID);

        }
    }
}
