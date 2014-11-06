using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class LogMap : EntityTypeConfiguration<Log>
    {
        public LogMap()
        {
            // Primary Key
            this.HasKey(t => t.LogID);

            // Properties
            this.Property(t => t.context)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.behaviour)
                .HasMaxLength(50);

            this.Property(t => t.timestamp)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8)
                .IsRowVersion();

            // Table & Column Mappings
            this.ToTable("Log");
            this.Property(t => t.LogID).HasColumnName("LogID");
            this.Property(t => t.context).HasColumnName("context");
            this.Property(t => t.context_id).HasColumnName("context_id");
            this.Property(t => t.behaviour).HasColumnName("behaviour");
            this.Property(t => t.timestamp).HasColumnName("timestamp");
            this.Property(t => t.user_id).HasColumnName("user_id");
        }
    }
}
