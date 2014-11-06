using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class ExpenseStatuMap : EntityTypeConfiguration<ExpenseStatu>
    {
        public ExpenseStatuMap()
        {
            // Primary Key
            this.HasKey(t => t.ExpenseStatusID);

            // Properties
            this.Property(t => t.ExpenseStatusID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("ExpenseStatus");
            this.Property(t => t.ExpenseStatusID).HasColumnName("ExpenseStatusID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
        }
    }
}
