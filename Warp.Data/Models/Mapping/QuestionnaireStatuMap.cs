using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class QuestionnaireStatuMap : EntityTypeConfiguration<QuestionnaireStatu>
    {
        public QuestionnaireStatuMap()
        {
            // Primary Key
            this.HasKey(t => t.QuestionnaireStatusID);

            // Properties
            this.Property(t => t.QuestionnaireStatusID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("QuestionnaireStatus");
            this.Property(t => t.QuestionnaireStatusID).HasColumnName("QuestionnaireStatusID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
        }
    }
}
