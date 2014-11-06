using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class AreaHistoryMap : EntityTypeConfiguration<AreaHistory>
    {
        public AreaHistoryMap()
        {
            // Primary Key
            this.HasKey(t => t.AreaHistoryID);

            // Properties
            this.Property(t => t.AreaName)
                .HasMaxLength(200);

            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.Notes)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("AreaHistory", "Client");
            this.Property(t => t.AreaHistoryID).HasColumnName("AreaHistoryID");
            this.Property(t => t.AreaID).HasColumnName("AreaID");
            this.Property(t => t.AreaName).HasColumnName("AreaName");
            this.Property(t => t.AreaStatusID).HasColumnName("AreaStatusID");
            this.Property(t => t.RegionID).HasColumnName("RegionID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.ValidFrom).HasColumnName("ValidFrom");
            this.Property(t => t.ValidTo).HasColumnName("ValidTo");
            this.Property(t => t.EnteredByAdminID).HasColumnName("EnteredByAdminID");
            this.Property(t => t.Notes).HasColumnName("Notes");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.LastUpdated).HasColumnName("LastUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Area)
                .WithMany(t => t.AreaHistories)
                .HasForeignKey(d => d.AreaID);
            this.HasRequired(t => t.Region)
                .WithMany(t => t.AreaHistories)
                .HasForeignKey(d => d.RegionID);
            this.HasRequired(t => t.AreaStatu)
                .WithMany(t => t.AreaHistories)
                .HasForeignKey(d => d.AreaStatusID);

        }
    }
}
