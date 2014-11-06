using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class GeographicRegionMap : EntityTypeConfiguration<GeographicRegion>
    {
        public GeographicRegionMap()
        {
            // Primary Key
            this.HasKey(t => t.GeographicRegionID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("GeographicRegion");
            this.Property(t => t.GeographicRegionID).HasColumnName("GeographicRegionID");
            this.Property(t => t.GeographicCountryID).HasColumnName("GeographicCountryID");
            this.Property(t => t.Name).HasColumnName("Name");

            // Relationships
            this.HasRequired(t => t.GeographicCountry)
                .WithMany(t => t.GeographicRegions)
                .HasForeignKey(d => d.GeographicCountryID);

        }
    }
}
