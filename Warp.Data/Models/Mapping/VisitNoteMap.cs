using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class VisitNoteMap : EntityTypeConfiguration<VisitNote>
    {
        public VisitNoteMap()
        {
            // Primary Key
            this.HasKey(t => t.VisitNoteID);

            // Properties
            this.Property(t => t.VisitNoteID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("VisitNote");
            this.Property(t => t.VisitNoteID).HasColumnName("VisitNoteID");
            this.Property(t => t.VisitID).HasColumnName("VisitID");
            this.Property(t => t.NoteID).HasColumnName("NoteID");

            // Relationships
            this.HasRequired(t => t.Note)
                .WithMany(t => t.VisitNotes)
                .HasForeignKey(d => d.NoteID);
            this.HasRequired(t => t.Visit)
                .WithMany(t => t.VisitNotes)
                .HasForeignKey(d => d.VisitID);

        }
    }
}
