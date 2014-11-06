using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class ReportProblemCauseMap : EntityTypeConfiguration<ReportProblemCause>
    {
        public ReportProblemCauseMap()
        {
            // Primary Key
            this.HasKey(t => t.ReportProblemCauseID);

            // Properties
            this.Property(t => t.ReportProblemCauseID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("ReportProblemCause");
            this.Property(t => t.ReportProblemCauseID).HasColumnName("ReportProblemCauseID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
