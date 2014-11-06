using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class ContactAddressBrandMap : EntityTypeConfiguration<ContactAddressBrand>
    {
        public ContactAddressBrandMap()
        {
            // Primary Key
            this.HasKey(t => t.ContactAddressBrandID);

            // Properties
            this.Property(t => t.ContactAddressBrandID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ContactAddressBrand", "Client");
            this.Property(t => t.ContactAddressBrandID).HasColumnName("ContactAddressBrandID");
            this.Property(t => t.ContactAddressID).HasColumnName("ContactAddressID");
            this.Property(t => t.BrandID).HasColumnName("BrandID");
            this.Property(t => t.ContactAddressTypeID).HasColumnName("ContactAddressTypeID");
            this.Property(t => t.ValidFrom).HasColumnName("ValidFrom");
            this.Property(t => t.ValidTo).HasColumnName("ValidTo");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Brand)
                .WithMany(t => t.ContactAddressBrands)
                .HasForeignKey(d => d.BrandID);
            this.HasRequired(t => t.ContactAddress)
                .WithMany(t => t.ContactAddressBrands)
                .HasForeignKey(d => d.ContactAddressID);
            this.HasRequired(t => t.ContactAddressType)
                .WithMany(t => t.ContactAddressBrands)
                .HasForeignKey(d => d.ContactAddressTypeID);

        }
    }
}
