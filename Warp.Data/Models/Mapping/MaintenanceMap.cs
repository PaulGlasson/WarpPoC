using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class MaintenanceMap : EntityTypeConfiguration<Maintenance>
    {
        public MaintenanceMap()
        {
            // Primary Key
            this.HasKey(t => t.MaintenanceID);

            // Properties
            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Details)
                .IsRequired()
                .HasMaxLength(2000);

            this.Property(t => t.HyperlinkURL)
                .HasMaxLength(255);

            this.Property(t => t.HyperlinkText)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("Maintenance");
            this.Property(t => t.MaintenanceID).HasColumnName("MaintenanceID");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Details).HasColumnName("Details");
            this.Property(t => t.MaintenanceCategoryID).HasColumnName("MaintenanceCategoryID");
            this.Property(t => t.DisplayFrom).HasColumnName("DisplayFrom");
            this.Property(t => t.DisplayTo).HasColumnName("DisplayTo");
            this.Property(t => t.HyperlinkURL).HasColumnName("HyperlinkURL");
            this.Property(t => t.HyperlinkText).HasColumnName("HyperlinkText");
            this.Property(t => t.RemovedBy).HasColumnName("RemovedBy");
            this.Property(t => t.AddedBy).HasColumnName("AddedBy");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.LastUpdated).HasColumnName("LastUpdated");

            // Relationships
            this.HasRequired(t => t.MaintenanceCategory)
                .WithMany(t => t.Maintenances)
                .HasForeignKey(d => d.MaintenanceCategoryID);

        }
    }
}
