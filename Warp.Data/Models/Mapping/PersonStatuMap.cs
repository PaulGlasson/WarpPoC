using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class PersonStatuMap : EntityTypeConfiguration<PersonStatu>
    {
        public PersonStatuMap()
        {
            // Primary Key
            this.HasKey(t => t.PersonStatusId);

            // Properties
            this.Property(t => t.Status)
                .IsRequired()
                .HasMaxLength(15);

            // Table & Column Mappings
            this.ToTable("PersonStatus", "Client");
            this.Property(t => t.PersonStatusId).HasColumnName("PersonStatusId");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.LastUpdated).HasColumnName("LastUpdated");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
