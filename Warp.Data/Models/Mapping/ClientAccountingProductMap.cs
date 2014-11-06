using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class ClientAccountingProductMap : EntityTypeConfiguration<ClientAccountingProduct>
    {
        public ClientAccountingProductMap()
        {
            // Primary Key
            this.HasKey(t => t.ClientAccountingProductID);

            // Properties
            this.Property(t => t.ClientAccountingProductID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ClientAccountingProduct");
            this.Property(t => t.ClientAccountingProductID).HasColumnName("ClientAccountingProductID");
            this.Property(t => t.ClientID).HasColumnName("ClientID");
            this.Property(t => t.AccountingProductID).HasColumnName("AccountingProductID");
            this.Property(t => t.DefaultValue).HasColumnName("DefaultValue");
            this.Property(t => t.KashFlowID).HasColumnName("KashFlowID");
            this.Property(t => t.ValidFrom).HasColumnName("ValidFrom");
            this.Property(t => t.ValidTo).HasColumnName("ValidTo");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Client)
                .WithMany(t => t.ClientAccountingProducts)
                .HasForeignKey(d => d.ClientID);
            this.HasRequired(t => t.AccountingProduct)
                .WithMany(t => t.ClientAccountingProducts)
                .HasForeignKey(d => d.AccountingProductID);

        }
    }
}
