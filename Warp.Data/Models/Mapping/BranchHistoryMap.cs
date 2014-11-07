using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class BranchHistoryMap : EntityTypeConfiguration<BranchHistory>
    {
        public BranchHistoryMap()
        {
            // Primary Key
            this.HasKey(t => t.BranchHistoryID);

            // Properties
            this.Property(t => t.Notes)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("BranchHistory", "Client");
            this.Property(t => t.BranchHistoryID).HasColumnName("BranchHistoryID");
            this.Property(t => t.BranchID).HasColumnName("BranchID");
            this.Property(t => t.BranchStatusID).HasColumnName("BranchStatusID");
            this.Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            this.Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            this.Property(t => t.AreaID).HasColumnName("AreaID");
            this.Property(t => t.Notes).HasColumnName("Notes");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.EnteredByUserRoleID).HasColumnName("EnteredByUserRoleID");

            // Relationships
            this.HasRequired(t => t.Branch)
                .WithMany(t => t.BranchHistories)
                .HasForeignKey(d => d.BranchID);
            this.HasRequired(t => t.BranchStatu)
                .WithMany(t => t.BranchHistories)
                .HasForeignKey(d => d.BranchStatusID);

        }
    }
}
