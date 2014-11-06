using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class SchemaMap : EntityTypeConfiguration<Schema>
    {
        public SchemaMap()
        {
            // Primary Key
            this.HasKey(t => t.SchemaVersion);

            // Properties
            this.Property(t => t.SchemaVersion)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Schema", "SignalR");
            this.Property(t => t.SchemaVersion).HasColumnName("SchemaVersion");
        }
    }
}
