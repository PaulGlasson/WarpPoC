using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class NoteTypeMap : EntityTypeConfiguration<NoteType>
    {
        public NoteTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.NoteTypeID);

            // Properties
            this.Property(t => t.NoteTypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("NoteType");
            this.Property(t => t.NoteTypeID).HasColumnName("NoteTypeID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
